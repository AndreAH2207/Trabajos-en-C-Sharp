namespace Presentacion.FormsParaAdministrativos {
    partial class FormVerPrestamo {
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
            this.lbl_nombreEnSesion = new System.Windows.Forms.Label();
            this.btn_verPrestamosConMultas = new System.Windows.Forms.Button();
            this.lbNombreLibro = new System.Windows.Forms.Label();
            this.dg_prestamos = new System.Windows.Forms.DataGridView();
            this.lbTituloRegistroDeUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Dni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_prestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // numud_Dni
            // 
            this.numud_Dni.Location = new System.Drawing.Point(256, 95);
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
            this.numud_Dni.TabIndex = 65;
            this.numud_Dni.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numud_Dni.ValueChanged += new System.EventHandler(this.numud_Dni_ValueChanged);
            // 
            // lbl_nombreEnSesion
            // 
            this.lbl_nombreEnSesion.AutoSize = true;
            this.lbl_nombreEnSesion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreEnSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nombreEnSesion.Location = new System.Drawing.Point(11, 15);
            this.lbl_nombreEnSesion.Name = "lbl_nombreEnSesion";
            this.lbl_nombreEnSesion.Size = new System.Drawing.Size(204, 16);
            this.lbl_nombreEnSesion.TabIndex = 64;
            this.lbl_nombreEnSesion.Text = "*Nombre del usuario en sesión*";
            // 
            // btn_verPrestamosConMultas
            // 
            this.btn_verPrestamosConMultas.BackColor = System.Drawing.Color.Black;
            this.btn_verPrestamosConMultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verPrestamosConMultas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_verPrestamosConMultas.Location = new System.Drawing.Point(369, 369);
            this.btn_verPrestamosConMultas.Name = "btn_verPrestamosConMultas";
            this.btn_verPrestamosConMultas.Size = new System.Drawing.Size(210, 27);
            this.btn_verPrestamosConMultas.TabIndex = 63;
            this.btn_verPrestamosConMultas.Text = "Ver prestamos con multas";
            this.btn_verPrestamosConMultas.UseVisualStyleBackColor = false;
            this.btn_verPrestamosConMultas.Click += new System.EventHandler(this.btn_verPrestamosConMultas_Click);
            // 
            // lbNombreLibro
            // 
            this.lbNombreLibro.AutoSize = true;
            this.lbNombreLibro.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbNombreLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNombreLibro.Location = new System.Drawing.Point(96, 94);
            this.lbNombreLibro.Name = "lbNombreLibro";
            this.lbNombreLibro.Size = new System.Drawing.Size(145, 23);
            this.lbNombreLibro.TabIndex = 62;
            this.lbNombreLibro.Text = "Dni del usuario";
            // 
            // dg_prestamos
            // 
            this.dg_prestamos.AllowUserToAddRows = false;
            this.dg_prestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_prestamos.Location = new System.Drawing.Point(75, 138);
            this.dg_prestamos.Name = "dg_prestamos";
            this.dg_prestamos.RowHeadersVisible = false;
            this.dg_prestamos.Size = new System.Drawing.Size(504, 213);
            this.dg_prestamos.TabIndex = 60;
            // 
            // lbTituloRegistroDeUsuario
            // 
            this.lbTituloRegistroDeUsuario.AutoSize = true;
            this.lbTituloRegistroDeUsuario.Font = new System.Drawing.Font("Cooper Black", 24F);
            this.lbTituloRegistroDeUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTituloRegistroDeUsuario.Location = new System.Drawing.Point(250, 28);
            this.lbTituloRegistroDeUsuario.Name = "lbTituloRegistroDeUsuario";
            this.lbTituloRegistroDeUsuario.Size = new System.Drawing.Size(169, 36);
            this.lbTituloRegistroDeUsuario.TabIndex = 59;
            this.lbTituloRegistroDeUsuario.Text = "Prestamo";
            // 
            // FormVerPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(641, 427);
            this.Controls.Add(this.numud_Dni);
            this.Controls.Add(this.lbl_nombreEnSesion);
            this.Controls.Add(this.btn_verPrestamosConMultas);
            this.Controls.Add(this.lbNombreLibro);
            this.Controls.Add(this.dg_prestamos);
            this.Controls.Add(this.lbTituloRegistroDeUsuario);
            this.Name = "FormVerPrestamo";
            this.Text = "FormVerPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.numud_Dni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_prestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numud_Dni;
        private System.Windows.Forms.Label lbl_nombreEnSesion;
        private System.Windows.Forms.Button btn_verPrestamosConMultas;
        private System.Windows.Forms.Label lbNombreLibro;
        private System.Windows.Forms.DataGridView dg_prestamos;
        private System.Windows.Forms.Label lbTituloRegistroDeUsuario;
    }
}