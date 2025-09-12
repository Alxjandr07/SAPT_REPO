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
        private static string cadena = "Server=DESKTOP-V9JOQAR; Database=SistemaTitulacionUTEQ; Integrated Security=true";
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
                using (SqlConnection con = new SqlConnection(cadena)) // 🔑 se cierra solo al terminar
                {
                    con.Open();

                    // 🔎 Consulta con JOIN para obtener el nombre del rol desde la tabla Roles
                    string query = @"SELECT r.NombreRol 
                             FROM Usuarios u
                             INNER JOIN Roles r ON u.IdRol = r.IdRol
                             WHERE u.CorreoInstitucional = @correo 
                               AND u.Contrasena = @contrasena
                               AND u.Estado = 1";  // opcional si manejas estado activo/inactivo

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            rol = reader["NombreRol"].ToString();
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

        public static DataTable ObtenerUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("ListarUsuarios", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al obtener usuarios: " + ex.Message);
            }
            return dt;
        }
    }
}
