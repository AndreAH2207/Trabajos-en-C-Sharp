namespace Presentacion.FormsParaUsuarios {
    partial class FormReservarLibro {
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
            this.lbl_nombresesion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtimePicker_fechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lbTituloRegistroDeUsuario = new System.Windows.Forms.Label();
            this.brn_reservar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTitulo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_nombresesion
            // 
            this.lbl_nombresesion.AutoSize = true;
            this.lbl_nombresesion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombresesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nombresesion.Location = new System.Drawing.Point(16, 16);
            this.lbl_nombresesion.Name = "lbl_nombresesion";
            this.lbl_nombresesion.Size = new System.Drawing.Size(204, 16);
            this.lbl_nombresesion.TabIndex = 69;
            this.lbl_nombresesion.Text = "*Nombre del usuario en sesión*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(82, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 68;
            this.label1.Text = "Fecha de devolución";
            // 
            // dtimePicker_fechaDevolucion
            // 
            this.dtimePicker_fechaDevolucion.Location = new System.Drawing.Point(281, 145);
            this.dtimePicker_fechaDevolucion.Name = "dtimePicker_fechaDevolucion";
            this.dtimePicker_fechaDevolucion.Size = new System.Drawing.Size(229, 20);
            this.dtimePicker_fechaDevolucion.TabIndex = 67;
            // 
            // lbTituloRegistroDeUsuario
            // 
            this.lbTituloRegistroDeUsuario.AutoSize = true;
            this.lbTituloRegistroDeUsuario.Font = new System.Drawing.Font("Cooper Black", 24F);
            this.lbTituloRegistroDeUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTituloRegistroDeUsuario.Location = new System.Drawing.Point(174, 44);
            this.lbTituloRegistroDeUsuario.Name = "lbTituloRegistroDeUsuario";
            this.lbTituloRegistroDeUsuario.Size = new System.Drawing.Size(285, 36);
            this.lbTituloRegistroDeUsuario.TabIndex = 65;
            this.lbTituloRegistroDeUsuario.Text = "Reserva de Libro";
            // 
            // brn_reservar
            // 
            this.brn_reservar.BackColor = System.Drawing.Color.Black;
            this.brn_reservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_reservar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brn_reservar.Location = new System.Drawing.Point(407, 180);
            this.brn_reservar.Name = "brn_reservar";
            this.brn_reservar.Size = new System.Drawing.Size(103, 27);
            this.brn_reservar.TabIndex = 63;
            this.brn_reservar.Text = "Reservar";
            this.brn_reservar.UseVisualStyleBackColor = false;
            this.brn_reservar.Click += new System.EventHandler(this.brn_reservar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(207, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 70;
            this.label3.Text = "Titulo";
            // 
            // cbTitulo
            // 
            this.cbTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTitulo.FormattingEnabled = true;
            this.cbTitulo.Location = new System.Drawing.Point(281, 100);
            this.cbTitulo.Name = "cbTitulo";
            this.cbTitulo.Size = new System.Drawing.Size(229, 21);
            this.cbTitulo.TabIndex = 71;
            // 
            // FormReservarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(586, 233);
            this.Controls.Add(this.cbTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_nombresesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtimePicker_fechaDevolucion);
            this.Controls.Add(this.lbTituloRegistroDeUsuario);
            this.Controls.Add(this.brn_reservar);
            this.Name = "FormReservarLibro";
            this.Text = "FormReservarLibro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombresesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtimePicker_fechaDevolucion;
        private System.Windows.Forms.Label lbTituloRegistroDeUsuario;
        private System.Windows.Forms.Button brn_reservar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTitulo;
    }
}