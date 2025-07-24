namespace Presentacion.FormsParaAdministrativos {
    partial class FormRegistrarLibro {
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
            this.numud_cantidadDePaginas = new System.Windows.Forms.NumericUpDown();
            this.cb_autor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_registrarAutor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ubicacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtimepicker_fechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.btn_registrarLibro = new System.Windows.Forms.Button();
            this.lbRegistroDeLibros = new System.Windows.Forms.Label();
            this.tb_idioma = new System.Windows.Forms.TextBox();
            this.lbIdioma = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.tb_genero = new System.Windows.Forms.TextBox();
            this.lbAutor = new System.Windows.Forms.Label();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.lbRegistrarTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numud_cantidadDePaginas)).BeginInit();
            this.SuspendLayout();
            // 
            // numud_cantidadDePaginas
            // 
            this.numud_cantidadDePaginas.Location = new System.Drawing.Point(246, 316);
            this.numud_cantidadDePaginas.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numud_cantidadDePaginas.Name = "numud_cantidadDePaginas";
            this.numud_cantidadDePaginas.Size = new System.Drawing.Size(233, 20);
            this.numud_cantidadDePaginas.TabIndex = 112;
            // 
            // cb_autor
            // 
            this.cb_autor.FormattingEnabled = true;
            this.cb_autor.Location = new System.Drawing.Point(246, 138);
            this.cb_autor.Name = "cb_autor";
            this.cb_autor.Size = new System.Drawing.Size(229, 21);
            this.cb_autor.TabIndex = 111;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(170, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 110;
            this.label6.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(380, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 109;
            this.label5.Text = "Registrelo!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(322, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 16);
            this.label4.TabIndex = 108;
            this.label4.Text = "¿No existe el autor que busca?";
            // 
            // btn_registrarAutor
            // 
            this.btn_registrarAutor.BackColor = System.Drawing.Color.DarkGray;
            this.btn_registrarAutor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_registrarAutor.Location = new System.Drawing.Point(352, 419);
            this.btn_registrarAutor.Name = "btn_registrarAutor";
            this.btn_registrarAutor.Size = new System.Drawing.Size(127, 39);
            this.btn_registrarAutor.TabIndex = 107;
            this.btn_registrarAutor.Text = "Registrar autor";
            this.btn_registrarAutor.UseVisualStyleBackColor = false;
            this.btn_registrarAutor.Click += new System.EventHandler(this.btn_registrarAutor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(134, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 106;
            this.label3.Text = "Ubicación";
            // 
            // tb_ubicacion
            // 
            this.tb_ubicacion.Location = new System.Drawing.Point(246, 360);
            this.tb_ubicacion.Name = "tb_ubicacion";
            this.tb_ubicacion.Size = new System.Drawing.Size(233, 20);
            this.tb_ubicacion.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(37, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 104;
            this.label1.Text = "Fecha de publicacion";
            // 
            // dtimepicker_fechaPublicacion
            // 
            this.dtimepicker_fechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtimepicker_fechaPublicacion.Location = new System.Drawing.Point(246, 269);
            this.dtimepicker_fechaPublicacion.Name = "dtimepicker_fechaPublicacion";
            this.dtimepicker_fechaPublicacion.ShowUpDown = true;
            this.dtimepicker_fechaPublicacion.Size = new System.Drawing.Size(233, 20);
            this.dtimepicker_fechaPublicacion.TabIndex = 103;
            this.dtimepicker_fechaPublicacion.Value = new System.DateTime(2024, 11, 11, 18, 20, 24, 0);
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(13, 11);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(204, 16);
            this.lbl_nombreUsuario.TabIndex = 102;
            this.lbl_nombreUsuario.Text = "*Nombre del usuario en sesión*";
            // 
            // btn_registrarLibro
            // 
            this.btn_registrarLibro.BackColor = System.Drawing.Color.DarkGray;
            this.btn_registrarLibro.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_registrarLibro.Location = new System.Drawing.Point(174, 419);
            this.btn_registrarLibro.Name = "btn_registrarLibro";
            this.btn_registrarLibro.Size = new System.Drawing.Size(127, 39);
            this.btn_registrarLibro.TabIndex = 101;
            this.btn_registrarLibro.Text = "Registrar libro";
            this.btn_registrarLibro.UseVisualStyleBackColor = false;
            this.btn_registrarLibro.Click += new System.EventHandler(this.btn_registrarLibro_Click);
            // 
            // lbRegistroDeLibros
            // 
            this.lbRegistroDeLibros.AutoSize = true;
            this.lbRegistroDeLibros.Font = new System.Drawing.Font("Cooper Black", 24F);
            this.lbRegistroDeLibros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRegistroDeLibros.Location = new System.Drawing.Point(177, 36);
            this.lbRegistroDeLibros.Name = "lbRegistroDeLibros";
            this.lbRegistroDeLibros.Size = new System.Drawing.Size(285, 36);
            this.lbRegistroDeLibros.TabIndex = 100;
            this.lbRegistroDeLibros.Text = "Registro de libro";
            // 
            // tb_idioma
            // 
            this.tb_idioma.Location = new System.Drawing.Point(246, 221);
            this.tb_idioma.Name = "tb_idioma";
            this.tb_idioma.Size = new System.Drawing.Size(233, 20);
            this.tb_idioma.TabIndex = 99;
            // 
            // lbIdioma
            // 
            this.lbIdioma.AutoSize = true;
            this.lbIdioma.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdioma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbIdioma.Location = new System.Drawing.Point(160, 220);
            this.lbIdioma.Name = "lbIdioma";
            this.lbIdioma.Size = new System.Drawing.Size(68, 23);
            this.lbIdioma.TabIndex = 98;
            this.lbIdioma.Text = "Idioma";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbGenero.Location = new System.Drawing.Point(156, 177);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(72, 23);
            this.lbGenero.TabIndex = 97;
            this.lbGenero.Text = "Género";
            // 
            // tb_genero
            // 
            this.tb_genero.Location = new System.Drawing.Point(246, 178);
            this.tb_genero.Name = "tb_genero";
            this.tb_genero.Size = new System.Drawing.Size(233, 20);
            this.tb_genero.TabIndex = 96;
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAutor.Location = new System.Drawing.Point(41, 315);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(183, 23);
            this.lbAutor.TabIndex = 95;
            this.lbAutor.Text = "Cantidad de páginas";
            // 
            // tb_titulo
            // 
            this.tb_titulo.Location = new System.Drawing.Point(245, 99);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(233, 20);
            this.tb_titulo.TabIndex = 94;
            // 
            // lbRegistrarTitulo
            // 
            this.lbRegistrarTitulo.AutoSize = true;
            this.lbRegistrarTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistrarTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRegistrarTitulo.Location = new System.Drawing.Point(170, 98);
            this.lbRegistrarTitulo.Name = "lbRegistrarTitulo";
            this.lbRegistrarTitulo.Size = new System.Drawing.Size(58, 23);
            this.lbRegistrarTitulo.TabIndex = 93;
            this.lbRegistrarTitulo.Text = "Titulo";
            // 
            // FormRegistrarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(566, 529);
            this.Controls.Add(this.numud_cantidadDePaginas);
            this.Controls.Add(this.cb_autor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_registrarAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_ubicacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtimepicker_fechaPublicacion);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Controls.Add(this.btn_registrarLibro);
            this.Controls.Add(this.lbRegistroDeLibros);
            this.Controls.Add(this.tb_idioma);
            this.Controls.Add(this.lbIdioma);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.tb_genero);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.tb_titulo);
            this.Controls.Add(this.lbRegistrarTitulo);
            this.Name = "FormRegistrarLibro";
            this.Text = "FormRegistrarLibro";
            ((System.ComponentModel.ISupportInitialize)(this.numud_cantidadDePaginas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numud_cantidadDePaginas;
        private System.Windows.Forms.ComboBox cb_autor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_registrarAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ubicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtimepicker_fechaPublicacion;
        private System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.Button btn_registrarLibro;
        private System.Windows.Forms.Label lbRegistroDeLibros;
        private System.Windows.Forms.TextBox tb_idioma;
        private System.Windows.Forms.Label lbIdioma;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.TextBox tb_genero;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.Label lbRegistrarTitulo;
    }
}