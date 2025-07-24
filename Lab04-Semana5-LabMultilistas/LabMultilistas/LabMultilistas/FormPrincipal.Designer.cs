
namespace LabMultilistas
{
    partial class FormPrincipal
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
            this.btnVerArtistas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerArtistas
            // 
            this.btnVerArtistas.Location = new System.Drawing.Point(78, 41);
            this.btnVerArtistas.Name = "btnVerArtistas";
            this.btnVerArtistas.Size = new System.Drawing.Size(75, 23);
            this.btnVerArtistas.TabIndex = 0;
            this.btnVerArtistas.Text = "Ver Artistas";
            this.btnVerArtistas.UseVisualStyleBackColor = true;
            this.btnVerArtistas.Click += new System.EventHandler(this.btnVerArtistas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(78, 70);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 128);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerArtistas);
            this.Name = "FormPrincipal";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerArtistas;
        private System.Windows.Forms.Button btnSalir;
    }
}