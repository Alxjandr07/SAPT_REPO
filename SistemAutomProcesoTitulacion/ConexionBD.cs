using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

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
    }
}
