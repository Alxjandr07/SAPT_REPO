namespace SistemAutomProcesoTitulacion
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panelEncabezLogin = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelImagenLogin = new System.Windows.Forms.Panel();
            this.pboxImagenLogin = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.linkLabelContra = new System.Windows.Forms.LinkLabel();
            this.btnMostrarContra = new System.Windows.Forms.Button();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEncabezLogin.SuspendLayout();
            this.panelImagenLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagenLogin)).BeginInit();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEncabezLogin
            // 
            this.panelEncabezLogin.BackColor = System.Drawing.Color.Green;
            this.panelEncabezLogin.Controls.Add(this.label4);
            this.panelEncabezLogin.Controls.Add(this.button2);
            this.panelEncabezLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezLogin.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezLogin.Margin = new System.Windows.Forms.Padding(2);
            this.panelEncabezLogin.Name = "panelEncabezLogin";
            this.panelEncabezLogin.Size = new System.Drawing.Size(666, 24);
            this.panelEncabezLogin.TabIndex = 0;
            this.panelEncabezLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEncabezLogin_Paint);
            this.panelEncabezLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelEncabezLogin_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(5, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(524, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "SISTEMA AUTOMATIZADO DE PROCESOS DE TITULACIÓN";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(640, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 21);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelImagenLogin
            // 
            this.panelImagenLogin.BackColor = System.Drawing.Color.Green;
            this.panelImagenLogin.Controls.Add(this.pboxImagenLogin);
            this.panelImagenLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelImagenLogin.Location = new System.Drawing.Point(276, 24);
            this.panelImagenLogin.Margin = new System.Windows.Forms.Padding(2);
            this.panelImagenLogin.Name = "panelImagenLogin";
            this.panelImagenLogin.Size = new System.Drawing.Size(390, 225);
            this.panelImagenLogin.TabIndex = 1;
            // 
            // pboxImagenLogin
            // 
            this.pboxImagenLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxImagenLogin.Image = global::SistemAutomProcesoTitulacion.Properties.Resources.portada_sist_tit;
            this.pboxImagenLogin.Location = new System.Drawing.Point(0, 0);
            this.pboxImagenLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pboxImagenLogin.Name = "pboxImagenLogin";
            this.pboxImagenLogin.Size = new System.Drawing.Size(390, 225);
            this.pboxImagenLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxImagenLogin.TabIndex = 0;
            this.pboxImagenLogin.TabStop = false;
            this.pboxImagenLogin.Click += new System.EventHandler(this.pboxImagenLogin_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.linkLabelContra);
            this.panelLogin.Controls.Add(this.btnMostrarContra);
            this.panelLogin.Controls.Add(this.btnAcceder);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.txtContrasenia);
            this.panelLogin.Controls.Add(this.txtUsuario);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 24);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(276, 225);
            this.panelLogin.TabIndex = 2;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // linkLabelContra
            // 
            this.linkLabelContra.AutoSize = true;
            this.linkLabelContra.LinkColor = System.Drawing.Color.Green;
            this.linkLabelContra.Location = new System.Drawing.Point(71, 204);
            this.linkLabelContra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelContra.Name = "linkLabelContra";
            this.linkLabelContra.Size = new System.Drawing.Size(146, 13);
            this.linkLabelContra.TabIndex = 8;
            this.linkLabelContra.TabStop = true;
            this.linkLabelContra.Text = "¿Ha olvidado su contraseña?";
            // 
            // btnMostrarContra
            // 
            this.btnMostrarContra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrarContra.BackgroundImage")));
            this.btnMostrarContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMostrarContra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMostrarContra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnMostrarContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnMostrarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarContra.Location = new System.Drawing.Point(236, 140);
            this.btnMostrarContra.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarContra.Name = "btnMostrarContra";
            this.btnMostrarContra.Size = new System.Drawing.Size(26, 18);
            this.btnMostrarContra.TabIndex = 7;
            this.btnMostrarContra.UseVisualStyleBackColor = true;
            this.btnMostrarContra.Click += new System.EventHandler(this.btnMostrarContra_Click);
            // 
            // btnAcceder
            // 
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAcceder.FlatAppearance.BorderSize = 2;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.Green;
            this.btnAcceder.Location = new System.Drawing.Point(27, 167);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(223, 35);
            this.btnAcceder.TabIndex = 6;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasenia.Location = new System.Drawing.Point(9, 140);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasenia.MaxLength = 20;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(228, 20);
            this.txtContrasenia.TabIndex = 3;
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Location = new System.Drawing.Point(10, 95);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(252, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(71, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "INICIO DE SESIÓN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemAutomProcesoTitulacion.Properties.Resources.usuario__1_;
            this.pictureBox1.Location = new System.Drawing.Point(9, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 249);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelImagenLogin);
            this.Controls.Add(this.panelEncabezLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panelEncabezLogin.ResumeLayout(false);
            this.panelEncabezLogin.PerformLayout();
            this.panelImagenLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagenLogin)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEncabezLogin;
        private System.Windows.Forms.Panel panelImagenLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pboxImagenLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button btnMostrarContra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabelContra;
        private System.Windows.Forms.Label label4;
    }
}

