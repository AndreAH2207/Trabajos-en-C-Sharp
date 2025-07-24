namespace Presentacion
{
    partial class FormReportes
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
            this.dgReporte = new System.Windows.Forms.DataGridView();
            this.btnDiferenciaGoles = new System.Windows.Forms.Button();
            this.cbTorneo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsistencias = new System.Windows.Forms.Button();
            this.btnPromedioGoles = new System.Windows.Forms.Button();
            this.btnEfectividad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporte)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(168, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 176;
            this.label3.Text = "REPORTES";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MistyRose;
            this.btnSalir.Location = new System.Drawing.Point(404, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 175;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgReporte
            // 
            this.dgReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporte.Location = new System.Drawing.Point(72, 227);
            this.dgReporte.Name = "dgReporte";
            this.dgReporte.Size = new System.Drawing.Size(360, 182);
            this.dgReporte.TabIndex = 174;
            // 
            // btnDiferenciaGoles
            // 
            this.btnDiferenciaGoles.BackColor = System.Drawing.Color.MistyRose;
            this.btnDiferenciaGoles.Location = new System.Drawing.Point(124, 103);
            this.btnDiferenciaGoles.Name = "btnDiferenciaGoles";
            this.btnDiferenciaGoles.Size = new System.Drawing.Size(227, 23);
            this.btnDiferenciaGoles.TabIndex = 173;
            this.btnDiferenciaGoles.Text = "Top 5 Equipos con mejor diferencia de goles";
            this.btnDiferenciaGoles.UseVisualStyleBackColor = false;
            this.btnDiferenciaGoles.Click += new System.EventHandler(this.btnDiferenciaGoles_Click);
            // 
            // cbTorneo
            // 
            this.cbTorneo.FormattingEnabled = true;
            this.cbTorneo.Location = new System.Drawing.Point(190, 65);
            this.cbTorneo.Name = "cbTorneo";
            this.cbTorneo.Size = new System.Drawing.Size(121, 21);
            this.cbTorneo.TabIndex = 172;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 170;
            this.label2.Text = "Torneo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAsistencias
            // 
            this.btnAsistencias.BackColor = System.Drawing.Color.MistyRose;
            this.btnAsistencias.Location = new System.Drawing.Point(124, 132);
            this.btnAsistencias.Name = "btnAsistencias";
            this.btnAsistencias.Size = new System.Drawing.Size(227, 23);
            this.btnAsistencias.TabIndex = 177;
            this.btnAsistencias.Text = "Jugadores con más asistencias";
            this.btnAsistencias.UseVisualStyleBackColor = false;
            this.btnAsistencias.Click += new System.EventHandler(this.btnAsistencias_Click);
            // 
            // btnPromedioGoles
            // 
            this.btnPromedioGoles.BackColor = System.Drawing.Color.MistyRose;
            this.btnPromedioGoles.Location = new System.Drawing.Point(124, 161);
            this.btnPromedioGoles.Name = "btnPromedioGoles";
            this.btnPromedioGoles.Size = new System.Drawing.Size(227, 23);
            this.btnPromedioGoles.TabIndex = 178;
            this.btnPromedioGoles.Text = "Promedio de goles por partido por torneo";
            this.btnPromedioGoles.UseVisualStyleBackColor = false;
            this.btnPromedioGoles.Click += new System.EventHandler(this.btnPromedioGoles_Click);
            // 
            // btnEfectividad
            // 
            this.btnEfectividad.BackColor = System.Drawing.Color.MistyRose;
            this.btnEfectividad.Location = new System.Drawing.Point(124, 190);
            this.btnEfectividad.Name = "btnEfectividad";
            this.btnEfectividad.Size = new System.Drawing.Size(227, 23);
            this.btnEfectividad.TabIndex = 179;
            this.btnEfectividad.Text = "Ranking de equipos por efectividad (%)";
            this.btnEfectividad.UseVisualStyleBackColor = false;
            this.btnEfectividad.Click += new System.EventHandler(this.btnEfectividad_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.btnEfectividad);
            this.Controls.Add(this.btnPromedioGoles);
            this.Controls.Add(this.btnAsistencias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgReporte);
            this.Controls.Add(this.btnDiferenciaGoles);
            this.Controls.Add(this.cbTorneo);
            this.Controls.Add(this.label2);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgReporte;
        private System.Windows.Forms.Button btnDiferenciaGoles;
        private System.Windows.Forms.ComboBox cbTorneo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsistencias;
        private System.Windows.Forms.Button btnPromedioGoles;
        private System.Windows.Forms.Button btnEfectividad;
    }
}