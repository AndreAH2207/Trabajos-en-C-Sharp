namespace Presentacion.FormsParaUsuarios {
    partial class FormLoginUsuarios {
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
            this.numud_Dni = new System.Windows.Forms.NumericUpDown();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.lbContrasenia = new System.Windows.Forms.Label();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Dni)).BeginInit();
            this.SuspendLayout();
            // 
            // numud_Dni
            // 
            this.numud_Dni.Location = new System.Drawing.Point(153, 18);
            this.numud_Dni.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numud_Dni.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numud_Dni.Name = "numud_Dni";
            this.numud_Dni.Size = new System.Drawing.Size(284, 20);
            this.numud_Dni.TabIndex = 44;
            this.numud_Dni.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_registrar.Location = new System.Drawing.Point(272, 105);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(127, 39);
            this.btn_registrar.TabIndex = 43;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DarkGray;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_login.Location = new System.Drawing.Point(89, 105);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(127, 39);
            this.btn_login.TabIndex = 42;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Location = new System.Drawing.Point(153, 58);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.Size = new System.Drawing.Size(284, 20);
            this.tbContrasenia.TabIndex = 41;
            // 
            // lbContrasenia
            // 
            this.lbContrasenia.AutoSize = true;
            this.lbContrasenia.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContrasenia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbContrasenia.Location = new System.Drawing.Point(25, 57);
            this.lbContrasenia.Name = "lbContrasenia";
            this.lbContrasenia.Size = new System.Drawing.Size(106, 23);
            this.lbContrasenia.TabIndex = 40;
            this.lbContrasenia.Text = "Contraseña";
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNombreUsuario.Location = new System.Drawing.Point(95, 17);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(39, 23);
            this.lbNombreUsuario.TabIndex = 39;
            this.lbNombreUsuario.Text = "Dni";
            // 
            // FormLoginUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(506, 168);
            this.Controls.Add(this.numud_Dni);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.lbContrasenia);
            this.Controls.Add(this.lbNombreUsuario);
            this.Name = "FormLoginUsuarios";
            this.Text = "FormLoginUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.numud_Dni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numud_Dni;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.Label lbContrasenia;
        private System.Windows.Forms.Label lbNombreUsuario;
    }
}