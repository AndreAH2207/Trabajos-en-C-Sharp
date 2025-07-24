namespace Presentacion
{
    partial class FormSupermercado
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
            this.tbNombreReferencail = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.dgSupermercado = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscarNombreReferencail = new System.Windows.Forms.Button();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupermercado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Referencial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección:";
            // 
            // tbNombreReferencail
            // 
            this.tbNombreReferencail.Location = new System.Drawing.Point(129, 49);
            this.tbNombreReferencail.Name = "tbNombreReferencail";
            this.tbNombreReferencail.Size = new System.Drawing.Size(167, 20);
            this.tbNombreReferencail.TabIndex = 2;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(129, 85);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(167, 20);
            this.tbDireccion.TabIndex = 3;
            // 
            // dgSupermercado
            // 
            this.dgSupermercado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupermercado.Location = new System.Drawing.Point(317, 18);
            this.dgSupermercado.Name = "dgSupermercado";
            this.dgSupermercado.Size = new System.Drawing.Size(436, 239);
            this.dgSupermercado.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(22, 145);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(122, 145);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(221, 145);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscarNombreReferencail
            // 
            this.btnBuscarNombreReferencail.Location = new System.Drawing.Point(22, 185);
            this.btnBuscarNombreReferencail.Name = "btnBuscarNombreReferencail";
            this.btnBuscarNombreReferencail.Size = new System.Drawing.Size(175, 23);
            this.btnBuscarNombreReferencail.TabIndex = 8;
            this.btnBuscarNombreReferencail.Text = "Buscar por Nombre Referencial";
            this.btnBuscarNombreReferencail.UseVisualStyleBackColor = true;
            this.btnBuscarNombreReferencail.Click += new System.EventHandler(this.btnBuscarNombreReferencail_Click);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Location = new System.Drawing.Point(103, 223);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(105, 23);
            this.btnVerProductos.TabIndex = 9;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(22, 223);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormSupermercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 284);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerProductos);
            this.Controls.Add(this.btnBuscarNombreReferencail);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgSupermercado);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbNombreReferencail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSupermercado";
            this.Text = "Supermercado";
            ((System.ComponentModel.ISupportInitialize)(this.dgSupermercado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombreReferencail;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.DataGridView dgSupermercado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscarNombreReferencail;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.Button btnSalir;
    }
}