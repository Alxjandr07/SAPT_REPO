using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemAutomProcesoTitulacion
{
    public class Coordinador
    {
        public int IdCoordinador { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public bool AgregarUsuario(Usuario usuario)
        {
            // Utiliza el método de ConexionBD para registrar usuario
            return ConexionBD.RegistrarUsuario(
                usuario.NombreCompleto,
                usuario.Cedula,
                usuario.CorreoInstitucional,
                usuario.Contrasena,
                usuario.Rol,
                usuario.Estado
            );
        }

        public bool ModificarUsuario(Usuario usuario)
        {
            // Si la contraseña está vacía o tiene menos de 3 caracteres, NO se modifica
            if (string.IsNullOrEmpty(usuario.Contrasena) || usuario.Contrasena.Length < 3)
            {
                // Llama al método que no modifica la contraseña
                return ConexionBD.ActualizarUsuario(
                    usuario.IdUsuario,
                    usuario.NombreCompleto,
                    usuario.Cedula,
                    usuario.CorreoInstitucional,
                    null, // Se pasa null para que el SP ignore la contraseña
                    usuario.Rol,
                    usuario.Estado
                );
            }
            else
            {
                // Llama al método que sí modifica la contraseña
                return ConexionBD.ActualizarUsuario(
                    usuario.IdUsuario,
                    usuario.NombreCompleto,
                    usuario.Cedula,
                    usuario.CorreoInstitucional,
                    usuario.Contrasena,
                    usuario.Rol,
                    usuario.Estado
                );
            }
        }

        public DataTable ObtenerUsuarios(string estado)
        {
            // Utiliza el método de ConexionBD para obtener usuarios
            return ConexionBD.ObtenerUsuarios(estado);
        }

        public DataTable FiltrarUsuarios(string filtro)
        {
            // Utiliza el método de ConexionBD para filtrar usuarios
            return ConexionBD.FiltrarUsuarios(filtro);
        }

        public bool EnviarNotificacion(string para, string asunto, string mensaje)
        {
            return ConexionBD.AgregarNotificacion(this.IdCoordinador, para, asunto, mensaje);
        }
    }
}
