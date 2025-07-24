namespace Presentacion.FormsParaAdministrativos {
    partial class FormVerEstadoDePrestamos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_nombreEnSesion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.dtimepicker_fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtimepicker_fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbTituloRegistroDeUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombreEnSesion
            // 
            this.lbl_nombreEnSesion.AutoSize = true;
            this.lbl_nombreEnSesion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreEnSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nombreEnSesion.Location = new System.Drawing.Point(20, 9);
            this.lbl_nombreEnSesion.Name = "lbl_nombreEnSesion";
            this.lbl_nombreEnSesion.Size = new System.Drawing.Size(204, 16);
            this.lbl_nombreEnSesion.TabIndex = 68;
            this.lbl_nombreEnSesion.Text = "*Nombre del usuario en sesión*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(233, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 66;
            this.label2.Text = "Estado";
            // 
            // cb_estado
            // 
            this.cb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Prestado",
            "Entregado"});
            this.cb_estado.Location = new System.Drawing.Point(314, 163);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(200, 21);
            this.cb_estado.TabIndex = 65;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(411, 198);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 27);
            this.btnBuscar.TabIndex = 64;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(124, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "Rango (fecha final)";
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNombreUsuario.Location = new System.Drawing.Point(115, 77);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(178, 23);
            this.lbNombreUsuario.TabIndex = 62;
            this.lbNombreUsuario.Text = "Rango (fecha inicio)";
            // 
            // dtimepicker_fechaFinal
            // 
            this.dtimepicker_fechaFinal.Location = new System.Drawing.Point(314, 125);
            this.dtimepicker_fechaFinal.Name = "dtimepicker_fechaFinal";
            this.dtimepicker_fechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtimepicker_fechaFinal.TabIndex = 61;
            // 
            // dtimepicker_fechaInicio
            // 
            this.dtimepicker_fechaInicio.Location = new System.Drawing.Point(314, 78);
            this.dtimepicker_fechaInicio.Name = "dtimepicker_fechaInicio";
            this.dtimepicker_fechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtimepicker_fechaInicio.TabIndex = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(503, 181);
            this.dataGridView1.TabIndex = 59;
            // 
            // lbTituloRegistroDeUsuario
            // 
            this.lbTituloRegistroDeUsuario.AutoSize = true;
            this.lbTituloRegistroDeUsuario.Font = new System.Drawing.Font("Cooper Black", 24F);
            this.lbTituloRegistroDeUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTituloRegistroDeUsuario.Location = new System.Drawing.Point(243, 23);
            this.lbTituloRegistroDeUsuario.Name = "lbTituloRegistroDeUsuario";
            this.lbTituloRegistroDeUsuario.Size = new System.Drawing.Size(184, 36);
            this.lbTituloRegistroDeUsuario.TabIndex = 58;
            this.lbTituloRegistroDeUsuario.Text = "Prestamos";
            // 
            // FormVerEstadoDePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(670, 472);
            this.Controls.Add(this.lbl_nombreEnSesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNombreUsuario);
            this.Controls.Add(this.dtimepicker_fechaFinal);
            this.Controls.Add(this.dtimepicker_fechaInicio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbTituloRegistroDeUsuario);
            this.Name = "FormVerEstadoDePrestamos";
            this.Text = "FormVerEstadoDePrestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombreEnSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.DateTimePicker dtimepicker_fechaFinal;
        private System.Windows.Forms.DateTimePicker dtimepicker_fechaInicio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbTituloRegistroDeUsuario;
    }
}