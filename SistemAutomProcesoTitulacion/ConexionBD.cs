using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace SistemAutomProcesoTitulacion
{
    public class ConexionBD
    {
        private static string cadena = "Server=.; Database=SistemaTitulacionUTEQ; Integrated Security=true";
        private static SqlConnection conexion = new SqlConnection(cadena);

        public static SqlConnection ObtenerConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                    MessageBox.Show("✅ Conexión exitosa a la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar con la base de datos: " + ex.Message);
            }

            return conexion;
        }

        public static void CerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                    MessageBox.Show("🔒 Conexión cerrada correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Error al cerrar la conexión: " + ex.Message);
            }
        }

        public static string ValidarLogin(string correo, string contrasena)
        {
            string rol = null;

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("LoginUsuario", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            rol = reader["Rol"].ToString(); // 👌 directo desde SP
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error en la validación: " + ex.Message);
            }

            return rol;
        }

        public static DataTable ObtenerUsuarios(string estado)
        {
            DataTable dt = new DataTable();
            try
            {
                string procedimiento = estado == "Activos"
                    ? "ListarUsuarios"
                    : estado == "Inactivos"
                        ? "ListarUsuariosInactivos"
                        : "ListarUsuarios"; // Por defecto activos

                using (SqlConnection con = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand(procedimiento, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al obtener usuarios: " + ex.Message);
            }
            return dt;
        }

        public static DataTable FiltrarUsuarios(string filtro)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand("FiltrarUsuarios", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Filtro", filtro);

                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al filtrar usuarios: " + ex.Message);
            }
            return dt;
        }

        public static bool RegistrarUsuario(string nombre, string cedula, string correo, string contrasena, string rol)
        {
            bool exito = false;
            try
            {
                if (ConexionBD.UsuarioDuplicado(correo, cedula, contrasena))
                {
                    MessageBox.Show("⚠️ Ya existe un usuario con ese correo, cédula o la misma combinación de correo y contraseña.");
                    return exito;
                }

                using (SqlConnection con = new SqlConnection(cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("RegistrarUsuario", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreCompleto", nombre);
                        cmd.Parameters.AddWithValue("@Cedula", cedula);
                        cmd.Parameters.AddWithValue("@CorreoInstitucional", correo);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena); // el SP ya encripta
                        cmd.Parameters.AddWithValue("@Rol", rol);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        exito = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al registrar usuario: " + ex.Message);
            }
            return exito;
        }

        public static bool RegistrarUsuario(string nombre, string cedula, string correo, string contrasena, string rol, int estado)
        {
            bool exito = false;
            try
            {
                if (ConexionBD.UsuarioDuplicado(correo, cedula, contrasena))
                {
                    MessageBox.Show("⚠️ Ya existe un usuario con ese correo, cédula o la misma combinación de correo y contraseña.");
                    return exito;
                }

                using (SqlConnection con = new SqlConnection(cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("RegistrarUsuario", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreCompleto", nombre);
                        cmd.Parameters.AddWithValue("@Cedula", cedula);
                        cmd.Parameters.AddWithValue("@CorreoInstitucional", correo);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                        cmd.Parameters.AddWithValue("@Rol", rol);
                        cmd.Parameters.AddWithValue("@Estado", estado);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        exito = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al registrar usuario: " + ex.Message);
            }
            return exito;
        }

        public static bool UsuarioDuplicado(string correo, string cedula, string contrasena)
        {
            bool existe = false;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand("ValidarUsuarioDuplicado", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CorreoInstitucional", correo);
                    cmd.Parameters.AddWithValue("@Cedula", cedula);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && Convert.ToInt32(result) == 1)
                        existe = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al validar duplicados: " + ex.Message);
            }
            return existe;
        }

        public static bool ActualizarUsuario(int idUsuario, string nombre, string cedula, string correo, string contrasena, string rol)
        {
            bool exito = false;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarUsuario", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@NombreCompleto", nombre);
                        cmd.Parameters.AddWithValue("@Cedula", cedula);
                        cmd.Parameters.AddWithValue("@CorreoInstitucional", correo);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                        cmd.Parameters.AddWithValue("@Rol", rol);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        exito = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al modificar usuario: " + ex.Message);
            }
            return exito;
        }

        public static bool ActualizarUsuario(int idUsuario, string nombre, string cedula, string correo, string contrasena, string rol, int estado)
        {
            bool exito = false;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarUsuario", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@NombreCompleto", nombre);
                        cmd.Parameters.AddWithValue("@Cedula", cedula);
                        cmd.Parameters.AddWithValue("@CorreoInstitucional", correo);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                        cmd.Parameters.AddWithValue("@Rol", rol);
                        cmd.Parameters.AddWithValue("@Estado", estado);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        exito = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al modificar usuario: " + ex.Message);
            }
            return exito;
        }

        public static (string Nombre, string Rol) ValidarLoginDatos(string correo, string contrasena)
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_ValidarLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string nombre = reader["NombreCompleto"].ToString();
                    string rol = reader["Rol"].ToString();
                    return (nombre, rol);
                }
                else
                {
                    return (null, null);
                }
            }
        }

        public static void AgregarInformacionReunion(string texto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    string query = "INSERT INTO InformacionReuniones (TextoInformacion) VALUES (@Texto)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Texto", texto);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al guardar la información de reuniones: " + ex.Message);
            }
        }

        public static string ObtenerTodasLasInformacionesReuniones()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    string query = "SELECT TextoInformacion FROM InformacionReuniones ORDER BY Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int contador = 1;
                        while (reader.Read())
                        {
                            sb.AppendLine($"{contador}. {reader["TextoInformacion"]}");
                            contador++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al obtener la información de reuniones: " + ex.Message);
            }
            return sb.ToString();
        }

        public static void EliminarInformacionReunion(string texto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    string query = "DELETE FROM InformacionReuniones WHERE TextoInformacion = @Texto";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Texto", texto);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al eliminar la información de reuniones: " + ex.Message);
            }
        }

        public static int InsertarDocumento(string nombre, string tipo, byte[] datos)
        {
            int nuevoId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand("sp_InsertarDocumento", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Datos", datos);

                    SqlParameter outputId = new SqlParameter("@NuevoId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    nuevoId = Convert.ToInt32(outputId.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al subir el documento: " + ex.Message);
            }
            return nuevoId;
        }

        public static DataTable ObtenerDocumentos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand("SELECT IdDocumento, Nombre, Tipo, FechaSubida FROM SbrDocumento", conn))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar documentos: " + ex.Message);
            }
            return dt;
        }

        public static bool EliminarDocumento(int id)
        {
            bool exito = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM SbrDocumento WHERE IdDocumento = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    exito = filas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al eliminar el documento: " + ex.Message);
            }
            return exito;
        }

        public static bool DescargarDocumento(int idDocumento, string destino, string rutaArchivo)
        {
            bool exito = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT DatosArchivo FROM SbrDocumento WHERE IdDocumento=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idDocumento);
                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            byte[] archivoBytes = (byte[])resultado;
                            File.WriteAllBytes(destino, archivoBytes);
                            exito = true;
                        }
                        else
                        {
                            if (File.Exists(rutaArchivo))
                            {
                                File.Copy(rutaArchivo, destino, true);
                                exito = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al descargar el archivo: " + ex.Message);
            }
            return exito;
        }

        public static bool VisualizarDocumento(int idDocumento)
        {
            bool exito = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo, Datos FROM SbrDocumento WHERE IdDocumento=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idDocumento);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombre = reader["Nombre"].ToString();
                            string tipo = reader["Tipo"].ToString().ToLower();
                            byte[] datos = (byte[])reader["Datos"];

                            if (tipo != "pdf" && tipo != "doc" && tipo != "docx")
                                return false;

                            string tempPath = Path.Combine(Path.GetTempPath(), nombre);
                            File.WriteAllBytes(tempPath, datos);

                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                            {
                                FileName = tempPath,
                                UseShellExecute = true
                            });
                            exito = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al visualizar el documento: " + ex.Message);
            }
            return exito;
        }
    }
}
