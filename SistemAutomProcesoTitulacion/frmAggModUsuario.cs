using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemAutomProcesoTitulacion
{
    public partial class frmAggModUsuario : Form
    {
        public frmAggModUsuario()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuCoordinador menuCoord = this.Owner as frmMenuCoordinador;
            if (menuCoord != null)
            {
                frmGestionUsuario gestionUsuario = new frmGestionUsuario();
                gestionUsuario.Owner = menuCoord;
                funciones.AbrirFormularioEnPanel(gestionUsuario, menuCoord.panelContenedor);
            }
        }
    }
}
