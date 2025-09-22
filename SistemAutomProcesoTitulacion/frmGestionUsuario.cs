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
            dgvGestion.DataSource = ConexionBD.ObtenerUsuarios("Activos");
        }

        private void tsbFiltro_Click(object sender, EventArgs e)
        {
            string filtro = tstFiltro.Text.Trim();
            dgvGestion.DataSource = ConexionBD.FiltrarUsuarios(filtro);
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            if (dgvGestion.CurrentRow != null)
            {
                int idUsuario = Convert.ToInt32(dgvGestion.CurrentRow.Cells["IdUsuario"].Value);
                string nombre = dgvGestion.CurrentRow.Cells["NombreCompleto"].Value.ToString();
                string cedula = dgvGestion.CurrentRow.Cells["Cedula"].Value.ToString();
                string correo = dgvGestion.CurrentRow.Cells["CorreoInstitucional"].Value.ToString();
                string rol = dgvGestion.CurrentRow.Cells["Rol"].Value.ToString();
                int estado = Convert.ToInt32(dgvGestion.CurrentRow.Cells["Estado"].Value);

                frmMenuCoordinador menuCoord = this.Owner as frmMenuCoordinador;
                if (menuCoord != null)
                {
                    frmAggModUsuario aggModUsuario = new frmAggModUsuario(idUsuario, nombre, cedula, correo, rol, estado, "Modificar");
                    aggModUsuario.Owner = menuCoord;
                    funciones.AbrirFormularioEnPanel(aggModUsuario, menuCoord.panelContenedor);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para modificar.");
            }
        }

        private void tsbInactivo_Click(object sender, EventArgs e)
        {
            dgvGestion.DataSource = ConexionBD.ObtenerUsuarios("Inactivos");
        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            dgvGestion.DataSource = ConexionBD.ObtenerUsuarios("Activos");
        }
    }
}
