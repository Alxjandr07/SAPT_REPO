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
    public partial class frmGestionUsuario : Form
    {
        public frmGestionUsuario()
        {
            InitializeComponent();
            this.Load += frmGestionUsuario_Load;
        }

        private void tsbVolver_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            // Obtén la instancia del formulario padre (frmMenuCoordinador)
            frmMenuCoordinador menuCoord = this.Owner as frmMenuCoordinador;
            if (menuCoord != null)
            {
                // Reemplaza el formulario actual por frmAggModUsuario en el panel contenedor
                frmAggModUsuario aggModUsuario = new frmAggModUsuario();
                aggModUsuario.Owner = menuCoord;
                funciones.AbrirFormularioEnPanel(aggModUsuario, menuCoord.panelContenedor);
            }
        }

        private void dgvGestion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGestionUsuario_Load(object sender, EventArgs e)
        {
            dgvGestion.DataSource = ConexionBD.ObtenerUsuarios();
        }
    }
}
