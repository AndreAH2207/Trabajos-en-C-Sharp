namespace Presentacion {
    partial class FormPrincipal {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_rolAdministrativo = new System.Windows.Forms.Button();
            this.lbTituloMenuPrincipal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_rolUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(60, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Eliga su rol:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(60, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bienvenido!";
            // 
            // btn_rolAdministrativo
            // 
            this.btn_rolAdministrativo.BackColor = System.Drawing.Color.DarkGray;
            this.btn_rolAdministrativo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rolAdministrativo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_rolAdministrativo.Location = new System.Drawing.Point(183, 362);
            this.btn_rolAdministrativo.Name = "btn_rolAdministrativo";
            this.btn_rolAdministrativo.Size = new System.Drawing.Size(127, 39);
            this.btn_rolAdministrativo.TabIndex = 27;
            this.btn_rolAdministrativo.Text = "Administrativo";
            this.btn_rolAdministrativo.UseVisualStyleBackColor = false;
            this.btn_rolAdministrativo.Click += new System.EventHandler(this.btn_rolAdministrativo_Click);
            // 
            // lbTituloMenuPrincipal
            // 
            this.lbTituloMenuPrincipal.AutoSize = true;
            this.lbTituloMenuPrincipal.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMenuPrincipal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTituloMenuPrincipal.Location = new System.Drawing.Point(54, 28);
            this.lbTituloMenuPrincipal.Name = "lbTituloMenuPrincipal";
            this.lbTituloMenuPrincipal.Size = new System.Drawing.Size(550, 36);
            this.lbTituloMenuPrincipal.TabIndex = 26;
            this.lbTituloMenuPrincipal.Text = "Gran Biblioteca Nacional de Lima";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(60, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btn_rolUsuario
            // 
            this.btn_rolUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.btn_rolUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rolUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_rolUsuario.Location = new System.Drawing.Point(333, 362);
            this.btn_rolUsuario.Name = "btn_rolUsuario";
            this.btn_rolUsuario.Size = new System.Drawing.Size(143, 39);
            this.btn_rolUsuario.TabIndex = 24;
            this.btn_rolUsuario.Text = "Usuario";
            this.btn_rolUsuario.UseVisualStyleBackColor = false;
            this.btn_rolUsuario.Click += new System.EventHandler(this.btn_rolUsuario_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(660, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rolAdministrativo);
            this.Controls.Add(this.lbTituloMenuPrincipal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_rolUsuario);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_rolAdministrativo;
        private System.Windows.Forms.Label lbTituloMenuPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_rolUsuario;
    }
}

