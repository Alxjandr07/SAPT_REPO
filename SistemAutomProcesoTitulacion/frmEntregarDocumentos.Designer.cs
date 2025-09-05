namespace SistemAutomProcesoTitulacion
{
    partial class frmEntregarDocumentos
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvEntregarDoc = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregarDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 48);
            this.panel3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(671, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "UTEQ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.pnlCentral);
            this.panel1.Controls.Add(this.btnSubir);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 402);
            this.panel1.TabIndex = 6;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(583, 356);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(104, 43);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.dgvEntregarDoc);
            this.pnlCentral.Location = new System.Drawing.Point(59, 55);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(682, 295);
            this.pnlCentral.TabIndex = 0;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(113, 356);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(104, 43);
            this.btnSubir.TabIndex = 12;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(473, 356);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 43);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvEntregarDoc
            // 
            this.dgvEntregarDoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEntregarDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregarDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntregarDoc.Location = new System.Drawing.Point(0, 0);
            this.dgvEntregarDoc.Name = "dgvEntregarDoc";
            this.dgvEntregarDoc.Size = new System.Drawing.Size(682, 295);
            this.dgvEntregarDoc.TabIndex = 0;
            // 
            // frmEntregarDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEntregarDocumentos";
            this.Text = "frmEntregarDocumentos";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregarDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvEntregarDoc;
    }
}