namespace MantenimientoDePeliculas
{
    partial class FormMantenimientoPeliculas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbValoracion = new System.Windows.Forms.TextBox();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbDuracion = new System.Windows.Forms.TextBox();
            this.tbRecaudacion = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnOrdenarDuracion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgPeliculas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Título:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valoración:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Género:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Duración:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Recaudación:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(114, 24);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(162, 20);
            this.tbCodigo.TabIndex = 7;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(114, 53);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(162, 20);
            this.tbTitulo.TabIndex = 8;
            // 
            // tbValoracion
            // 
            this.tbValoracion.Location = new System.Drawing.Point(114, 84);
            this.tbValoracion.Name = "tbValoracion";
            this.tbValoracion.Size = new System.Drawing.Size(162, 20);
            this.tbValoracion.TabIndex = 9;
            // 
            // tbGenero
            // 
            this.tbGenero.Location = new System.Drawing.Point(114, 114);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(162, 20);
            this.tbGenero.TabIndex = 10;
            // 
            // tbDuracion
            // 
            this.tbDuracion.Location = new System.Drawing.Point(114, 144);
            this.tbDuracion.Name = "tbDuracion";
            this.tbDuracion.Size = new System.Drawing.Size(162, 20);
            this.tbDuracion.TabIndex = 11;
            // 
            // tbRecaudacion
            // 
            this.tbRecaudacion.Location = new System.Drawing.Point(114, 174);
            this.tbRecaudacion.Name = "tbRecaudacion";
            this.tbRecaudacion.Size = new System.Drawing.Size(162, 20);
            this.tbRecaudacion.TabIndex = 12;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(12, 233);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(85, 35);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(12, 292);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(85, 35);
            this.btnListar.TabIndex = 14;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(114, 233);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 35);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnOrdenarDuracion
            // 
            this.btnOrdenarDuracion.Location = new System.Drawing.Point(114, 292);
            this.btnOrdenarDuracion.Name = "btnOrdenarDuracion";
            this.btnOrdenarDuracion.Size = new System.Drawing.Size(85, 35);
            this.btnOrdenarDuracion.TabIndex = 16;
            this.btnOrdenarDuracion.Text = "Ordenar por Duración";
            this.btnOrdenarDuracion.UseVisualStyleBackColor = true;
            this.btnOrdenarDuracion.Click += new System.EventHandler(this.btnOrdenarDuracion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(215, 233);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 35);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgPeliculas
            // 
            this.dgPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeliculas.Location = new System.Drawing.Point(344, 24);
            this.dgPeliculas.Name = "dgPeliculas";
            this.dgPeliculas.Size = new System.Drawing.Size(430, 303);
            this.dgPeliculas.TabIndex = 18;
            // 
            // FormMantenimientoPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.dgPeliculas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOrdenarDuracion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbRecaudacion);
            this.Controls.Add(this.tbDuracion);
            this.Controls.Add(this.tbGenero);
            this.Controls.Add(this.tbValoracion);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormMantenimientoPeliculas";
            this.Text = "Mantenimiento de Peliculas";
            ((System.ComponentModel.ISupportInitialize)(this.dgPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbValoracion;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.TextBox tbDuracion;
        private System.Windows.Forms.TextBox tbRecaudacion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnOrdenarDuracion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgPeliculas;
    }
}