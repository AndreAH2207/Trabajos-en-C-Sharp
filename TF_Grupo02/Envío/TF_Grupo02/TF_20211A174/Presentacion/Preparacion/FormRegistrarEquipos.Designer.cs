namespace Presentacion
{
    partial class FormRegistrarEquipos
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbDireccionEquipo = new System.Windows.Forms.TextBox();
            this.tbCorreoElectronico = new System.Windows.Forms.TextBox();
            this.tbTelefonoContacto = new System.Windows.Forms.TextBox();
            this.tbNombreEquipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgEquipos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MistyRose;
            this.btnModificar.Location = new System.Drawing.Point(216, 320);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 77;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MistyRose;
            this.btnEliminar.Location = new System.Drawing.Point(216, 349);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 76;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.MistyRose;
            this.btnMostrar.Location = new System.Drawing.Point(108, 349);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 75;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.MistyRose;
            this.btnRegistrar.Location = new System.Drawing.Point(108, 320);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 74;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbDireccionEquipo
            // 
            this.tbDireccionEquipo.Location = new System.Drawing.Point(185, 282);
            this.tbDireccionEquipo.Name = "tbDireccionEquipo";
            this.tbDireccionEquipo.Size = new System.Drawing.Size(149, 20);
            this.tbDireccionEquipo.TabIndex = 70;
            // 
            // tbCorreoElectronico
            // 
            this.tbCorreoElectronico.Location = new System.Drawing.Point(185, 256);
            this.tbCorreoElectronico.Name = "tbCorreoElectronico";
            this.tbCorreoElectronico.Size = new System.Drawing.Size(149, 20);
            this.tbCorreoElectronico.TabIndex = 69;
            // 
            // tbTelefonoContacto
            // 
            this.tbTelefonoContacto.Location = new System.Drawing.Point(185, 230);
            this.tbTelefonoContacto.Name = "tbTelefonoContacto";
            this.tbTelefonoContacto.Size = new System.Drawing.Size(149, 20);
            this.tbTelefonoContacto.TabIndex = 68;
            // 
            // tbNombreEquipo
            // 
            this.tbNombreEquipo.Location = new System.Drawing.Point(185, 204);
            this.tbNombreEquipo.Name = "tbNombreEquipo";
            this.tbNombreEquipo.Size = new System.Drawing.Size(149, 20);
            this.tbNombreEquipo.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Dirección del Equipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Correo Electrónico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Telefono de Contacto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Nombre del Equipo:";
            // 
            // dgEquipos
            // 
            this.dgEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEquipos.Location = new System.Drawing.Point(377, 101);
            this.dgEquipos.Name = "dgEquipos";
            this.dgEquipos.Size = new System.Drawing.Size(533, 271);
            this.dgEquipos.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(493, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 33);
            this.label6.TabIndex = 78;
            this.label6.Text = "REGISTRO DE EQUIPOS";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MistyRose;
            this.btnSalir.Location = new System.Drawing.Point(835, 378);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 80;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.ImpactoDeportivo_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(134, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegistrarEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(935, 413);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgEquipos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbDireccionEquipo);
            this.Controls.Add(this.tbCorreoElectronico);
            this.Controls.Add(this.tbTelefonoContacto);
            this.Controls.Add(this.tbNombreEquipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormRegistrarEquipos";
            this.Text = "FormRegistrarEquipos";
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbDireccionEquipo;
        private System.Windows.Forms.TextBox tbCorreoElectronico;
        private System.Windows.Forms.TextBox tbTelefonoContacto;
        private System.Windows.Forms.TextBox tbNombreEquipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgEquipos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
    }
}