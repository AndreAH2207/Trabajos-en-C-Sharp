namespace Presentacion
{
    partial class FormRegistrarJugadores
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
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tbApellidosJugador = new System.Windows.Forms.TextBox();
            this.cbEquipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNombreJugador = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgJugadores = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMostrarPorEquipo = new System.Windows.Forms.Button();
            this.cbMostrarPorEquipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MistyRose;
            this.btnModificar.Location = new System.Drawing.Point(215, 417);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 163;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MistyRose;
            this.btnEliminar.Location = new System.Drawing.Point(215, 446);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 162;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.MistyRose;
            this.btnMostrar.Location = new System.Drawing.Point(107, 446);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 161;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.MistyRose;
            this.btnRegistrar.Location = new System.Drawing.Point(107, 417);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 160;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(163, 340);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(149, 20);
            this.tbDNI.TabIndex = 159;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(163, 368);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(149, 20);
            this.dtpFechaNacimiento.TabIndex = 158;
            // 
            // tbApellidosJugador
            // 
            this.tbApellidosJugador.Location = new System.Drawing.Point(163, 314);
            this.tbApellidosJugador.Name = "tbApellidosJugador";
            this.tbApellidosJugador.Size = new System.Drawing.Size(149, 20);
            this.tbApellidosJugador.TabIndex = 155;
            // 
            // cbEquipo
            // 
            this.cbEquipo.FormattingEnabled = true;
            this.cbEquipo.Location = new System.Drawing.Point(163, 261);
            this.cbEquipo.Name = "cbEquipo";
            this.cbEquipo.Size = new System.Drawing.Size(149, 21);
            this.cbEquipo.TabIndex = 154;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 152;
            this.label6.Text = "Equipo:";
            // 
            // tbNombreJugador
            // 
            this.tbNombreJugador.Location = new System.Drawing.Point(163, 288);
            this.tbNombreJugador.Name = "tbNombreJugador";
            this.tbNombreJugador.Size = new System.Drawing.Size(149, 20);
            this.tbNombreJugador.TabIndex = 151;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 150;
            this.label9.Text = "Nombres del Jugador:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 149;
            this.label5.Text = "Apellidos del Jugador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 147;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 146;
            this.label7.Text = "DNI:";
            // 
            // dgJugadores
            // 
            this.dgJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJugadores.Location = new System.Drawing.Point(335, 124);
            this.dgJugadores.Name = "dgJugadores";
            this.dgJugadores.Size = new System.Drawing.Size(674, 316);
            this.dgJugadores.TabIndex = 164;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MistyRose;
            this.btnSalir.Location = new System.Drawing.Point(934, 462);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 165;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 33);
            this.label1.TabIndex = 166;
            this.label1.Text = "REGISTRO DE JUGADORES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Deportista;
            this.pictureBox1.Location = new System.Drawing.Point(132, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 167;
            this.pictureBox1.TabStop = false;
            // 
            // btnMostrarPorEquipo
            // 
            this.btnMostrarPorEquipo.BackColor = System.Drawing.Color.MistyRose;
            this.btnMostrarPorEquipo.Location = new System.Drawing.Point(774, 86);
            this.btnMostrarPorEquipo.Name = "btnMostrarPorEquipo";
            this.btnMostrarPorEquipo.Size = new System.Drawing.Size(185, 23);
            this.btnMostrarPorEquipo.TabIndex = 168;
            this.btnMostrarPorEquipo.Text = "Mostrar Jugadores por Equipo";
            this.btnMostrarPorEquipo.UseVisualStyleBackColor = false;
            this.btnMostrarPorEquipo.Click += new System.EventHandler(this.btnMostrarPorEquipo_Click);
            // 
            // cbMostrarPorEquipo
            // 
            this.cbMostrarPorEquipo.FormattingEnabled = true;
            this.cbMostrarPorEquipo.Location = new System.Drawing.Point(565, 88);
            this.cbMostrarPorEquipo.Name = "cbMostrarPorEquipo";
            this.cbMostrarPorEquipo.Size = new System.Drawing.Size(185, 21);
            this.cbMostrarPorEquipo.TabIndex = 169;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 170;
            this.label3.Text = "Mostrar por Equipo:";
            // 
            // FormRegistrarJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1043, 507);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMostrarPorEquipo);
            this.Controls.Add(this.btnMostrarPorEquipo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgJugadores);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.tbApellidosJugador);
            this.Controls.Add(this.cbEquipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNombreJugador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Name = "FormRegistrarJugadores";
            this.Text = "FormRegistrarJugadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox tbApellidosJugador;
        private System.Windows.Forms.ComboBox cbEquipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNombreJugador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgJugadores;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMostrarPorEquipo;
        private System.Windows.Forms.ComboBox cbMostrarPorEquipo;
        private System.Windows.Forms.Label label3;
    }
}