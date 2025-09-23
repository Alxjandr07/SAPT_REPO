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
    public partial class frmDirector : Form
    {
        public frmDirector(string nombre, string rol)
        {
            InitializeComponent();
            lblNombre.Text = nombre;
            lblRol.Text = rol;
        }
        public frmDirector()
        {
            InitializeComponent();
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

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMaximizar_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
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

        private void frmDirector_Load(object sender, EventArgs e)
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
    }
}
