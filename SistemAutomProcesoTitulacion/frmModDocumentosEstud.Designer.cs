namespace SistemAutomProcesoTitulacion
{
    partial class frmModDocumentosEstud
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
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.sistemaTitulacionUTEQDataSet = new SistemAutomProcesoTitulacion.SistemaTitulacionUTEQDataSet();
            this.sbrDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sbrDocumentoTableAdapter = new SistemAutomProcesoTitulacion.SistemaTitulacionUTEQDataSetTableAdapters.SbrDocumentoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDocumentos = new System.Windows.Forms.DataGridView();
            this.idDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSubidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbrDocumentoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaTitulacionUTEQDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sbrDocumentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaTitulacionUTEQDataSet1 = new SistemAutomProcesoTitulacion.SistemaTitulacionUTEQDataSet1();
            this.sbrDocumentoTableAdapter1 = new SistemAutomProcesoTitulacion.SistemaTitulacionUTEQDataSet1TableAdapters.SbrDocumentoTableAdapter();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaTitulacionUTEQDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbrDocumentoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbrDocumentoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaTitulacionUTEQDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbrDocumentoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaTitulacionUTEQDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubir
            // 
            this.btnSubir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubir.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnSubir.FlatAppearance.BorderSize = 2;
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.Font = new System.Drawing.Font("Century Gothic", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubir.Location = new System.Drawing.Point(287, 267);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(104, 43);
            this.btnSubir.TabIndex = 13;
            this.btnSubir.Text = "CONFIRMAR";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(397, 267);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 43);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // sistemaTitulacionUTEQDataSet
            // 
            this.sistemaTitulacionUTEQDataSet.DataSetName = "SistemaTitulacionUTEQDataSet";
            this.sistemaTitulacionUTEQDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sbrDocumentoBindingSource
            // 
            this.sbrDocumentoBindingSource.DataMember = "SbrDocumento";
            this.sbrDocumentoBindingSource.DataSource = this.sistemaTitulacionUTEQDataSet;
            // 
            // sbrDocumentoTableAdapter
            // 
            this.sbrDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvDocumentos);
            this.panel1.Location = new System.Drawing.Point(20, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 106);
            this.panel1.TabIndex = 17;
            // 
            // dgvDocumentos
            // 
            this.dgvDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumentos.AutoGenerateColumns = false;
            this.dgvDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocumentos.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocumentoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.fechaSubidaDataGridViewTextBoxColumn});
            this.dgvDocumentos.DataSource = this.sbrDocumentoBindingSource2;
            this.dgvDocumentos.Location = new System.Drawing.Point(0, 0);
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.ReadOnly = true;
            this.dgvDocumentos.Size = new System.Drawing.Size(477, 106);
            this.dgvDocumentos.TabIndex = 0;
            this.dgvDocumentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumentos_CellContentClick);
            // 
            // idDocumentoDataGridViewTextBoxColumn
            // 
            this.idDocumentoDataGridViewTextBoxColumn.DataPropertyName = "IdDocumento";
            this.idDocumentoDataGridViewTextBoxColumn.HeaderText = "IdDocumento";
            this.idDocumentoDataGridViewTextBoxColumn.Name = "idDocumentoDataGridViewTextBoxColumn";
            this.idDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaSubidaDataGridViewTextBoxColumn
            // 
            this.fechaSubidaDataGridViewTextBoxColumn.DataPropertyName = "FechaSubida";
            this.fechaSubidaDataGridViewTextBoxColumn.HeaderText = "FechaSubida";
            this.fechaSubidaDataGridViewTextBoxColumn.Name = "fechaSubidaDataGridViewTextBoxColumn";
            this.fechaSubidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sbrDocumentoBindingSource2
            // 
            this.sbrDocumentoBindingSource2.DataMember = "SbrDocumento";
            this.sbrDocumentoBindingSource2.DataSource = this.sistemaTitulacionUTEQDataSetBindingSource;
            // 
            // sistemaTitulacionUTEQDataSetBindingSource
            // 
            this.sistemaTitulacionUTEQDataSetBindingSource.DataSource = this.sistemaTitulacionUTEQDataSet;
            this.sistemaTitulacionUTEQDataSetBindingSource.Position = 0;
            // 
            // sbrDocumentoBindingSource1
            // 
            this.sbrDocumentoBindingSource1.DataMember = "SbrDocumento";
            this.sbrDocumentoBindingSource1.DataSource = this.sistemaTitulacionUTEQDataSet1;
            // 
            // sistemaTitulacionUTEQDataSet1
            // 
            this.sistemaTitulacionUTEQDataSet1.DataSetName = "SistemaTitulacionUTEQDataSet1";
            this.sistemaTitulacionUTEQDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sbrDocumentoTableAdapter1
            // 
            this.sbrDocumentoTableAdapter1.ClearBeforeFill = true;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExaminar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnExaminar.FlatAppearance.BorderSize = 2;
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Font = new System.Drawing.Font("Century Gothic", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExaminar.Location = new System.Drawing.Point(20, 267);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(104, 43);
            this.btnExaminar.TabIndex = 18;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(20, 154);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.ReadOnly = true;
            this.txtRutaArchivo.Size = new System.Drawing.Size(142, 20);
            this.txtRutaArchivo.TabIndex = 19;
            this.txtRutaArchivo.TextChanged += new System.EventHandler(this.txtRutaArchivo_TextChanged);
            // 
            // btnVer
            // 
            this.btnVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVer.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnVer.FlatAppearance.BorderSize = 2;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVer.Location = new System.Drawing.Point(130, 267);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(88, 43);
            this.btnVer.TabIndex = 20;
            this.btnVer.Text = "Visualizar";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // frmModDocumentosEstud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(513, 333);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSubir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmModDocumentosEstud";
            this.Text = "frmModDocumentosEstud";
            this.Load += new System.EventHandler(this.frmModDocumentosEstud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaTitulacionUTEQDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbrDocumentoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbrDocumentoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaTitulacionUTEQDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbrDocumentoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaTitulacionUTEQDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnEliminar;
        private SistemaTitulacionUTEQDataSet sistemaTitulacionUTEQDataSet;
        private System.Windows.Forms.BindingSource sbrDocumentoBindingSource;
        private SistemaTitulacionUTEQDataSetTableAdapters.SbrDocumentoTableAdapter sbrDocumentoTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDocumentos;
        private SistemaTitulacionUTEQDataSet1 sistemaTitulacionUTEQDataSet1;
        private System.Windows.Forms.BindingSource sbrDocumentoBindingSource1;
        private SistemaTitulacionUTEQDataSet1TableAdapters.SbrDocumentoTableAdapter sbrDocumentoTableAdapter1;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.BindingSource sistemaTitulacionUTEQDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSubidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sbrDocumentoBindingSource2;
        private System.Windows.Forms.Button btnVer;
    }
}