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
        private static string cadena = "Server=ALXJANDR07PC\\SQLEXPRESS; Database=BD_SistemaTitulacion; Integrated Security=true";
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

                    string query = "SELECT rol FROM Usuarios WHERE correo=@correo AND contrasena=@contrasena";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            rol = reader["rol"].ToString();
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

    }
}
