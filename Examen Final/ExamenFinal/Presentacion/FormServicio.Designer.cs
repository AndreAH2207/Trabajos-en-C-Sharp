namespace Presentacion
{
    partial class FormServicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbVehiculo = new System.Windows.Forms.ComboBox();
            this.dgServicio = new System.Windows.Forms.DataGridView();
            this.dtpFechaHoraServicio = new System.Windows.Forms.DateTimePicker();
            this.lblMecanico = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTipoServicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.cbMecanico = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa de vehiculo";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(461, 42);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Location = new System.Drawing.Point(207, 26);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(209, 21);
            this.cbVehiculo.TabIndex = 2;
            // 
            // dgServicio
            // 
            this.dgServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServicio.Location = new System.Drawing.Point(48, 185);
            this.dgServicio.Name = "dgServicio";
            this.dgServicio.Size = new System.Drawing.Size(569, 224);
            this.dgServicio.TabIndex = 4;
            // 
            // dtpFechaHoraServicio
            // 
            this.dtpFechaHoraServicio.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dtpFechaHoraServicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraServicio.Location = new System.Drawing.Point(207, 136);
            this.dtpFechaHoraServicio.Name = "dtpFechaHoraServicio";
            this.dtpFechaHoraServicio.Size = new System.Drawing.Size(209, 20);
            this.dtpFechaHoraServicio.TabIndex = 5;
            // 
            // lblMecanico
            // 
            this.lblMecanico.AutoSize = true;
            this.lblMecanico.Location = new System.Drawing.Point(135, 65);
            this.lblMecanico.Name = "lblMecanico";
            this.lblMecanico.Size = new System.Drawing.Size(54, 13);
            this.lblMecanico.TabIndex = 6;
            this.lblMecanico.Text = "Mecánico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo de Servicio";
            // 
            // tbTipoServicio
            // 
            this.tbTipoServicio.Location = new System.Drawing.Point(207, 99);
            this.tbTipoServicio.Name = "tbTipoServicio";
            this.tbTipoServicio.Size = new System.Drawing.Size(209, 20);
            this.tbTipoServicio.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de realización del servicio";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(461, 80);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(461, 120);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(555, 65);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(75, 23);
            this.btnAtender.TabIndex = 12;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(555, 102);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(75, 23);
            this.btnReportes.TabIndex = 13;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // cbMecanico
            // 
            this.cbMecanico.FormattingEnabled = true;
            this.cbMecanico.Location = new System.Drawing.Point(207, 62);
            this.cbMecanico.Name = "cbMecanico";
            this.cbMecanico.Size = new System.Drawing.Size(209, 21);
            this.cbMecanico.TabIndex = 14;
            // 
            // FormServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.cbMecanico);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTipoServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMecanico);
            this.Controls.Add(this.dtpFechaHoraServicio);
            this.Controls.Add(this.dgServicio);
            this.Controls.Add(this.cbVehiculo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Name = "FormServicio";
            this.Text = "FormServicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cbVehiculo;
        private System.Windows.Forms.DataGridView dgServicio;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraServicio;
        private System.Windows.Forms.Label lblMecanico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTipoServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.ComboBox cbMecanico;
    }
}

