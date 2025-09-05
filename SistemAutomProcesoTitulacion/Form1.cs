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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiarCampos()
        {
            txtUsuario.Text = "";
            txtContrasenia.Text = "";
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string correo = txtUsuario.Text.Trim();
            string contrasena = txtContrasenia.Text.Trim();

            string rol = ConexionBD.ValidarLogin(correo, contrasena);

            if (rol == null)
            {
                MessageBox.Show("⚠️ Correo o contraseña incorrectos.");
            }
            else if (rol == "Docente")
            {
                MessageBox.Show("✅ Bienvenido Docente.");
            }
            else if (rol == "Estudiante")
            {
                MessageBox.Show("✅ Bienvenido Estudiante.");
                FrmMenuEstudiantes fEstudiante = new FrmMenuEstudiantes();
                fEstudiante.Show();
                this.Hide();
            }


        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnMostrarContra_Click(object sender, EventArgs e)
        {
            txtContrasenia.UseSystemPasswordChar = !txtContrasenia.UseSystemPasswordChar;
        }
    }
}
