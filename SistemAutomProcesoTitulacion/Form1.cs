using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wasg, int wparam, int lparam);


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                return;
            }

            // 🔎 Ahora según el rol abrimos cada menú/formulario
            switch (rol)
            {
                case "Estudiante":
                    MessageBox.Show("✅ Bienvenido Estudiante.");
                    FrmMenuEstudiantes fEstudiante = new FrmMenuEstudiantes();
                    fEstudiante.Show();
                    this.Hide();
                    break;

                case "Tutor":
                    MessageBox.Show("✅ Bienvenido Tutor.");
                    frmTutor fTutor = new frmTutor();
                    fTutor.Show();
                    this.Hide();
                    break;

                case "Director":
                    MessageBox.Show("✅ Bienvenido Director de Tesis.");
                    frmDirector fDirector = new frmDirector();
                    fDirector.Show();
                    this.Hide();
                    break;

                case "Tribunal":
                    MessageBox.Show("✅ Bienvenido Tribunal.");
                    frmTribunal fTribunal = new frmTribunal();
                    fTribunal.Show();
                    this.Hide();
                    break;

                case "Coordinador":
                    MessageBox.Show("✅ Bienvenido Coordinador de Carrera.");
                    frmMenuCoordinador fCoordinador = new frmMenuCoordinador();
                    fCoordinador.Show();
                    this.Hide();
                    break;

                case "Comité":
                    MessageBox.Show("✅ Bienvenido Comité de Investigación.");
                    break;

                case "Secretaria":
                    MessageBox.Show("✅ Bienvenida Secretaria Académica.");
                    break;

                default:
                    MessageBox.Show("⚠️ Rol no reconocido. Contacte al administrador.");
                    break;
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

        private void panelEncabezLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelEncabezLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
