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
        // Solo las variables necesarias
        private Coordinador coordinador;
        private Usuario usuario;
        private string modo = "Nuevo"; // "Nuevo" o "Modificar"

        // Constructor para agregar usuario
        public frmAggModUsuario(Coordinador coord)
        {
            InitializeComponent();
            this.coordinador = coord;
            this.modo = "Nuevo";
        }

        // Constructor para modificar usuario
        public frmAggModUsuario(Coordinador coord, Usuario usuario, string modo)
        {
            InitializeComponent();
            this.coordinador = coord;
            this.usuario = usuario;
            this.modo = modo;

            if (usuario != null)
            {
                txtNombre.Text = usuario.NombreCompleto;
                txtCedula.Text = usuario.Cedula;
                txtCorreo.Text = usuario.CorreoInstitucional;
                cmbRol.Text = usuario.Rol;
                chkEstado.Checked = usuario.Estado == 1;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuCoordinador menuCoord = this.Owner as frmMenuCoordinador;
            if (menuCoord != null)
            {
                frmGestionUsuario gestionUsuario = new frmGestionUsuario(coordinador);
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

                Usuario nuevoUsuario = new Usuario
                {
                    NombreCompleto = nombre,
                    Cedula = cedula,
                    CorreoInstitucional = correo,
                    Contrasena = contrasena,
                    Rol = rol,
                    Estado = estado
                };

                if (coordinador.AgregarUsuario(nuevoUsuario))
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

                // Si la contraseña está vacía o menor a 3, pasa una cadena especial para que el SP la ignore
                string contrasenaParaActualizar = contrasena.Length >= 3 ? contrasena : "NO_CAMBIAR";

                Usuario usuarioModificado = new Usuario
                {
                    IdUsuario = usuario.IdUsuario,
                    NombreCompleto = nombre,
                    Cedula = cedula,
                    CorreoInstitucional = correo,
                    Contrasena = contrasenaParaActualizar,
                    Rol = rol,
                    Estado = estado
                };

                // Detecta cambios
                bool hayCambios =
                    usuarioModificado.NombreCompleto != usuario.NombreCompleto ||
                    usuarioModificado.Cedula != usuario.Cedula ||
                    usuarioModificado.CorreoInstitucional != usuario.CorreoInstitucional ||
                    usuarioModificado.Rol != usuario.Rol ||
                    usuarioModificado.Estado != usuario.Estado ||
                    (contrasena.Length >= 3 && contrasena != usuario.Contrasena);

                if (!hayCambios)
                {
                    MessageBox.Show("No hay cambios para actualizar.");
                    return;
                }

                if (coordinador.ModificarUsuario(usuarioModificado))
                {
                    MessageBox.Show("✅ Usuario modificado correctamente.");
                    usuario = usuarioModificado;
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
                frmGestionUsuario gestionUsuario = new frmGestionUsuario(coordinador);
                gestionUsuario.Owner = menuCoord;
                funciones.AbrirFormularioEnPanel(gestionUsuario, menuCoord.panelContenedor);
            }
        }

        private void panelCab_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
