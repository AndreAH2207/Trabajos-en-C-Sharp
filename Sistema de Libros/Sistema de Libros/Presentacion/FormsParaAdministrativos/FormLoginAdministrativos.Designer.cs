namespace Presentacion.FormsParaAdministrativos {
    partial class FormLoginAdministrativos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.lbContrasenia = new System.Windows.Forms.Label();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_registrar.Location = new System.Drawing.Point(282, 109);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(127, 39);
            this.btn_registrar.TabIndex = 49;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DarkGray;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_login.Location = new System.Drawing.Point(99, 109);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(127, 39);
            this.btn_login.TabIndex = 48;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Location = new System.Drawing.Point(163, 62);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.Size = new System.Drawing.Size(284, 20);
            this.tbContrasenia.TabIndex = 47;
            // 
            // lbContrasenia
            // 
            this.lbContrasenia.AutoSize = true;
            this.lbContrasenia.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContrasenia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbContrasenia.Location = new System.Drawing.Point(35, 61);
            this.lbContrasenia.Name = "lbContrasenia";
            this.lbContrasenia.Size = new System.Drawing.Size(106, 23);
            this.lbContrasenia.TabIndex = 46;
            this.lbContrasenia.Text = "Contraseña";
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNombreUsuario.Location = new System.Drawing.Point(70, 21);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(71, 23);
            this.lbNombreUsuario.TabIndex = 45;
            this.lbNombreUsuario.Text = "Codigo";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(163, 22);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(284, 20);
            this.tbCodigo.TabIndex = 50;
            // 
            // FormLoginAdministrativos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(500, 184);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.lbContrasenia);
            this.Controls.Add(this.lbNombreUsuario);
            this.Name = "FormLoginAdministrativos";
            this.Text = "FormLoginAdministrativos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.Label lbContrasenia;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.TextBox tbCodigo;
    }
}