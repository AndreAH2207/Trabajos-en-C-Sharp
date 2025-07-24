namespace Presentacion
{
    partial class FormEstadisticasJugador
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgEstadisticasJugadores = new System.Windows.Forms.DataGridView();
            this.btnVerEstadisticas = new System.Windows.Forms.Button();
            this.cbTorneo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPartido = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstadisticasJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 33);
            this.label4.TabIndex = 179;
            this.label4.Text = "ESTADÍSTICAS POR JUGADOR";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MistyRose;
            this.btnSalir.Location = new System.Drawing.Point(458, 410);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 178;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgEstadisticasJugadores
            // 
            this.dgEstadisticasJugadores.AllowUserToAddRows = false;
            this.dgEstadisticasJugadores.AllowUserToDeleteRows = false;
            this.dgEstadisticasJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEstadisticasJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstadisticasJugadores.Location = new System.Drawing.Point(63, 178);
            this.dgEstadisticasJugadores.Name = "dgEstadisticasJugadores";
            this.dgEstadisticasJugadores.Size = new System.Drawing.Size(470, 197);
            this.dgEstadisticasJugadores.TabIndex = 176;
            // 
            // btnVerEstadisticas
            // 
            this.btnVerEstadisticas.BackColor = System.Drawing.Color.MistyRose;
            this.btnVerEstadisticas.Location = new System.Drawing.Point(233, 140);
            this.btnVerEstadisticas.Name = "btnVerEstadisticas";
            this.btnVerEstadisticas.Size = new System.Drawing.Size(115, 23);
            this.btnVerEstadisticas.TabIndex = 175;
            this.btnVerEstadisticas.Text = "Ver Estadisticas";
            this.btnVerEstadisticas.UseVisualStyleBackColor = false;
            this.btnVerEstadisticas.Click += new System.EventHandler(this.btnVerEstadisticas_Click);
            // 
            // cbTorneo
            // 
            this.cbTorneo.FormattingEnabled = true;
            this.cbTorneo.Location = new System.Drawing.Point(109, 86);
            this.cbTorneo.Name = "cbTorneo";
            this.cbTorneo.Size = new System.Drawing.Size(121, 21);
            this.cbTorneo.TabIndex = 173;
            this.cbTorneo.SelectedIndexChanged += new System.EventHandler(this.cbTorneo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 171;
            this.label1.Text = "Torneo:";
            // 
            // cbPartido
            // 
            this.cbPartido.FormattingEnabled = true;
            this.cbPartido.Location = new System.Drawing.Point(109, 113);
            this.cbPartido.Name = "cbPartido";
            this.cbPartido.Size = new System.Drawing.Size(424, 21);
            this.cbPartido.TabIndex = 181;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 180;
            this.label2.Text = "Partido:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MistyRose;
            this.btnGuardar.Location = new System.Drawing.Point(233, 390);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 23);
            this.btnGuardar.TabIndex = 182;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormEstadisticasJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(572, 448);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbPartido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgEstadisticasJugadores);
            this.Controls.Add(this.btnVerEstadisticas);
            this.Controls.Add(this.cbTorneo);
            this.Controls.Add(this.label1);
            this.Name = "FormEstadisticasJugador";
            this.Text = "FormEstadisticasIndividuales";
            ((System.ComponentModel.ISupportInitialize)(this.dgEstadisticasJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgEstadisticasJugadores;
        private System.Windows.Forms.Button btnVerEstadisticas;
        private System.Windows.Forms.ComboBox cbTorneo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPartido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
    }
}