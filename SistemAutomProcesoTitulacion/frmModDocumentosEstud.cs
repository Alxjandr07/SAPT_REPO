using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemAutomProcesoTitulacion
{
    public partial class frmModDocumentosEstud : Form
    {
        public frmModDocumentosEstud()
        {
            InitializeComponent();
        }


        private void frmModDocumentosEstud_Load(object sender, EventArgs e)
        {
            // Carga inicial de documentos desde la base de datos
            CargarDocumentos();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Documentos|*.pdf;*.docx;*.doc";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRutaArchivo.Text = ofd.FileName;
                MessageBox.Show("📁 Archivo seleccionado: " + ofd.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ruta = txtRutaArchivo.Text;
            if (string.IsNullOrEmpty(ruta) || !File.Exists(ruta))
            {
                MessageBox.Show("⚠️ Selecciona un archivo válido antes de guardar.");
                return;
            }

            string nombre = Path.GetFileName(ruta);
            string tipo = Path.GetExtension(ruta).Replace(".", "").ToUpper();
            byte[] datos = File.ReadAllBytes(ruta);
            // Conexión A BASE DE DATOS y comando para insertar el documento
            using (SqlConnection conn = new SqlConnection(@"Server=ALXJANDR07PC\SQLEXPRESS;Database=SistemaTitulacionUTEQ;Trusted_Connection=True;"))
            using (SqlCommand cmd = new SqlCommand("sp_InsertarDocumento", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                cmd.Parameters.AddWithValue("@Datos", datos);

                SqlParameter outputId = new SqlParameter("@NuevoId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("✅ Documento subido correctamente con ID: " + outputId.Value);
                    CargarDocumentos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al subir el documento: " + ex.Message);
                }
            }
            try
            {
                txtRutaArchivo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void dgvDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarDocumentos()
        {
            try
            {
                // Limpia la tabla antes de recargar Y tambien se conecta a la base de datos
                using (SqlConnection conn = new SqlConnection(@"Server=ALXJANDR07PC\SQLEXPRESS;Database=SistemaTitulacionUTEQ;Trusted_Connection=True;"))
                using (SqlCommand cmd = new SqlCommand("SELECT IdDocumento, Nombre, Tipo, FechaSubida FROM SbrDocumento", conn))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDocumentos.DataSource = dt;
                    dgvDocumentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    MessageBox.Show(" Documentos cargados correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar documentos: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (dgvDocumentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("⚠️ Selecciona un documento para eliminar.");
                return;
            }

            // Intenta obtener el ID del documento de forma segura
            object valorCelda = dgvDocumentos.SelectedRows[0].Cells[0].Value; // Usa índice 0 si no estás seguro del nombre

            if (valorCelda == null || !int.TryParse(valorCelda.ToString(), out int id))
            {
                MessageBox.Show("❌ No se pudo obtener el ID del documento seleccionado.");
                return;
            }

            // Confirmación antes de eliminar
            DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este documento?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacion != DialogResult.Yes)
                return;

            // Ejecuta el DELETE en la base de datos También se conecta a la base de datos
            using (SqlConnection conn = new SqlConnection(@"Server=ALXJANDR07PC\SQLEXPRESS;Database=SistemaTitulacionUTEQ;Trusted_Connection=True;"))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM SbrDocumento WHERE IdDocumento = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    conn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (filas > 0)
                    {
                        MessageBox.Show("🗑️ Documento eliminado correctamente.");
                        CargarDocumentos(); // Actualiza la tabla
                    }
                    else
                    {
                        MessageBox.Show("⚠️ No se encontró el documento en la base de datos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al eliminar el documento: " + ex.Message);
                }
            }
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRutaArchivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (dgvDocumentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("⚠️ Selecciona un documento para descargar.");
                return;
            }

            // Obtener IdDocumento de la fila seleccionada
            object valorCelda = dgvDocumentos.SelectedRows[0].Cells["IdDocumento"].Value;
            if (valorCelda == null || !int.TryParse(valorCelda.ToString(), out int idDocumento))
            {
                MessageBox.Show("❌ No se pudo obtener el ID del documento seleccionado.");
                return;
            }

            // Guardar archivo mediante SaveFileDialog
            SaveFileDialog sfd = new SaveFileDialog();
            string nombreArchivo = dgvDocumentos.SelectedRows[0].Cells["RutaArchivo"].Value.ToString();
            sfd.FileName = Path.GetFileName(nombreArchivo);
            sfd.Filter = "Todos los archivos|*.*";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Server=ALXJANDR07PC\SQLEXPRESS;Database=SistemaTitulacionUTEQ;Trusted_Connection=True;"))
                {
                    conn.Open();
                    // Intentamos obtener el archivo como BLOB de la base de datos
                    using (SqlCommand cmd = new SqlCommand("SELECT DatosArchivo FROM SbrDocumento WHERE IdDocumento=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idDocumento);
                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            // Si hay datos en la DB, los guardamos
                            byte[] archivoBytes = (byte[])resultado;
                            File.WriteAllBytes(sfd.FileName, archivoBytes);
                            MessageBox.Show("✅ Archivo descargado correctamente desde la base de datos.");
                        }
                        else
                        {
                            // Si no hay BLOB, usamos la ruta
                            string rutaArchivo = dgvDocumentos.SelectedRows[0].Cells["RutaArchivo"].Value.ToString();
                            if (File.Exists(rutaArchivo))
                            {
                                File.Copy(rutaArchivo, sfd.FileName, true);
                                MessageBox.Show("✅ Archivo descargado correctamente desde la ruta.");
                            }
                            else
                            {
                                MessageBox.Show("❌ Archivo no encontrado en disco ni en la base de datos.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al descargar el archivo: " + ex.Message);
            }

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvDocumentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("⚠️ Selecciona un documento para visualizar.");
                return;
            }

            // Accede al ID por índice (0 = primera columna)
            object valorCelda = dgvDocumentos.SelectedRows[0].Cells[0].Value;
            if (valorCelda == null || !int.TryParse(valorCelda.ToString(), out int idDocumento))
            {
                MessageBox.Show("❌ No se pudo obtener el ID del documento seleccionado.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Server=ALXJANDR07PC\SQLEXPRESS;Database=SistemaTitulacionUTEQ;Trusted_Connection=True;"))
                using (SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo, Datos FROM SbrDocumento WHERE IdDocumento=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idDocumento);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombre = reader["Nombre"].ToString();
                            string tipo = reader["Tipo"].ToString().ToLower();
                            byte[] datos = (byte[])reader["Datos"];

                            // Permite PDF y Word
                            if (tipo != "pdf" && tipo != "doc" && tipo != "docx")
                            {
                                MessageBox.Show("⚠️ Solo se pueden visualizar archivos PDF o Word.");
                                return;
                            }

                            string tempPath = Path.Combine(Path.GetTempPath(), nombre);
                            File.WriteAllBytes(tempPath, datos);

                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                            {
                                FileName = tempPath,
                                UseShellExecute = true
                            });
                        }
                        else
                        {
                            MessageBox.Show("❌ No se encontró el documento en la base de datos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al visualizar el documento: " + ex.Message);
            }
        }
    }
}
