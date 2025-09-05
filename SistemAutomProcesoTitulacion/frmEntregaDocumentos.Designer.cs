namespace SistemAutomProcesoTitulacion
{
    partial class frmEntregaDocumentos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSeleccionarDocumento = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblFormatoEntrega = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entrega de Documentos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(648, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 55);
            this.label5.TabIndex = 1;
            this.label5.Text = "UTEQ";
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(237, 207);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(86, 26);
            this.btnDescargar.TabIndex = 10;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 60);
            this.panel2.TabIndex = 11;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(441, 241);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSeleccionarDocumento
            // 
            this.btnSeleccionarDocumento.Location = new System.Drawing.Point(329, 209);
            this.btnSeleccionarDocumento.Name = "btnSeleccionarDocumento";
            this.btnSeleccionarDocumento.Size = new System.Drawing.Size(187, 23);
            this.btnSeleccionarDocumento.TabIndex = 14;
            this.btnSeleccionarDocumento.Text = "Seleccionar Documento";
            this.btnSeleccionarDocumento.UseVisualStyleBackColor = true;
            this.btnSeleccionarDocumento.Click += new System.EventHandler(this.btnSeleccionarDocumento_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(329, 241);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblFormatoEntrega
            // 
            this.lblFormatoEntrega.AutoSize = true;
            this.lblFormatoEntrega.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFormatoEntrega.Location = new System.Drawing.Point(346, 267);
            this.lblFormatoEntrega.Name = "lblFormatoEntrega";
            this.lblFormatoEntrega.Size = new System.Drawing.Size(154, 13);
            this.lblFormatoEntrega.TabIndex = 16;
            this.lblFormatoEntrega.Text = "Formatos permitidos Word , Pdf";
            this.lblFormatoEntrega.Click += new System.EventHandler(this.lblFormatoEntrega_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(702, 66);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(86, 26);
            this.btnAtras.TabIndex = 17;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnDescargar);
            this.panel4.Controls.Add(this.btnEliminar);
            this.panel4.Controls.Add(this.lblFormatoEntrega);
            this.panel4.Controls.Add(this.btnSeleccionarDocumento);
            this.panel4.Controls.Add(this.btnEditar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 330);
            this.panel4.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmEntregaDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEntregaDocumentos";
            this.Text = "frmEntregaDocumentos";
            this.Load += new System.EventHandler(this.frmEntregaDocumentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSeleccionarDocumento;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblFormatoEntrega;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
    }
}