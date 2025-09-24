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
    public partial class frmMenuCoordinador : Form
    {

        private Coordinador coordinador;

        // Constructor que recibe Coordinador, nombre y rol
        public frmMenuCoordinador(Coordinador coordinador, string nombre, string rol)
        {
            InitializeComponent();
            this.coordinador = coordinador;
            lblNombre.Text = nombre;
            lblRol.Text = rol;
        }

        private void panelContenedorEstud_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDesliz_Click(object sender, EventArgs e)
        {
            if (flpMenu.Width == 245)
            {
                flpMenu.Width = 20;
            }
            else
            {
                flpMenu.Width = 245;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show(
                    "¿Deseas cerrar sesión?",
                    "Cerrar Sesión",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    this.Hide(); // Ocultamos el formulario principal

                    // Volvemos a mostrar el Form1 (que es tu Login)
                    frmLogin login = new frmLogin();
                    login.Show();
                }
            }
        }

        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill; // Esta línea es clave
            formHijo.Size = panelContenedor.ClientSize; // Opcional, asegura el tamaño inicial

            this.panelContenedor.Controls.Add(formHijo);
            this.panelContenedor.Tag = formHijo;
            formHijo.Show();
        }

        private void btnEnvioDoc_Click(object sender, EventArgs e)
        {
            frmGestionUsuario gestionUsuario = new frmGestionUsuario(coordinador);
            gestionUsuario.Owner = this; // 'this' es frmMenuCoordinador
            funciones.AbrirFormularioEnPanel(gestionUsuario, panelContenedor);
        }

        private void btnReunion_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmGestionReunion());
        }

        private void panelCabecera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show(
                    "¿Deseas cerrar sesión?",
                    "Cerrar Sesión",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    this.Hide(); // Ocultamos el formulario principal

                    // Volvemos a mostrar el Form1 (que es tu Login)
                    frmLogin login = new frmLogin();
                    login.Show();
                }
            }
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAutoridades_Click(object sender, EventArgs e)
        {
            frmNotificacion notificacion = new frmNotificacion(coordinador);
            notificacion.Owner = this; // 'this' es frmMenuCoordinador
            funciones.AbrirFormularioEnPanel(notificacion, panelContenedor);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
