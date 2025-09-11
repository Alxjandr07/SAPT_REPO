namespace SistemAutomProcesoTitulacion
{
    partial class FrmMenuEstudiantes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuEstudiantes));
            this.tmrTransicionMenu = new System.Windows.Forms.Timer(this.components);
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinim = new System.Windows.Forms.PictureBox();
            this.btnDesliz = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlEnvioDoc = new System.Windows.Forms.Panel();
            this.btnEnvioDoc = new System.Windows.Forms.Button();
            this.pnlEstadoProceso = new System.Windows.Forms.Panel();
            this.btnEstadoProceso = new System.Windows.Forms.Button();
            this.pnlReunion = new System.Windows.Forms.Panel();
            this.btnReunion = new System.Windows.Forms.Button();
            this.pnlAutoridades = new System.Windows.Forms.Panel();
            this.btnAutoridades = new System.Windows.Forms.Button();
            this.panelContenedorEstud = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesliz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            this.flpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlEnvioDoc.SuspendLayout();
            this.pnlEstadoProceso.SuspendLayout();
            this.pnlReunion.SuspendLayout();
            this.pnlAutoridades.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelCabecera.Controls.Add(this.btnRestaurar);
            this.panelCabecera.Controls.Add(this.btnMinim);
            this.panelCabecera.Controls.Add(this.btnDesliz);
            this.panelCabecera.Controls.Add(this.btnCerrar);
            this.panelCabecera.Controls.Add(this.label1);
            this.panelCabecera.Controls.Add(this.btnMaximizar);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1300, 62);
            this.panelCabecera.TabIndex = 11;
            this.panelCabecera.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCabecera_Paint);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1235, 1);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(29, 30);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click_1);
            // 
            // btnMinim
            // 
            this.btnMinim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinim.Image = ((System.Drawing.Image)(resources.GetObject("btnMinim.Image")));
            this.btnMinim.Location = new System.Drawing.Point(1199, 1);
            this.btnMinim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinim.Name = "btnMinim";
            this.btnMinim.Size = new System.Drawing.Size(29, 30);
            this.btnMinim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinim.TabIndex = 4;
            this.btnMinim.TabStop = false;
            this.btnMinim.Click += new System.EventHandler(this.btnMinim_Click_1);
            // 
            // btnDesliz
            // 
            this.btnDesliz.Image = ((System.Drawing.Image)(resources.GetObject("btnDesliz.Image")));

            this.btnDesliz.Location = new System.Drawing.Point(2, 2);
            this.btnDesliz.Margin = new System.Windows.Forms.Padding(2);

            this.btnDesliz.Name = "btnDesliz";
            this.btnDesliz.Size = new System.Drawing.Size(35, 34);
            this.btnDesliz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDesliz.TabIndex = 0;
            this.btnDesliz.TabStop = false;
            this.btnDesliz.Click += new System.EventHandler(this.btnDesliz_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::SistemAutomProcesoTitulacion.Properties.Resources.letra_x;
            this.btnCerrar.Location = new System.Drawing.Point(1268, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1232, 2);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(29, 30);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click_1);
            // 
            // flpMenu
            // 
            this.flpMenu.BackColor = System.Drawing.Color.Green;
            this.flpMenu.Controls.Add(this.pictureBox2);
            this.flpMenu.Controls.Add(this.pnlEnvioDoc);
            this.flpMenu.Controls.Add(this.pnlEstadoProceso);
            this.flpMenu.Controls.Add(this.pnlReunion);
            this.flpMenu.Controls.Add(this.pnlAutoridades);
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMenu.Location = new System.Drawing.Point(0, 62);
            this.flpMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(247, 588);
            this.flpMenu.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 62);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pnlEnvioDoc
            // 
            this.pnlEnvioDoc.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEnvioDoc.Controls.Add(this.btnEnvioDoc);
            this.pnlEnvioDoc.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEnvioDoc.Location = new System.Drawing.Point(0, 66);
            this.pnlEnvioDoc.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEnvioDoc.Name = "pnlEnvioDoc";
            this.pnlEnvioDoc.Size = new System.Drawing.Size(247, 55);
            this.pnlEnvioDoc.TabIndex = 7;
            // 
            // btnEnvioDoc
            // 
            this.btnEnvioDoc.BackColor = System.Drawing.Color.Green;
            this.btnEnvioDoc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvioDoc.ForeColor = System.Drawing.Color.White;
            this.btnEnvioDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnvioDoc.Location = new System.Drawing.Point(-5, -5);
            this.btnEnvioDoc.Margin = new System.Windows.Forms.Padding(0);
            this.btnEnvioDoc.Name = "btnEnvioDoc";
            this.btnEnvioDoc.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnEnvioDoc.Size = new System.Drawing.Size(257, 65);
            this.btnEnvioDoc.TabIndex = 1;
            this.btnEnvioDoc.Text = "Envio de Documentos";
            this.btnEnvioDoc.UseVisualStyleBackColor = false;
            this.btnEnvioDoc.Click += new System.EventHandler(this.btnEnvioDoc_Click);
            // 
            // pnlEstadoProceso
            // 
            this.pnlEstadoProceso.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEstadoProceso.Controls.Add(this.btnEstadoProceso);
            this.pnlEstadoProceso.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEstadoProceso.Location = new System.Drawing.Point(0, 121);
            this.pnlEstadoProceso.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEstadoProceso.Name = "pnlEstadoProceso";
            this.pnlEstadoProceso.Size = new System.Drawing.Size(247, 55);
            this.pnlEstadoProceso.TabIndex = 8;
            // 
            // btnEstadoProceso
            // 
            this.btnEstadoProceso.BackColor = System.Drawing.Color.Green;
            this.btnEstadoProceso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoProceso.ForeColor = System.Drawing.Color.White;
            this.btnEstadoProceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadoProceso.Location = new System.Drawing.Point(-5, -5);
            this.btnEstadoProceso.Margin = new System.Windows.Forms.Padding(0);
            this.btnEstadoProceso.Name = "btnEstadoProceso";
            this.btnEstadoProceso.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnEstadoProceso.Size = new System.Drawing.Size(257, 65);
            this.btnEstadoProceso.TabIndex = 1;
            this.btnEstadoProceso.Text = "Estado del Proceso";
            this.btnEstadoProceso.UseVisualStyleBackColor = false;
            // 
            // pnlReunion
            // 
            this.pnlReunion.BackColor = System.Drawing.SystemColors.Control;
            this.pnlReunion.Controls.Add(this.btnReunion);
            this.pnlReunion.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.pnlReunion.Location = new System.Drawing.Point(0, 144);
            this.pnlReunion.Margin = new System.Windows.Forms.Padding(0);
            this.pnlReunion.Name = "pnlReunion";
            this.pnlReunion.Size = new System.Drawing.Size(185, 45);


            this.pnlReunion.TabIndex = 9;
            // 
            // btnReunion
            // 
            this.btnReunion.BackColor = System.Drawing.Color.Green;
            this.btnReunion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReunion.ForeColor = System.Drawing.Color.White;
            this.btnReunion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnReunion.Location = new System.Drawing.Point(-4, -4);
            this.btnReunion.Margin = new System.Windows.Forms.Padding(0);
            this.btnReunion.Name = "btnReunion";
            this.btnReunion.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReunion.Size = new System.Drawing.Size(193, 53);


            this.btnReunion.TabIndex = 1;
            this.btnReunion.Text = "Reuniones";
            this.btnReunion.UseVisualStyleBackColor = false;
            // 
            // pnlAutoridades
            // 
            this.pnlAutoridades.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAutoridades.Controls.Add(this.btnAutoridades);
            this.pnlAutoridades.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAutoridades.Location = new System.Drawing.Point(0, 231);
            this.pnlAutoridades.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAutoridades.Name = "pnlAutoridades";
            this.pnlAutoridades.Size = new System.Drawing.Size(247, 55);
            this.pnlAutoridades.TabIndex = 6;
            // 
            // btnAutoridades
            // 
            this.btnAutoridades.BackColor = System.Drawing.Color.Green;
            this.btnAutoridades.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoridades.ForeColor = System.Drawing.Color.White;
            this.btnAutoridades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoridades.Location = new System.Drawing.Point(-5, -5);
            this.btnAutoridades.Margin = new System.Windows.Forms.Padding(0);
            this.btnAutoridades.Name = "btnAutoridades";
            this.btnAutoridades.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnAutoridades.Size = new System.Drawing.Size(257, 65);
            this.btnAutoridades.TabIndex = 1;
            this.btnAutoridades.Text = "Autoridades";
            this.btnAutoridades.UseVisualStyleBackColor = false;
            // 
            // panelContenedorEstud
            // 
            this.panelContenedorEstud.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelContenedorEstud.Dock = System.Windows.Forms.DockStyle.Fill;

            this.panelContenedorEstud.Location = new System.Drawing.Point(185, 50);
            this.panelContenedorEstud.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedorEstud.Name = "panelContenedorEstud";
            this.panelContenedorEstud.Size = new System.Drawing.Size(790, 478);
            this.panelContenedorEstud.TabIndex = 14;
            this.panelContenedorEstud.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorEstud_Paint_1);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // FrmMenuEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedorEstud);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.panelCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.Margin = new System.Windows.Forms.Padding(2);


            this.Name = "FrmMenuEstudiantes";
            this.Text = "Menu Estudiantes";
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesliz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            this.flpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlEnvioDoc.ResumeLayout(false);
            this.pnlEstadoProceso.ResumeLayout(false);
            this.pnlReunion.ResumeLayout(false);
            this.pnlAutoridades.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrTransicionMenu;
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinim;
        private System.Windows.Forms.PictureBox btnDesliz;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelContenedorEstud;
        private System.Windows.Forms.Panel pnlEnvioDoc;
        private System.Windows.Forms.Button btnEnvioDoc;
        private System.Windows.Forms.Panel pnlReunion;
        private System.Windows.Forms.Button btnReunion;
        private System.Windows.Forms.Panel pnlEstadoProceso;
        private System.Windows.Forms.Button btnEstadoProceso;
        private System.Windows.Forms.Panel pnlAutoridades;
        private System.Windows.Forms.Button btnAutoridades;
        private System.Windows.Forms.Label label1;
    }
}