namespace Lab01_Semana2_Andre_InventarioDeAnimales
{
    partial class FormMain
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbEspecie = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.lbPeso = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btbRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgAnimales = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEspecie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(104, 88);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(138, 20);
            this.tbId.TabIndex = 0;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(104, 127);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(138, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbId.Location = new System.Drawing.Point(64, 89);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(20, 16);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "Id";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNombre.Location = new System.Drawing.Point(26, 128);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(62, 16);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre";
            // 
            // lbEspecie
            // 
            this.lbEspecie.AutoSize = true;
            this.lbEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEspecie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEspecie.Location = new System.Drawing.Point(25, 168);
            this.lbEspecie.Name = "lbEspecie";
            this.lbEspecie.Size = new System.Drawing.Size(64, 16);
            this.lbEspecie.TabIndex = 4;
            this.lbEspecie.Text = "Especie";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEdad.Location = new System.Drawing.Point(42, 207);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(44, 16);
            this.lbEdad.TabIndex = 6;
            this.lbEdad.Text = "Edad";
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(104, 206);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(138, 20);
            this.tbEdad.TabIndex = 7;
            // 
            // tbPeso
            // 
            this.tbPeso.Location = new System.Drawing.Point(104, 246);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(138, 20);
            this.tbPeso.TabIndex = 8;
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPeso.Location = new System.Drawing.Point(43, 247);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(43, 16);
            this.lbPeso.TabIndex = 9;
            this.lbPeso.Text = "Peso";
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Black;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListar.Location = new System.Drawing.Point(163, 340);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(79, 33);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btbRegistrar
            // 
            this.btbRegistrar.BackColor = System.Drawing.Color.Black;
            this.btbRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbRegistrar.Location = new System.Drawing.Point(56, 298);
            this.btbRegistrar.Name = "btbRegistrar";
            this.btbRegistrar.Size = new System.Drawing.Size(77, 33);
            this.btbRegistrar.TabIndex = 10;
            this.btbRegistrar.Text = "Registrar";
            this.btbRegistrar.UseVisualStyleBackColor = false;
            this.btbRegistrar.Click += new System.EventHandler(this.btbRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(163, 298);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(79, 33);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(56, 340);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 33);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgAnimales
            // 
            this.dgAnimales.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnimales.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgAnimales.Location = new System.Drawing.Point(276, 88);
            this.dgAnimales.Name = "dgAnimales";
            this.dgAnimales.Size = new System.Drawing.Size(562, 310);
            this.dgAnimales.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(229, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(429, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sistema de Inventario de Animales de Granja";
            // 
            // tbEspecie
            // 
            this.tbEspecie.Location = new System.Drawing.Point(104, 167);
            this.tbEspecie.Name = "tbEspecie";
            this.tbEspecie.Size = new System.Drawing.Size(138, 20);
            this.tbEspecie.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgAnimales);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btbRegistrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lbPeso);
            this.Controls.Add(this.tbPeso);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.tbEspecie);
            this.Controls.Add(this.lbEspecie);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbId);
            this.Name = "FormMain";
            this.Text = "Sistema de Inventario de Animales de Granja";
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbEspecie;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btbRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgAnimales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEspecie;
    }
}

