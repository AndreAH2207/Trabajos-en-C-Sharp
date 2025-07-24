namespace Presentacion
{
    partial class FormMantenimientoDeEmpleados
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
            this.tbNombreCompleto = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.tbSueldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnListarEmpleados = new System.Windows.Forms.Button();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.btnOrdenarSegunFechaNacimiento = new System.Windows.Forms.Button();
            this.btnBuscarPorArea = new System.Windows.Forms.Button();
            this.cbBuscarPorArea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombreCompleto
            // 
            this.tbNombreCompleto.Location = new System.Drawing.Point(146, 89);
            this.tbNombreCompleto.Name = "tbNombreCompleto";
            this.tbNombreCompleto.Size = new System.Drawing.Size(231, 20);
            this.tbNombreCompleto.TabIndex = 0;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(540, 88);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(180, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Items.AddRange(new object[] {
            "Administración",
            "Ingeniería",
            "Finanzas"});
            this.cbArea.Location = new System.Drawing.Point(146, 122);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(121, 21);
            this.cbArea.TabIndex = 2;
            // 
            // tbSueldo
            // 
            this.tbSueldo.Location = new System.Drawing.Point(540, 126);
            this.tbSueldo.Name = "tbSueldo";
            this.tbSueldo.Size = new System.Drawing.Size(116, 20);
            this.tbSueldo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistema de Mantenimiento de Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre Completo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de Nacimiento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Área";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(480, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sueldo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgEmpleados.Location = new System.Drawing.Point(308, 173);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.Size = new System.Drawing.Size(441, 241);
            this.dgEmpleados.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(44, 176);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(201, 29);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnListarEmpleados
            // 
            this.btnListarEmpleados.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnListarEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListarEmpleados.Location = new System.Drawing.Point(44, 246);
            this.btnListarEmpleados.Name = "btnListarEmpleados";
            this.btnListarEmpleados.Size = new System.Drawing.Size(201, 29);
            this.btnListarEmpleados.TabIndex = 11;
            this.btnListarEmpleados.Text = "Listar Empleados";
            this.btnListarEmpleados.UseVisualStyleBackColor = false;
            this.btnListarEmpleados.Click += new System.EventHandler(this.btnListarEmpleados_Click);
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminarLogico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarLogico.Location = new System.Drawing.Point(44, 211);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(201, 29);
            this.btnEliminarLogico.TabIndex = 12;
            this.btnEliminarLogico.Text = "Eliminar Lógico";
            this.btnEliminarLogico.UseVisualStyleBackColor = false;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // btnOrdenarSegunFechaNacimiento
            // 
            this.btnOrdenarSegunFechaNacimiento.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnOrdenarSegunFechaNacimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrdenarSegunFechaNacimiento.Location = new System.Drawing.Point(44, 323);
            this.btnOrdenarSegunFechaNacimiento.Name = "btnOrdenarSegunFechaNacimiento";
            this.btnOrdenarSegunFechaNacimiento.Size = new System.Drawing.Size(201, 29);
            this.btnOrdenarSegunFechaNacimiento.TabIndex = 13;
            this.btnOrdenarSegunFechaNacimiento.Text = "Ordenar según Fecha de Nacimiento";
            this.btnOrdenarSegunFechaNacimiento.UseVisualStyleBackColor = false;
            this.btnOrdenarSegunFechaNacimiento.Click += new System.EventHandler(this.btnOrdenarSegunFechaNacimiento_Click);
            // 
            // btnBuscarPorArea
            // 
            this.btnBuscarPorArea.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscarPorArea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarPorArea.Location = new System.Drawing.Point(44, 385);
            this.btnBuscarPorArea.Name = "btnBuscarPorArea";
            this.btnBuscarPorArea.Size = new System.Drawing.Size(201, 29);
            this.btnBuscarPorArea.TabIndex = 14;
            this.btnBuscarPorArea.Text = "Buscar por Área";
            this.btnBuscarPorArea.UseVisualStyleBackColor = false;
            this.btnBuscarPorArea.Click += new System.EventHandler(this.btnBuscarPorArea_Click);
            // 
            // cbBuscarPorArea
            // 
            this.cbBuscarPorArea.FormattingEnabled = true;
            this.cbBuscarPorArea.Items.AddRange(new object[] {
            "Administración",
            "Ingeniería",
            "Finanzas"});
            this.cbBuscarPorArea.Location = new System.Drawing.Point(44, 358);
            this.cbBuscarPorArea.Name = "cbBuscarPorArea";
            this.cbBuscarPorArea.Size = new System.Drawing.Size(201, 21);
            this.cbBuscarPorArea.TabIndex = 15;
            // 
            // FormMantenimientoDeEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbBuscarPorArea);
            this.Controls.Add(this.btnBuscarPorArea);
            this.Controls.Add(this.btnOrdenarSegunFechaNacimiento);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.btnListarEmpleados);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSueldo);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.tbNombreCompleto);
            this.Name = "FormMantenimientoDeEmpleados";
            this.Text = "Sistema de Mantenimiento de Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombreCompleto;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.TextBox tbSueldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnListarEmpleados;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.Button btnOrdenarSegunFechaNacimiento;
        private System.Windows.Forms.Button btnBuscarPorArea;
        private System.Windows.Forms.ComboBox cbBuscarPorArea;
    }
}

