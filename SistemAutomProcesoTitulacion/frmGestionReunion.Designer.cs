namespace SistemAutomProcesoTitulacion
{
    partial class frmGestionReunion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnEliminarReuniones = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 

            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Green;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripSeparator7,
            this.toolStripLabel1,
            this.tstFiltro,
            this.tsbFiltro,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.tsbNuevo,
            this.toolStripSeparator3,
            this.tsbModificar,
            this.toolStripSeparator4,
            this.tsbEliminar,
            this.toolStripSeparator5,
            this.tsbVolver,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 26);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(121, 23);
            this.toolStripLabel3.Text = "Gestion de Reuniones";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 23);
            this.toolStripLabel1.Text = "Filtrar:";
            // 
            // tstFiltro
            // 
            this.tstFiltro.Name = "tstFiltro";
            this.tstFiltro.Size = new System.Drawing.Size(168, 26);
            // 
            // tsbFiltro
            // 
            this.tsbFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFiltro.Image = ((System.Drawing.Image)(resources.GetObject("tsbFiltro.Image")));
            this.tsbFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFiltro.Name = "tsbFiltro";
            this.tsbFiltro.Size = new System.Drawing.Size(23, 23);
            this.tsbFiltro.Text = "Filtrar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(61, 23);
            this.toolStripLabel2.Text = "Acciones: ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(65, 23);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbModificar
            // 
            this.tsbModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(81, 23);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(73, 23);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbVolver
            // 
            this.tsbVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsbVolver.Image = ((System.Drawing.Image)(resources.GetObject("tsbVolver.Image")));
            this.tsbVolver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVolver.Name = "tsbVolver";
            this.tsbVolver.Size = new System.Drawing.Size(62, 23);
            this.tsbVolver.Text = "Volver";
            this.tsbVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 26);
            // 

            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(-12, -8);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 150);
            this.panel1.TabIndex = 5;
            // 
            // btnMarcar
            // 
            this.btnMarcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarcar.Location = new System.Drawing.Point(12, 217);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(117, 23);
            this.btnMarcar.TabIndex = 6;
            this.btnMarcar.Text = "AsignarReunion";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDesmarcar.Location = new System.Drawing.Point(145, 217);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(133, 23);
            this.btnDesmarcar.TabIndex = 7;
            this.btnDesmarcar.Text = "Desmarcar";
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMensaje.Location = new System.Drawing.Point(455, 39);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(108, 13);
            this.lblMensaje.TabIndex = 8;
            this.lblMensaje.Text = "SinReunionesActivas";
            // 
            // btnEliminarReuniones
            // 
            this.btnEliminarReuniones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarReuniones.Location = new System.Drawing.Point(298, 217);
            this.btnEliminarReuniones.Name = "btnEliminarReuniones";
            this.btnEliminarReuniones.Size = new System.Drawing.Size(117, 23);
            this.btnEliminarReuniones.TabIndex = 9;
            this.btnEliminarReuniones.Text = "Eliminar Reuniones Programadas";
            this.btnEliminarReuniones.UseVisualStyleBackColor = true;
            this.btnEliminarReuniones.Click += new System.EventHandler(this.btnEliminarReuniones_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 34);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reuniones";
            // 
            // frmGestionReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEliminarReuniones);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionReunion";
            this.Text = "frmGestionReunion";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnEliminarReuniones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}