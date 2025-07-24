namespace Presentacion
{
    partial class FormConcierto
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
            this.btnListarProductoras = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAsignarConciertos = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgProductora = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductora)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarProductoras
            // 
            this.btnListarProductoras.Location = new System.Drawing.Point(44, 243);
            this.btnListarProductoras.Name = "btnListarProductoras";
            this.btnListarProductoras.Size = new System.Drawing.Size(95, 23);
            this.btnListarProductoras.TabIndex = 25;
            this.btnListarProductoras.Text = "Listar Productoras";
            this.btnListarProductoras.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(161, 203);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 23);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAsignarConciertos
            // 
            this.btnAsignarConciertos.Location = new System.Drawing.Point(161, 243);
            this.btnAsignarConciertos.Name = "btnAsignarConciertos";
            this.btnAsignarConciertos.Size = new System.Drawing.Size(106, 23);
            this.btnAsignarConciertos.TabIndex = 24;
            this.btnAsignarConciertos.Text = "Asignar Conciertos";
            this.btnAsignarConciertos.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(44, 203);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(95, 23);
            this.btnRegistrar.TabIndex = 22;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // dgProductora
            // 
            this.dgProductora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductora.Location = new System.Drawing.Point(316, 50);
            this.dgProductora.Name = "dgProductora";
            this.dgProductora.Size = new System.Drawing.Size(425, 238);
            this.dgProductora.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Descripción:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(44, 66);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(249, 20);
            this.tbNombre.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(44, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // FormConcierto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 332);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnListarProductoras);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAsignarConciertos);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgProductora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Name = "FormConcierto";
            this.Text = "FormConcierto";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarProductoras;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAsignarConciertos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgProductora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}