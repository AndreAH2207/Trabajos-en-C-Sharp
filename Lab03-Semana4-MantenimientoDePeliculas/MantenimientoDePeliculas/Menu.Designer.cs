namespace MantenimientoDePeliculas
{
    partial class FormMenu
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
            this.btnCines = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCines
            // 
            this.btnCines.Location = new System.Drawing.Point(72, 98);
            this.btnCines.Name = "btnCines";
            this.btnCines.Size = new System.Drawing.Size(99, 38);
            this.btnCines.TabIndex = 0;
            this.btnCines.Text = "Ver Cines";
            this.btnCines.UseVisualStyleBackColor = true;
            this.btnCines.Click += new System.EventHandler(this.btnCines_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(292, 98);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 38);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(478, 251);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCines);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCines;
        private System.Windows.Forms.Button btnSalir;
    }
}