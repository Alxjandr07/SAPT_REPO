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
        private int originalEstado = 1; // Estado original (1=activo, 0=inactivo)

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

        // Nuevo constructor con estado
        public frmAggModUsuario(int idUsuario, string nombre, string cedula, string correo, string rol, int estado, string modo)
            : this()
        {
            this.idUsuario = idUsuario;
            txtNombre.Text = nombre;
            txtCedula.Text = cedula;
            txtCorreo.Text = correo;
            cmbRol.Text = rol;
            chkEstado.Checked = estado == 1;
            this.modo = modo;

            // Guarda los valores originales para comparar
            originalNombre = nombre.Trim();
            originalCedula = cedula.Trim();
            originalCorreo = correo.Trim();
            originalRol = rol.Trim();
            originalContrasena = ""; // Nunca mostramos la contraseña original
            originalEstado = estado;
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
            int estado = chkEstado.Checked ? 1 : 0;

            if (modo == "Nuevo")
            {
                // Validación de campos obligatorios
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre es obligatorio.");
                    txtNombre.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(cedula))
                {
                    MessageBox.Show("La cédula es obligatoria.");
                    txtCedula.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(correo))
                {
                    MessageBox.Show("El correo es obligatorio.");
                    txtCorreo.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(rol))
                {
                    MessageBox.Show("El rol es obligatorio.");
                    cmbRol.Focus();
                    return;
                }
                if (!chkEstado.Checked)
                {
                    MessageBox.Show("El usuario nuevo debe estar registrado como activo.");
                    chkEstado.Focus();
                    return;
                }
                if (contrasena.Length < 3)
                {
                    MessageBox.Show("La contraseña debe tener al menos 3 caracteres.");
                    txtContrasena.Focus();
                    return;
                }

                if (ConexionBD.RegistrarUsuario(nombre, cedula, correo, contrasena, rol, estado))
                    MessageBox.Show("✅ Usuario registrado correctamente.");
                else
                    MessageBox.Show("⚠️ No se pudo registrar el usuario.");
            }
            else if (modo == "Modificar")
            {
                // Validación de campos obligatorios (excepto contraseña)
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre es obligatorio.");
                    txtNombre.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(cedula))
                {
                    MessageBox.Show("La cédula es obligatoria.");
                    txtCedula.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(correo))
                {
                    MessageBox.Show("El correo es obligatorio.");
                    txtCorreo.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(rol))
                {
                    MessageBox.Show("El rol es obligatorio.");
                    cmbRol.Focus();
                    return;
                }

                // Validación de contraseña solo si se va a cambiar
                if (contrasena.Length > 0 && contrasena.Length < 3)
                {
                    MessageBox.Show("La contraseña debe tener al menos 3 caracteres.");
                    txtContrasena.Focus();
                    return;
                }

                // Detecta cambios (si la contraseña está vacía, no se actualiza)
                bool hayCambios =
                    nombre != originalNombre ||
                    cedula != originalCedula ||
                    correo != originalCorreo ||
                    rol != originalRol ||
                    estado != originalEstado ||
                    (contrasena.Length >= 3 && contrasena != originalContrasena);

                if (!hayCambios)
                {
                    MessageBox.Show("No hay cambios para actualizar.");
                    return;
                }

                // Si la contraseña está vacía, no la actualices
                string contrasenaParaActualizar = contrasena.Length >= 3 ? contrasena : originalContrasena;

                if (ConexionBD.ActualizarUsuario(idUsuario, nombre, cedula, correo, contrasenaParaActualizar, rol, estado))
                {
                    MessageBox.Show("✅ Usuario modificado correctamente.");

                    // Actualiza los valores originales para futuras comparaciones
                    originalNombre = nombre;
                    originalCedula = cedula;
                    originalCorreo = correo;
                    originalRol = rol;
                    if (contrasena.Length >= 3)
                        originalContrasena = contrasena;
                    originalEstado = estado;
                }
                else
                {
                    MessageBox.Show("⚠️ No se pudo modificar el usuario.");
                }
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
