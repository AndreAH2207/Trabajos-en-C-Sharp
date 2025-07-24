
namespace LabMultilistas
{
    partial class FormArtista
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbSeudonimo = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVerCuadros = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgArtistas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtistas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seudónimo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(92, 21);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(154, 20);
            this.tbCodigo.TabIndex = 3;
            // 
            // tbSeudonimo
            // 
            this.tbSeudonimo.Location = new System.Drawing.Point(92, 47);
            this.tbSeudonimo.Name = "tbSeudonimo";
            this.tbSeudonimo.Size = new System.Drawing.Size(154, 20);
            this.tbSeudonimo.TabIndex = 4;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(92, 73);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(154, 20);
            this.tbEdad.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(92, 113);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVerCuadros
            // 
            this.btnVerCuadros.Location = new System.Drawing.Point(92, 142);
            this.btnVerCuadros.Name = "btnVerCuadros";
            this.btnVerCuadros.Size = new System.Drawing.Size(75, 23);
            this.btnVerCuadros.TabIndex = 7;
            this.btnVerCuadros.Text = "Ver Cuadros";
            this.btnVerCuadros.UseVisualStyleBackColor = true;
            this.btnVerCuadros.Click += new System.EventHandler(this.btnVerCuadros_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(92, 171);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 8;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(92, 200);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgArtistas
            // 
            this.dgArtistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArtistas.Location = new System.Drawing.Point(284, 24);
            this.dgArtistas.Name = "dgArtistas";
            this.dgArtistas.Size = new System.Drawing.Size(475, 199);
            this.dgArtistas.TabIndex = 10;
            // 
            // FormArtista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 254);
            this.Controls.Add(this.dgArtistas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnVerCuadros);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbSeudonimo);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormArtista";
            this.Text = "Artistas";
            ((System.ComponentModel.ISupportInitialize)(this.dgArtistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbSeudonimo;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVerCuadros;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgArtistas;
    }
}