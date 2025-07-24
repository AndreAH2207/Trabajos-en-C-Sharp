namespace Presentacion.FormsParaAdministrativos {
    partial class FormLibrosPorAutor {
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
            this.btn_registrarLibro = new System.Windows.Forms.Button();
            this.dg_libros = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_nombreEnSesion = new System.Windows.Forms.Label();
            this.cb_autor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_libros)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_registrarLibro
            // 
            this.btn_registrarLibro.BackColor = System.Drawing.Color.DarkGray;
            this.btn_registrarLibro.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_registrarLibro.Location = new System.Drawing.Point(516, 363);
            this.btn_registrarLibro.Name = "btn_registrarLibro";
            this.btn_registrarLibro.Size = new System.Drawing.Size(127, 39);
            this.btn_registrarLibro.TabIndex = 85;
            this.btn_registrarLibro.Text = "Registrar libros";
            this.btn_registrarLibro.UseVisualStyleBackColor = false;
            // 
            // dg_libros
            // 
            this.dg_libros.AllowUserToAddRows = false;
            this.dg_libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_libros.Location = new System.Drawing.Point(40, 115);
            this.dg_libros.Name = "dg_libros";
            this.dg_libros.RowHeadersVisible = false;
            this.dg_libros.Size = new System.Drawing.Size(603, 229);
            this.dg_libros.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(37, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 83;
            this.label3.Text = "Autor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(37, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(295, 16);
            this.label14.TabIndex = 82;
            this.label14.Text = "Ubicación en la biblioteca de los libros por Autor";
            // 
            // lbl_nombreEnSesion
            // 
            this.lbl_nombreEnSesion.AutoSize = true;
            this.lbl_nombreEnSesion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreEnSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nombreEnSesion.Location = new System.Drawing.Point(12, 14);
            this.lbl_nombreEnSesion.Name = "lbl_nombreEnSesion";
            this.lbl_nombreEnSesion.Size = new System.Drawing.Size(204, 16);
            this.lbl_nombreEnSesion.TabIndex = 81;
            this.lbl_nombreEnSesion.Text = "*Nombre del usuario en sesión*";
            // 
            // cb_autor
            // 
            this.cb_autor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_autor.FormattingEnabled = true;
            this.cb_autor.Location = new System.Drawing.Point(82, 80);
            this.cb_autor.Name = "cb_autor";
            this.cb_autor.Size = new System.Drawing.Size(121, 21);
            this.cb_autor.TabIndex = 80;
            this.cb_autor.SelectedIndexChanged += new System.EventHandler(this.cb_autor_SelectedIndexChanged);
            // 
            // FormLibrosPorAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(678, 430);
            this.Controls.Add(this.btn_registrarLibro);
            this.Controls.Add(this.dg_libros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_nombreEnSesion);
            this.Controls.Add(this.cb_autor);
            this.Name = "FormLibrosPorAutor";
            this.Text = "FormLibrosPorAutor";
            ((System.ComponentModel.ISupportInitialize)(this.dg_libros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_registrarLibro;
        private System.Windows.Forms.DataGridView dg_libros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_nombreEnSesion;
        private System.Windows.Forms.ComboBox cb_autor;
    }
}