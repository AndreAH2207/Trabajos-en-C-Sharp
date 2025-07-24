namespace Presentacion
{
    partial class FormEstadisticaEquipo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgEstadisticasEquipo = new System.Windows.Forms.DataGridView();
            this.btnVerHistorial = new System.Windows.Forms.Button();
            this.cbTorneo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstadisticasEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 33);
            this.label3.TabIndex = 177;
            this.label3.Text = "ESTADISTICAS POR EQUIPO";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MistyRose;
            this.btnSalir.Location = new System.Drawing.Point(616, 333);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 176;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgEstadisticasEquipo
            // 
            this.dgEstadisticasEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstadisticasEquipo.Location = new System.Drawing.Point(244, 93);
            this.dgEstadisticasEquipo.Name = "dgEstadisticasEquipo";
            this.dgEstadisticasEquipo.Size = new System.Drawing.Size(456, 234);
            this.dgEstadisticasEquipo.TabIndex = 174;
            // 
            // btnVerHistorial
            // 
            this.btnVerHistorial.BackColor = System.Drawing.Color.MistyRose;
            this.btnVerHistorial.Location = new System.Drawing.Point(90, 192);
            this.btnVerHistorial.Name = "btnVerHistorial";
            this.btnVerHistorial.Size = new System.Drawing.Size(87, 26);
            this.btnVerHistorial.TabIndex = 173;
            this.btnVerHistorial.Text = "Ver Historial";
            this.btnVerHistorial.UseVisualStyleBackColor = false;
            this.btnVerHistorial.Click += new System.EventHandler(this.btnVerHistorial_Click);
            // 
            // cbTorneo
            // 
            this.cbTorneo.FormattingEnabled = true;
            this.cbTorneo.Location = new System.Drawing.Point(90, 156);
            this.cbTorneo.Name = "cbTorneo";
            this.cbTorneo.Size = new System.Drawing.Size(121, 21);
            this.cbTorneo.TabIndex = 171;
            this.cbTorneo.SelectedIndexChanged += new System.EventHandler(this.cbTorneo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 169;
            this.label1.Text = "Torneo:";
            // 
            // FormEstadisticaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(765, 386);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgEstadisticasEquipo);
            this.Controls.Add(this.btnVerHistorial);
            this.Controls.Add(this.cbTorneo);
            this.Controls.Add(this.label1);
            this.Name = "FormEstadisticaEquipo";
            this.Text = "FormTablaPosiciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgEstadisticasEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgEstadisticasEquipo;
        private System.Windows.Forms.Button btnVerHistorial;
        private System.Windows.Forms.ComboBox cbTorneo;
        private System.Windows.Forms.Label label1;
    }
}