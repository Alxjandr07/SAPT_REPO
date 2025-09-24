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
    public partial class frmNotificacion : Form
    {
        private ToolTip toolTip1 = new ToolTip();
        private Coordinador coordinador;

        public frmNotificacion(Coordinador coordinador)
        {
            InitializeComponent();
            this.coordinador = coordinador;
            this.Load += frmNotificacion_Load;
            toolTip1.SetToolTip(btnAdjuntar, "Adjuntar");
        }

        private void frmNotificacion_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {

        }
    }
}
