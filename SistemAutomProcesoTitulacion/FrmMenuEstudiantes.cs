using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace SistemAutomProcesoTitulacion
{
    public partial class FrmMenuEstudiantes : Form
    {
        private Estudiante estudiante;

        public FrmMenuEstudiantes(Estudiante estudiante, string nombre, string rol)
        {
            InitializeComponent();
            this.estudiante = estudiante;
            lblNombre.Text = nombre;
            lblRol.Text = rol;
        }

        public FrmMenuEstudiantes(string nombre, string rol)
        {
            InitializeComponent();
            lblNombre.Text = nombre;
            lblRol.Text = rol;
        }

        public FrmMenuEstudiantes()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wasg, int wparam, int lparam);
        
        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill; // Esto es lo importante
            this.panelContenedor.Controls.Add(formHijo);
            this.panelContenedor.Tag = formHijo;
            formHijo.Show();
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
             
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            
        }

        private void panelCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();

            this.Close();
        }

        private void btnAnteproyecto_Click(object sender, EventArgs e)
        {
            
        }

        private void panelContenedorEstud_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panelContenedorEstud_Paint_1(object sender, PaintEventArgs e)
        {

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


        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinim_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;

        }

        private void btnEnvioDoc_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmEntregarDocumentos());
            /*
            frmEntregarDocumentos entregaDoc = new frmEntregarDocumentos(estudiante);
            entregaDoc.Owner = this; // 'this' es frmMenuCoordinador
            funciones.AbrirFormularioEnPanel(entregaDoc, panelContenedorEstud);
            */
            

        }

        private void panelCabecera_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        



        

        private void btnReunion_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelInformacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLogOut_Click_1(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void lblNombre_Click(object sender, EventArgs e)
        {


        }

        

        
    }
}
