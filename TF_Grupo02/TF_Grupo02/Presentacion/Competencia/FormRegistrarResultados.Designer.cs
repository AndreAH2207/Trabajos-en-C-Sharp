namespace Presentacion
{
    partial class FormRegistrarResultados
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvResultadosRegistrados = new System.Windows.Forms.DataGridView();
            this.btnRegistarResultado = new System.Windows.Forms.Button();
            this.numGolesVisitante = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numGolesLocal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPartido = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTorneo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosRegistrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGolesVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGolesLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MistyRose;
            this.btnSalir.Location = new System.Drawing.Point(378, 436);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 176;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 33);
            this.label4.TabIndex = 175;
            this.label4.Text = "REGISTRO DE RESULTADOS";
            // 
            // dgvResultadosRegistrados
            // 
            this.dgvResultadosRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosRegistrados.Location = new System.Drawing.Point(41, 229);
            this.dgvResultadosRegistrados.Name = "dgvResultadosRegistrados";
            this.dgvResultadosRegistrados.Size = new System.Drawing.Size(412, 192);
            this.dgvResultadosRegistrados.TabIndex = 174;
            // 
            // btnRegistarResultado
            // 
            this.btnRegistarResultado.BackColor = System.Drawing.Color.MistyRose;
            this.btnRegistarResultado.Location = new System.Drawing.Point(179, 200);
            this.btnRegistarResultado.Name = "btnRegistarResultado";
            this.btnRegistarResultado.Size = new System.Drawing.Size(118, 23);
            this.btnRegistarResultado.TabIndex = 173;
            this.btnRegistarResultado.Text = "Registrar Resultado";
            this.btnRegistarResultado.UseVisualStyleBackColor = false;
            this.btnRegistarResultado.Click += new System.EventHandler(this.btnRegistarResultado_Click);
            // 
            // numGolesVisitante
            // 
            this.numGolesVisitante.Location = new System.Drawing.Point(243, 164);
            this.numGolesVisitante.Name = "numGolesVisitante";
            this.numGolesVisitante.Size = new System.Drawing.Size(120, 20);
            this.numGolesVisitante.TabIndex = 172;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 171;
            this.label3.Text = "Resultado del Equipo Visitante:";
            // 
            // numGolesLocal
            // 
            this.numGolesLocal.Location = new System.Drawing.Point(242, 138);
            this.numGolesLocal.Name = "numGolesLocal";
            this.numGolesLocal.Size = new System.Drawing.Size(120, 20);
            this.numGolesLocal.TabIndex = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 169;
            this.label2.Text = "Resultado del Equipo Local:";
            // 
            // cbPartido
            // 
            this.cbPartido.FormattingEnabled = true;
            this.cbPartido.Location = new System.Drawing.Point(242, 111);
            this.cbPartido.Name = "cbPartido";
            this.cbPartido.Size = new System.Drawing.Size(121, 21);
            this.cbPartido.TabIndex = 168;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 167;
            this.label1.Text = "Seleccionar el Partido:";
            // 
            // cbTorneo
            // 
            this.cbTorneo.FormattingEnabled = true;
            this.cbTorneo.Location = new System.Drawing.Point(242, 84);
            this.cbTorneo.Name = "cbTorneo";
            this.cbTorneo.Size = new System.Drawing.Size(121, 21);
            this.cbTorneo.TabIndex = 178;
            this.cbTorneo.SelectedIndexChanged += new System.EventHandler(this.cbTorneo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 177;
            this.label5.Text = "Seleccionar el Torneo:";
            // 
            // FormRegistrarResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(493, 479);
            this.Controls.Add(this.cbTorneo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvResultadosRegistrados);
            this.Controls.Add(this.btnRegistarResultado);
            this.Controls.Add(this.numGolesVisitante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numGolesLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPartido);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistrarResultados";
            this.Text = "FormRegistroDeResultados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosRegistrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGolesVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGolesLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvResultadosRegistrados;
        private System.Windows.Forms.Button btnRegistarResultado;
        private System.Windows.Forms.NumericUpDown numGolesVisitante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numGolesLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPartido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTorneo;
        private System.Windows.Forms.Label label5;
    }
}