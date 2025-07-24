namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnSupermercado = new System.Windows.Forms.Button();
            this.btnAsignacion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(110, 54);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(110, 23);
            this.btnProducto.TabIndex = 0;
            this.btnProducto.Text = "Ver Producto";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnSupermercado
            // 
            this.btnSupermercado.Location = new System.Drawing.Point(110, 93);
            this.btnSupermercado.Name = "btnSupermercado";
            this.btnSupermercado.Size = new System.Drawing.Size(110, 23);
            this.btnSupermercado.TabIndex = 1;
            this.btnSupermercado.Text = "Ver Supermercado";
            this.btnSupermercado.UseVisualStyleBackColor = true;
            this.btnSupermercado.Click += new System.EventHandler(this.btnSupermercado_Click);
            // 
            // btnAsignacion
            // 
            this.btnAsignacion.Location = new System.Drawing.Point(110, 132);
            this.btnAsignacion.Name = "btnAsignacion";
            this.btnAsignacion.Size = new System.Drawing.Size(110, 23);
            this.btnAsignacion.TabIndex = 2;
            this.btnAsignacion.Text = "Asignación";
            this.btnAsignacion.UseVisualStyleBackColor = true;
            this.btnAsignacion.Click += new System.EventHandler(this.btnAsignacion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(110, 172);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 256);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsignacion);
            this.Controls.Add(this.btnSupermercado);
            this.Controls.Add(this.btnProducto);
            this.Name = "FormPrincipal";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnSupermercado;
        private System.Windows.Forms.Button btnAsignacion;
        private System.Windows.Forms.Button btnSalir;
    }
}

