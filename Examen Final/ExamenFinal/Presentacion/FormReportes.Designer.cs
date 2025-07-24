namespace Presentacion
{
    partial class FormReportes
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnObtenerCantidadServiciosAtendidosPorMecanico = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTipoServicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dgReporte = new System.Windows.Forms.DataGridView();
            this.btnObtenerServiciosEnRangoDeFechasPorTipoServicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(546, 403);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnObtenerCantidadServiciosAtendidosPorMecanico
            // 
            this.btnObtenerCantidadServiciosAtendidosPorMecanico.Location = new System.Drawing.Point(178, 365);
            this.btnObtenerCantidadServiciosAtendidosPorMecanico.Name = "btnObtenerCantidadServiciosAtendidosPorMecanico";
            this.btnObtenerCantidadServiciosAtendidosPorMecanico.Size = new System.Drawing.Size(322, 23);
            this.btnObtenerCantidadServiciosAtendidosPorMecanico.TabIndex = 24;
            this.btnObtenerCantidadServiciosAtendidosPorMecanico.Text = "Obtener cantidad de servicios atendidos por mecanico";
            this.btnObtenerCantidadServiciosAtendidosPorMecanico.UseVisualStyleBackColor = true;
            this.btnObtenerCantidadServiciosAtendidosPorMecanico.Click += new System.EventHandler(this.btnObtenerCantidadServiciosAtendidosPorMecanico_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha de Inicio";
            // 
            // tbTipoServicio
            // 
            this.tbTipoServicio.Location = new System.Drawing.Point(291, 28);
            this.tbTipoServicio.Name = "tbTipoServicio";
            this.tbTipoServicio.Size = new System.Drawing.Size(209, 20);
            this.tbTipoServicio.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tipo de Servicio";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(291, 54);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(209, 20);
            this.dtpFechaInicio.TabIndex = 19;
            // 
            // dgReporte
            // 
            this.dgReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporte.Location = new System.Drawing.Point(52, 135);
            this.dgReporte.Name = "dgReporte";
            this.dgReporte.Size = new System.Drawing.Size(569, 224);
            this.dgReporte.TabIndex = 18;
            // 
            // btnObtenerServiciosEnRangoDeFechasPorTipoServicio
            // 
            this.btnObtenerServiciosEnRangoDeFechasPorTipoServicio.Location = new System.Drawing.Point(194, 106);
            this.btnObtenerServiciosEnRangoDeFechasPorTipoServicio.Name = "btnObtenerServiciosEnRangoDeFechasPorTipoServicio";
            this.btnObtenerServiciosEnRangoDeFechasPorTipoServicio.Size = new System.Drawing.Size(322, 23);
            this.btnObtenerServiciosEnRangoDeFechasPorTipoServicio.TabIndex = 16;
            this.btnObtenerServiciosEnRangoDeFechasPorTipoServicio.Text = "Obtener servicios en rango de fechas por tipo de servicio";
            this.btnObtenerServiciosEnRangoDeFechasPorTipoServicio.UseVisualStyleBackColor = true;
            this.btnObtenerServiciosEnRangoDeFechasPorTipoServicio.Click += new System.EventHandler(this.btnObtenerServiciosEnRangoDeFechasPorTipoServicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fecha de fin";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(291, 80);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(209, 20);
            this.dtpFechaFin.TabIndex = 29;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnObtenerCantidadServiciosAtendidosPorMecanico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTipoServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dgReporte);
            this.Controls.Add(this.btnObtenerServiciosEnRangoDeFechasPorTipoServicio);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnObtenerCantidadServiciosAtendidosPorMecanico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTipoServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DataGridView dgReporte;
        private System.Windows.Forms.Button btnObtenerServiciosEnRangoDeFechasPorTipoServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
    }
}