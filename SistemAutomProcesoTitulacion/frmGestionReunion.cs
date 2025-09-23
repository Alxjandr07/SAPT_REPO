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
    public partial class frmGestionReunion : Form
    {
        public frmGestionReunion()
        {
            InitializeComponent();
            btnMarcar.Click += btnMarcar_Click;
            btnDesmarcar.Click += btnDesmarcar_Click;
            this.Load += frmGestionReunion_Load;
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            DateTime dia = monthCalendar1.SelectionStart;
            if (!monthCalendar1.BoldedDates.Contains(dia))
            {
                monthCalendar1.AddBoldedDate(dia);
                monthCalendar1.UpdateBoldedDates();
            }
            ActualizarLabelReuniones();
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            DateTime dia = monthCalendar1.SelectionStart;
            string texto = $"El día {dia.ToShortDateString()} se convoca a una reunión.";

            if (monthCalendar1.BoldedDates.Contains(dia))
            {
                monthCalendar1.RemoveBoldedDate(dia);
                monthCalendar1.UpdateBoldedDates();
                ConexionBD.EliminarInformacionReunion(texto); // Elimina de la BD
            }

            MensajeReuniones = ConexionBD.ObtenerTodasLasInformacionesReuniones(); // Actualiza el label
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblMensaje.Text = $"El día {e.Start.ToShortDateString()} está seleccionado.";
        }

        private void ActualizarLabelReuniones()
        {
            if (monthCalendar1.BoldedDates.Length == 0)
            {
                lblMensaje.Text = "No hay reuniones programadas.";
            }
            else if (monthCalendar1.BoldedDates.Length == 1)
            {
                lblMensaje.Text = $"El día {monthCalendar1.BoldedDates[0].ToShortDateString()} se convoca a una reunión.";
            }
            else
            {
                var fechas = monthCalendar1.BoldedDates
                    .OrderBy(f => f)
                    .Select((f, i) => $"{i + 1}. {f.ToShortDateString()}")
                    .ToList();

                lblMensaje.Text = "Reuniones programadas:\n" + string.Join("\n", fechas);
            }

            ConexionBD.AgregarInformacionReunion(lblMensaje.Text);
        }

        public void ConfigurarModo(bool esCoordinador)
        {
            btnMarcar.Visible = esCoordinador;
            btnDesmarcar.Visible = esCoordinador;
            monthCalendar1.Enabled = esCoordinador;
        }

        public string MensajeReuniones
        {
            get => lblMensaje.Text;
            set => lblMensaje.Text = value;
        }

        private void frmGestionReunion_Load(object sender, EventArgs e)
        {
            MensajeReuniones = ConexionBD.ObtenerTodasLasInformacionesReuniones();
        }
    }
}
