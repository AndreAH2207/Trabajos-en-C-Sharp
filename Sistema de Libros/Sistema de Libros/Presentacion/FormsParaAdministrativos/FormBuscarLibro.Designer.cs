namespace Presentacion.FormsParaAdministrativos {
    partial class FormBuscarLibro {
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dttimepicker_hasta = new System.Windows.Forms.DateTimePicker();
            this.dttimepicker_desde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIdioma = new System.Windows.Forms.ComboBox();
            this.lbl_nombreEnSesion = new System.Windows.Forms.Label();
            this.dgBuscarLibro = new System.Windows.Forms.DataGridView();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.lbTituloFiltroDeLibros = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(419, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 23);
            this.label4.TabIndex = 103;
            this.label4.Text = "Fecha de publicacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(392, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 102;
            this.label2.Text = "Hasta";
            // 
            // dttimepicker_hasta
            // 
            this.dttimepicker_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttimepicker_hasta.Location = new System.Drawing.Point(474, 142);
            this.dttimepicker_hasta.Name = "dttimepicker_hasta";
            this.dttimepicker_hasta.ShowUpDown = true;
            this.dttimepicker_hasta.Size = new System.Drawing.Size(200, 20);
            this.dttimepicker_hasta.TabIndex = 101;
            // 
            // dttimepicker_desde
            // 
            this.dttimepicker_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttimepicker_desde.Location = new System.Drawing.Point(474, 106);
            this.dttimepicker_desde.Name = "dttimepicker_desde";
            this.dttimepicker_desde.ShowUpDown = true;
            this.dttimepicker_desde.Size = new System.Drawing.Size(200, 20);
            this.dttimepicker_desde.TabIndex = 100;
            this.dttimepicker_desde.Value = new System.DateTime(2024, 11, 11, 18, 20, 24, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(388, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 99;
            this.label3.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 98;
            this.label1.Text = "Idioma";
            // 
            // cbIdioma
            // 
            this.cbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Location = new System.Drawing.Point(122, 168);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(229, 21);
            this.cbIdioma.TabIndex = 97;
            // 
            // lbl_nombreEnSesion
            // 
            this.lbl_nombreEnSesion.AutoSize = true;
            this.lbl_nombreEnSesion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreEnSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nombreEnSesion.Location = new System.Drawing.Point(13, 16);
            this.lbl_nombreEnSesion.Name = "lbl_nombreEnSesion";
            this.lbl_nombreEnSesion.Size = new System.Drawing.Size(204, 16);
            this.lbl_nombreEnSesion.TabIndex = 96;
            this.lbl_nombreEnSesion.Text = "*Nombre del usuario en sesión*";
            // 
            // dgBuscarLibro
            // 
            this.dgBuscarLibro.AllowUserToAddRows = false;
            this.dgBuscarLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuscarLibro.Location = new System.Drawing.Point(60, 248);
            this.dgBuscarLibro.Name = "dgBuscarLibro";
            this.dgBuscarLibro.RowHeadersVisible = false;
            this.dgBuscarLibro.Size = new System.Drawing.Size(603, 229);
            this.dgBuscarLibro.TabIndex = 95;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(122, 88);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(229, 21);
            this.cbGenero.TabIndex = 94;
            // 
            // cbAutor
            // 
            this.cbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(122, 129);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(229, 21);
            this.cbAutor.TabIndex = 93;
            // 
            // lbTituloFiltroDeLibros
            // 
            this.lbTituloFiltroDeLibros.AutoSize = true;
            this.lbTituloFiltroDeLibros.Font = new System.Drawing.Font("Cooper Black", 24F);
            this.lbTituloFiltroDeLibros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTituloFiltroDeLibros.Location = new System.Drawing.Point(252, 14);
            this.lbTituloFiltroDeLibros.Name = "lbTituloFiltroDeLibros";
            this.lbTituloFiltroDeLibros.Size = new System.Drawing.Size(213, 36);
            this.lbTituloFiltroDeLibros.TabIndex = 89;
            this.lbTituloFiltroDeLibros.Text = "Buscar libro";
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAutor.Location = new System.Drawing.Point(45, 128);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(62, 23);
            this.lbAutor.TabIndex = 87;
            this.lbAutor.Text = "Autor";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbGenero.Location = new System.Drawing.Point(31, 87);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(76, 23);
            this.lbGenero.TabIndex = 86;
            this.lbGenero.Text = "Genero";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Black;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFiltrar.Location = new System.Drawing.Point(461, 187);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(103, 27);
            this.btnFiltrar.TabIndex = 91;
            this.btnFiltrar.Text = "Filtrar/Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // FormBuscarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(727, 526);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dttimepicker_hasta);
            this.Controls.Add(this.dttimepicker_desde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbIdioma);
            this.Controls.Add(this.lbl_nombreEnSesion);
            this.Controls.Add(this.dgBuscarLibro);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.cbAutor);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lbTituloFiltroDeLibros);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.lbGenero);
            this.Name = "FormBuscarLibro";
            this.Text = "FormBuscarLibro";
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dttimepicker_hasta;
        private System.Windows.Forms.DateTimePicker dttimepicker_desde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIdioma;
        private System.Windows.Forms.Label lbl_nombreEnSesion;
        private System.Windows.Forms.DataGridView dgBuscarLibro;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.Label lbTituloFiltroDeLibros;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Button btnFiltrar;
    }
}