using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemAutomProcesoTitulacion
{
    internal static class funciones
    {
        public static void AbrirFormularioEnPanel(Form formHijo, Panel panelContenedor)
        {
            panelContenedor.Controls.Clear(); // Elimina todos los controles

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            formHijo.Size = panelContenedor.ClientSize;

            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.Show();
        }
    }
}
