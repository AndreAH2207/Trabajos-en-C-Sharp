namespace Presentacion
{
    partial class FormResumenTorneoFinalizado
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
            this.dgResumen = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgGoleadores = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubcampeon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTorneo = new System.Windows.Forms.ComboBox();
            this.btnVerResumen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCampeon = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGoleadores)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(125, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 33);
            this.label3.TabIndex = 178;
            this.label3.Text = "RESUMEN DE TORNEOS FINALIZADOS";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MistyRose;
            this.btnSalir.Location = new System.Drawing.Point(588, 407);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 177;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // dgResumen
            // 
            this.dgResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResumen.Location = new System.Drawing.Point(369, 157);
            this.dgResumen.Name = "dgResumen";
            this.dgResumen.Size = new System.Drawing.Size(294, 244);
            this.dgResumen.TabIndex = 176;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 175;
            this.label5.Text = "Resumen Estadistico";
            // 
            // dgGoleadores
            // 
            this.dgGoleadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGoleadores.Location = new System.Drawing.Point(34, 157);
            this.dgGoleadores.Name = "dgGoleadores";
            this.dgGoleadores.Size = new System.Drawing.Size(284, 244);
            this.dgGoleadores.TabIndex = 174;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 173;
            this.label4.Text = "Lista de Goleadores";
            // 
            // lblSubcampeon
            // 
            this.lblSubcampeon.AutoSize = true;
            this.lblSubcampeon.Location = new System.Drawing.Point(553, 112);
            this.lblSubcampeon.Name = "lblSubcampeon";
            this.lblSubcampeon.Size = new System.Drawing.Size(10, 13);
            this.lblSubcampeon.TabIndex = 172;
            this.lblSubcampeon.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 171;
            this.label2.Text = "Subcampeón:";
            // 
            // cbTorneo
            // 
            this.cbTorneo.FormattingEnabled = true;
            this.cbTorneo.Location = new System.Drawing.Point(91, 75);
            this.cbTorneo.Name = "cbTorneo";
            this.cbTorneo.Size = new System.Drawing.Size(121, 21);
            this.cbTorneo.TabIndex = 170;
            // 
            // btnVerResumen
            // 
            this.btnVerResumen.BackColor = System.Drawing.Color.MistyRose;
            this.btnVerResumen.Location = new System.Drawing.Point(227, 75);
            this.btnVerResumen.Name = "btnVerResumen";
            this.btnVerResumen.Size = new System.Drawing.Size(99, 23);
            this.btnVerResumen.TabIndex = 169;
            this.btnVerResumen.Text = "Ver Resumen";
            this.btnVerResumen.UseVisualStyleBackColor = false;
            this.btnVerResumen.Click += new System.EventHandler(this.btnVerResumen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 168;
            this.label1.Text = "Torneo:";
            // 
            // lblCampeon
            // 
            this.lblCampeon.AutoSize = true;
            this.lblCampeon.Location = new System.Drawing.Point(553, 85);
            this.lblCampeon.Name = "lblCampeon";
            this.lblCampeon.Size = new System.Drawing.Size(10, 13);
            this.lblCampeon.TabIndex = 180;
            this.lblCampeon.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 179;
            this.label7.Text = "Campeón:";
            // 
            // FormResumenTorneoFinalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.lblCampeon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgResumen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgGoleadores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSubcampeon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTorneo);
            this.Controls.Add(this.btnVerResumen);
            this.Controls.Add(this.label1);
            this.Name = "FormResumenTorneoFinalizado";
            this.Text = "FormResumenTorneoFinalizado";
            ((System.ComponentModel.ISupportInitialize)(this.dgResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGoleadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgResumen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgGoleadores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubcampeon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTorneo;
        private System.Windows.Forms.Button btnVerResumen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCampeon;
        private System.Windows.Forms.Label label7;
    }
}