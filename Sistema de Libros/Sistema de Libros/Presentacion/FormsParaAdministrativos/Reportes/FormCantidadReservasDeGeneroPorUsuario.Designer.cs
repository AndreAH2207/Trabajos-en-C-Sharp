namespace Presentacion.FormsParaAdministrativos.Reportes {
    partial class FormCantidadReservasDeGeneroPorUsuario {
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
            this.label8 = new System.Windows.Forms.Label();
            this.cb_genero = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dg_genero = new System.Windows.Forms.DataGridView();
            this.cb_dniUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_genero)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombreEnSesion
            // 
            this.lbl_nombreEnSesion.AutoSize = true;
            this.lbl_nombreEnSesion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombreEnSesion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreEnSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nombreEnSesion.Location = new System.Drawing.Point(17, 19);
            this.lbl_nombreEnSesion.Name = "lbl_nombreEnSesion";
            this.lbl_nombreEnSesion.Size = new System.Drawing.Size(204, 16);
            this.lbl_nombreEnSesion.TabIndex = 79;
            this.lbl_nombreEnSesion.Text = "*Nombre del usuario en sesión*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(29, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 78;
            this.label8.Text = "Género";
            // 
            // cb_genero
            // 
            this.cb_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_genero.FormattingEnabled = true;
            this.cb_genero.Location = new System.Drawing.Point(85, 86);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Size = new System.Drawing.Size(121, 21);
            this.cb_genero.TabIndex = 77;
            this.cb_genero.SelectedIndexChanged += new System.EventHandler(this.cb_genero_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(29, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(327, 16);
            this.label10.TabIndex = 76;
            this.label10.Text = "Cantidad de reservas de usuarios por genero del libro";
            // 
            // dg_genero
            // 
            this.dg_genero.AllowUserToAddRows = false;
            this.dg_genero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_genero.Location = new System.Drawing.Point(32, 119);
            this.dg_genero.Name = "dg_genero";
            this.dg_genero.RowHeadersVisible = false;
            this.dg_genero.Size = new System.Drawing.Size(404, 43);
            this.dg_genero.TabIndex = 75;
            // 
            // cb_dniUsuario
            // 
            this.cb_dniUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dniUsuario.FormattingEnabled = true;
            this.cb_dniUsuario.Location = new System.Drawing.Point(303, 86);
            this.cb_dniUsuario.Name = "cb_dniUsuario";
            this.cb_dniUsuario.Size = new System.Drawing.Size(121, 21);
            this.cb_dniUsuario.TabIndex = 80;
            this.cb_dniUsuario.SelectedIndexChanged += new System.EventHandler(this.cb_dniUsuario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(224, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Dni usuario";
            // 
            // FormCantidadReservasDeGeneroPorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(478, 185);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_dniUsuario);
            this.Controls.Add(this.lbl_nombreEnSesion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_genero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dg_genero);
            this.Name = "FormCantidadReservasDeGeneroPorUsuario";
            this.Text = "FormCantidadReservasDeGeneroPorUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dg_genero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombreEnSesion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_genero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dg_genero;
        private System.Windows.Forms.ComboBox cb_dniUsuario;
        private System.Windows.Forms.Label label1;
    }
}