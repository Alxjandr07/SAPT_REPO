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
    public partial class frmGestionDoc : Form
    {
        private Tutor tutor;

        public frmGestionDoc(Tutor tutor)
        {
            InitializeComponent();
            this.tutor = tutor;
            this.Load += frmGestionDoc_Load;
        }

        private void tsbVolver_Click(object sender, EventArgs e)
        {
            // Implementa la lógica para volver si es necesario
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvGestion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implementa la lógica para el clic en la celda si es necesario
        }

        private void frmGestionDoc_Load(object sender, EventArgs e)
        {
            
        }

        private void tsbFiltro_Click(object sender, EventArgs e)
        {
           
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
           
        }

        private void tsbInactivo_Click(object sender, EventArgs e)
        {
           
        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
