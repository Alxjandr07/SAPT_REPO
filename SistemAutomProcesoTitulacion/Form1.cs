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

            // Validar credenciales y obtener nombre + rol
            var resultado = ConexionBD.ValidarLoginDatos(correo, contrasena);
            string nombre = resultado.Nombre;
            string rol = resultado.Rol;

            if (rol == null)
            {
                MessageBox.Show("⚠️ Correo o contraseña incorrectos.");
                return;
            }

            // Abrir el formulario correspondiente
            Form destino = null;

            switch (rol)
            {
                case "Estudiante":
                    destino = new FrmMenuEstudiantes(nombre, rol);
                    break;
                case "Tutor":
                    destino = new frmTutor(nombre, rol);
                    var tutor = new Tutor
                    {
                        Nombre = nombre,
                        Correo = correo
                    };

                    destino = new frmTutor(tutor, nombre, rol);
                    break;
                case "Director":
                    destino = new frmDirector(nombre, rol);
                    break;
                case "Tribunal":
                    destino = new frmTribunal(nombre, rol);
                    break;
                case "Coordinador":
                    var coordinador = new Coordinador
                    {
                        Nombre = nombre,
                        Correo = correo
                        // Si tienes IdCoordinador, asígnalo también
                    };
                    destino = new frmMenuCoordinador(coordinador, nombre, rol);
                    break;
                default:
                    MessageBox.Show("⚠️ Rol no reconocido. Contacte al administrador.");
                    return;
            }

            destino.Show();
            this.Hide();


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

        private void pboxImagenLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
