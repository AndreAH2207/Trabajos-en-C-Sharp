namespace Presentacion
{
    partial class FormProductora
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRepresentante = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCantAmonestaciones = new System.Windows.Forms.TextBox();
            this.dgProductora = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAsignarConciertos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnListarProductoras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductora)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad de Amonestaciones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Representante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // tbRepresentante
            // 
            this.tbRepresentante.Location = new System.Drawing.Point(163, 107);
            this.tbRepresentante.Name = "tbRepresentante";
            this.tbRepresentante.Size = new System.Drawing.Size(157, 20);
            this.tbRepresentante.TabIndex = 7;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(163, 72);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(157, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // tbCantAmonestaciones
            // 
            this.tbCantAmonestaciones.Location = new System.Drawing.Point(163, 142);
            this.tbCantAmonestaciones.Name = "tbCantAmonestaciones";
            this.tbCantAmonestaciones.Size = new System.Drawing.Size(84, 20);
            this.tbCantAmonestaciones.TabIndex = 6;
            // 
            // dgProductora
            // 
            this.dgProductora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductora.Location = new System.Drawing.Point(346, 25);
            this.dgProductora.Name = "dgProductora";
            this.dgProductora.Size = new System.Drawing.Size(425, 238);
            this.dgProductora.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(76, 187);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(95, 23);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnAsignarConciertos
            // 
            this.btnAsignarConciertos.Location = new System.Drawing.Point(193, 227);
            this.btnAsignarConciertos.Name = "btnAsignarConciertos";
            this.btnAsignarConciertos.Size = new System.Drawing.Size(106, 23);
            this.btnAsignarConciertos.TabIndex = 13;
            this.btnAsignarConciertos.Text = "Asignar Conciertos";
            this.btnAsignarConciertos.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(193, 187);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnListarProductoras
            // 
            this.btnListarProductoras.Location = new System.Drawing.Point(76, 227);
            this.btnListarProductoras.Name = "btnListarProductoras";
            this.btnListarProductoras.Size = new System.Drawing.Size(95, 23);
            this.btnListarProductoras.TabIndex = 14;
            this.btnListarProductoras.Text = "Listar Productoras";
            this.btnListarProductoras.UseVisualStyleBackColor = true;
            // 
            // FormProductora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.btnListarProductoras);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAsignarConciertos);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgProductora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRepresentante);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCantAmonestaciones);
            this.Name = "FormProductora";
            this.Text = "FormProductora";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRepresentante;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCantAmonestaciones;
        private System.Windows.Forms.DataGridView dgProductora;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAsignarConciertos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnListarProductoras;
    }
}

