using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemAutomProcesoTitulacion
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Cedula { get; set; }
        public string CorreoInstitucional { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }
        public int Estado { get; set; } // 1=activo, 0=inactivo
    }
}
