namespace Presentacion.FormsParaUsuarios {
    partial class FormRegistrarUsuarios {
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
            this.numud_telefono = new System.Windows.Forms.NumericUpDown();
            this.numud_Dni = new System.Windows.Forms.NumericUpDown();
            this.tbRegistrarContraseña = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.tbRegistrarCorreo = new System.Windows.Forms.TextBox();
            this.lbDNI = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbTituloRegistroDeUsuario = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbRegistrarApellidos = new System.Windows.Forms.TextBox();
            this.tbRegistrarNombres = new System.Windows.Forms.TextBox();
            this.lbContrasenia = new System.Windows.Forms.Label();
            this.lbNombresUsuario = new System.Windows.Forms.Label();
            this.tbRegistrarPais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRegistrarCiudad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numud_telefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Dni)).BeginInit();
            this.SuspendLayout();
            // 
            // numud_telefono
            // 
            this.numud_telefono.Location = new System.Drawing.Point(153, 292);
            this.numud_telefono.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numud_telefono.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numud_telefono.Name = "numud_telefono";
            this.numud_telefono.Size = new System.Drawing.Size(284, 20);
            this.numud_telefono.TabIndex = 52;
            this.numud_telefono.Value = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            // 
            // numud_Dni
            // 
            this.numud_Dni.Location = new System.Drawing.Point(153, 191);
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
            this.numud_Dni.TabIndex = 51;
            this.numud_Dni.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // tbRegistrarContraseña
            // 
            this.tbRegistrarContraseña.Location = new System.Drawing.Point(153, 343);
            this.tbRegistrarContraseña.Name = "tbRegistrarContraseña";
            this.tbRegistrarContraseña.Size = new System.Drawing.Size(284, 20);
            this.tbRegistrarContraseña.TabIndex = 50;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTelefono.Location = new System.Drawing.Point(54, 291);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(84, 23);
            this.lbTelefono.TabIndex = 49;
            this.lbTelefono.Text = "Teléfono";
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCorreo.Location = new System.Drawing.Point(70, 240);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(68, 23);
            this.lbCorreo.TabIndex = 48;
            this.lbCorreo.Text = "Correo";
            // 
            // tbRegistrarCorreo
            // 
            this.tbRegistrarCorreo.Location = new System.Drawing.Point(153, 240);
            this.tbRegistrarCorreo.Name = "tbRegistrarCorreo";
            this.tbRegistrarCorreo.Size = new System.Drawing.Size(284, 20);
            this.tbRegistrarCorreo.TabIndex = 47;
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDNI.Location = new System.Drawing.Point(99, 189);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(39, 23);
            this.lbDNI.TabIndex = 46;
            this.lbDNI.Text = "Dni";
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbApellidos.Location = new System.Drawing.Point(50, 138);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(88, 23);
            this.lbApellidos.TabIndex = 45;
            this.lbApellidos.Text = "Apellidos";
            // 
            // lbTituloRegistroDeUsuario
            // 
            this.lbTituloRegistroDeUsuario.AutoSize = true;
            this.lbTituloRegistroDeUsuario.Font = new System.Drawing.Font("Cooper Black", 24F);
            this.lbTituloRegistroDeUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTituloRegistroDeUsuario.Location = new System.Drawing.Point(72, 24);
            this.lbTituloRegistroDeUsuario.Name = "lbTituloRegistroDeUsuario";
            this.lbTituloRegistroDeUsuario.Size = new System.Drawing.Size(331, 36);
            this.lbTituloRegistroDeUsuario.TabIndex = 44;
            this.lbTituloRegistroDeUsuario.Text = "Registro de usuario";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Black;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(334, 480);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(103, 27);
            this.btnRegistrar.TabIndex = 43;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbRegistrarApellidos
            // 
            this.tbRegistrarApellidos.Location = new System.Drawing.Point(153, 142);
            this.tbRegistrarApellidos.Name = "tbRegistrarApellidos";
            this.tbRegistrarApellidos.Size = new System.Drawing.Size(284, 20);
            this.tbRegistrarApellidos.TabIndex = 42;
            // 
            // tbRegistrarNombres
            // 
            this.tbRegistrarNombres.Location = new System.Drawing.Point(153, 92);
            this.tbRegistrarNombres.Name = "tbRegistrarNombres";
            this.tbRegistrarNombres.Size = new System.Drawing.Size(284, 20);
            this.tbRegistrarNombres.TabIndex = 41;
            // 
            // lbContrasenia
            // 
            this.lbContrasenia.AutoSize = true;
            this.lbContrasenia.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContrasenia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbContrasenia.Location = new System.Drawing.Point(32, 340);
            this.lbContrasenia.Name = "lbContrasenia";
            this.lbContrasenia.Size = new System.Drawing.Size(106, 23);
            this.lbContrasenia.TabIndex = 40;
            this.lbContrasenia.Text = "Contraseña";
            // 
            // lbNombresUsuario
            // 
            this.lbNombresUsuario.AutoSize = true;
            this.lbNombresUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombresUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNombresUsuario.Location = new System.Drawing.Point(51, 92);
            this.lbNombresUsuario.Name = "lbNombresUsuario";
            this.lbNombresUsuario.Size = new System.Drawing.Size(87, 23);
            this.lbNombresUsuario.TabIndex = 39;
            this.lbNombresUsuario.Text = "Nombres";
            // 
            // tbRegistrarPais
            // 
            this.tbRegistrarPais.Location = new System.Drawing.Point(153, 389);
            this.tbRegistrarPais.Name = "tbRegistrarPais";
            this.tbRegistrarPais.Size = new System.Drawing.Size(284, 20);
            this.tbRegistrarPais.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(94, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Pais";
            // 
            // tbRegistrarCiudad
            // 
            this.tbRegistrarCiudad.Location = new System.Drawing.Point(153, 439);
            this.tbRegistrarCiudad.Name = "tbRegistrarCiudad";
            this.tbRegistrarCiudad.Size = new System.Drawing.Size(284, 20);
            this.tbRegistrarCiudad.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(68, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "Ciudad";
            // 
            // FormRegistrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(498, 529);
            this.Controls.Add(this.tbRegistrarCiudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRegistrarPais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numud_telefono);
            this.Controls.Add(this.numud_Dni);
            this.Controls.Add(this.tbRegistrarContraseña);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbCorreo);
            this.Controls.Add(this.tbRegistrarCorreo);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.lbTituloRegistroDeUsuario);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbRegistrarApellidos);
            this.Controls.Add(this.tbRegistrarNombres);
            this.Controls.Add(this.lbContrasenia);
            this.Controls.Add(this.lbNombresUsuario);
            this.Name = "FormRegistrarUsuarios";
            this.Text = "FormRegistrarUsuarios";
            this.Load += new System.EventHandler(this.FormRegistrarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numud_telefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Dni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numud_telefono;
        private System.Windows.Forms.NumericUpDown numud_Dni;
        private System.Windows.Forms.TextBox tbRegistrarContraseña;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.TextBox tbRegistrarCorreo;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbTituloRegistroDeUsuario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbRegistrarApellidos;
        private System.Windows.Forms.TextBox tbRegistrarNombres;
        private System.Windows.Forms.Label lbContrasenia;
        private System.Windows.Forms.Label lbNombresUsuario;
        private System.Windows.Forms.TextBox tbRegistrarPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRegistrarCiudad;
        private System.Windows.Forms.Label label2;
    }
}