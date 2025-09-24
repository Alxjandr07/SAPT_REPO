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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string para = cmbPara.Text.Trim();
            string asunto = txtAsunto.Text.Trim();
            string mensaje = txtMensaje.Text.Trim();

            // Validación: "Para" y "Mensaje" no pueden estar vacíos
            if (string.IsNullOrWhiteSpace(para))
            {
                MessageBox.Show("El campo 'Para' no puede estar vacío.");
                return;
            }
            if (string.IsNullOrWhiteSpace(mensaje))
            {
                MessageBox.Show("El campo 'Mensaje' no puede estar vacío.");
                return;
            }

            bool exito = coordinador.EnviarNotificacion(para, asunto, mensaje);

            if (exito)
            {
                MessageBox.Show("Notificación enviada correctamente.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al enviar la notificación.");
            }
        }

        // Método para limpiar los campos
        private void LimpiarCampos()
        {
            cmbPara.SelectedIndex = -1; // O cmbPara.Text = "";
            txtAsunto.Text = "";
            txtMensaje.Text = "";
        }
    }
}
