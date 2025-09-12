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
    public partial class frmAggModUsuario : Form
    {
        private int idUsuario;
        private string modo = "Nuevo"; // Por defecto
        private string originalNombre;
        private string originalCedula;
        private string originalCorreo;
        private string originalRol;
        private string originalContrasena = ""; // Contraseña original (vacía por seguridad)

        public frmAggModUsuario()
        {
            InitializeComponent();
        }

        public frmAggModUsuario(int idUsuario, string nombre, string cedula, string correo, string rol, string modo)
            : this()
        {
            this.idUsuario = idUsuario;
            txtNombre.Text = nombre;
            txtCedula.Text = cedula;
            txtCorreo.Text = correo;
            cmbRol.Text = rol;
            this.modo = modo;

            // Guarda los valores originales para comparar
            originalNombre = nombre.Trim();
            originalCedula = cedula.Trim();
            originalCorreo = correo.Trim();
            originalRol = rol.Trim();
            originalContrasena = ""; // Nunca mostramos la contraseña original
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuCoordinador menuCoord = this.Owner as frmMenuCoordinador;
            if (menuCoord != null)
            {
                frmGestionUsuario gestionUsuario = new frmGestionUsuario();
                gestionUsuario.Owner = menuCoord;
                funciones.AbrirFormularioEnPanel(gestionUsuario, menuCoord.panelContenedor);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string cedula = txtCedula.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            string rol = cmbRol.Text.Trim();

            if (modo == "Modificar")
            {
                // Validación de contraseña mínima solo si se va a cambiar
                if (contrasena.Length > 0 && contrasena.Length < 3)
                {
                    MessageBox.Show("La contraseña debe tener al menos 3 caracteres.");
                    return;
                }

                // Validación de cambios (incluye contraseña)
                bool hayCambios =
                    nombre != originalNombre ||
                    cedula != originalCedula ||
                    correo != originalCorreo ||
                    rol != originalRol ||
                    contrasena != originalContrasena; // Solo cuenta si se va a cambiar

                if (!hayCambios)
                {
                    MessageBox.Show("No hay cambios para actualizar.");
                    return;
                }

                if (ConexionBD.ActualizarUsuario(idUsuario, nombre, cedula, correo, contrasena, rol))
                {
                    MessageBox.Show("✅ Usuario modificado correctamente.");

                    // Actualiza los valores originales para futuras comparaciones
                    originalNombre = nombre;
                    originalCedula = cedula;
                    originalCorreo = correo;
                    originalRol = rol;
                    originalContrasena = contrasena;
                    //txtContrasena.Text = ""; // Limpia el campo contraseña tras actualizar
                }
                else
                {
                    MessageBox.Show("⚠️ No se pudo modificar el usuario.");
                }
            }
            else if (modo == "Nuevo")
            {
                if (contrasena.Length < 3)
                {
                    MessageBox.Show("La contraseña debe tener al menos 3 caracteres.");
                    return;
                }

                if (ConexionBD.RegistrarUsuario(nombre, cedula, correo, contrasena, rol))
                    MessageBox.Show("✅ Usuario registrado correctamente.");
                else
                    MessageBox.Show("⚠️ No se pudo registrar el usuario.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMenuCoordinador menuCoord = this.Owner as frmMenuCoordinador;
            if (menuCoord != null)
            {
                frmGestionUsuario gestionUsuario = new frmGestionUsuario();
                gestionUsuario.Owner = menuCoord;
                funciones.AbrirFormularioEnPanel(gestionUsuario, menuCoord.panelContenedor);
            }
        }
    }
}
