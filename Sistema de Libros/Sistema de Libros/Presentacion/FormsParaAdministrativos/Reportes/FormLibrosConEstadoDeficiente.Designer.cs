namespace Presentacion.FormsParaAdministrativos.Reportes {
    partial class FormLibrosConEstadoDeficiente {
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
            this.lbl_nombreEnSesion = new System.Windows.Forms.Label();
            this.dg_libros = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_severidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_libros)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombreEnSesion
            // 
            this.lbl_nombreEnSesion.AutoSize = true;
            this.lbl_nombreEnSesion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreEnSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nombreEnSesion.Location = new System.Drawing.Point(12, 13);
            this.lbl_nombreEnSesion.Name = "lbl_nombreEnSesion";
            this.lbl_nombreEnSesion.Size = new System.Drawing.Size(204, 16);
            this.lbl_nombreEnSesion.TabIndex = 85;
            this.lbl_nombreEnSesion.Text = "*Nombre del usuario en sesión*";
            // 
            // dg_libros
            // 
            this.dg_libros.AllowUserToAddRows = false;
            this.dg_libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_libros.Location = new System.Drawing.Point(38, 104);
            this.dg_libros.Name = "dg_libros";
            this.dg_libros.RowHeadersVisible = false;
            this.dg_libros.Size = new System.Drawing.Size(703, 229);
            this.dg_libros.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(35, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 83;
            this.label4.Text = "Nivel de severidad";
            // 
            // cb_severidad
            // 
            this.cb_severidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_severidad.FormattingEnabled = true;
            this.cb_severidad.Items.AddRange(new object[] {
            "Bajo",
            "Medio",
            "Grave",
            "Inutilizable"});
            this.cb_severidad.Location = new System.Drawing.Point(157, 62);
            this.cb_severidad.Name = "cb_severidad";
            this.cb_severidad.Size = new System.Drawing.Size(121, 21);
            this.cb_severidad.TabIndex = 82;
            this.cb_severidad.SelectedIndexChanged += new System.EventHandler(this.cb_severidad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Libros con estado deficiente";
            // 
            // FormLibrosConEstadoDeficiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(777, 373);
            this.Controls.Add(this.lbl_nombreEnSesion);
            this.Controls.Add(this.dg_libros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_severidad);
            this.Controls.Add(this.label1);
            this.Name = "FormLibrosConEstadoDeficiente";
            this.Text = "FormLibrosConEstadoDeficiente";
            ((System.ComponentModel.ISupportInitialize)(this.dg_libros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombreEnSesion;
        private System.Windows.Forms.DataGridView dg_libros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_severidad;
        private System.Windows.Forms.Label label1;
    }
}