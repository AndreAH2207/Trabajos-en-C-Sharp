namespace Presentacion
{
    partial class FormProductoxSupermercado
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
            this.cbidProducto = new System.Windows.Forms.ComboBox();
            this.cbidSupermercado = new System.Windows.Forms.ComboBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgProductoxSupermercado = new System.Windows.Forms.DataGridView();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductoxSupermercado)).BeginInit();
            this.SuspendLayout();
            // 
            // cbidProducto
            // 
            this.cbidProducto.FormattingEnabled = true;
            this.cbidProducto.Location = new System.Drawing.Point(185, 53);
            this.cbidProducto.Name = "cbidProducto";
            this.cbidProducto.Size = new System.Drawing.Size(121, 21);
            this.cbidProducto.TabIndex = 0;
            // 
            // cbidSupermercado
            // 
            this.cbidSupermercado.FormattingEnabled = true;
            this.cbidSupermercado.Location = new System.Drawing.Point(185, 89);
            this.cbidSupermercado.Name = "cbidSupermercado";
            this.cbidSupermercado.Size = new System.Drawing.Size(121, 21);
            this.cbidSupermercado.TabIndex = 1;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(185, 124);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(121, 20);
            this.tbStock.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Identificador de Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Identificador de Supermercado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock:";
            // 
            // dgProductoxSupermercado
            // 
            this.dgProductoxSupermercado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductoxSupermercado.Location = new System.Drawing.Point(323, 15);
            this.dgProductoxSupermercado.Name = "dgProductoxSupermercado";
            this.dgProductoxSupermercado.Size = new System.Drawing.Size(384, 247);
            this.dgProductoxSupermercado.TabIndex = 6;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(66, 189);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 7;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.Location = new System.Drawing.Point(172, 189);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(75, 23);
            this.btnDesasignar.TabIndex = 8;
            this.btnDesasignar.Text = "Desasignar";
            this.btnDesasignar.UseVisualStyleBackColor = true;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(66, 232);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(172, 232);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormProductoxSupermercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 305);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnDesasignar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.dgProductoxSupermercado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.cbidSupermercado);
            this.Controls.Add(this.cbidProducto);
            this.Name = "FormProductoxSupermercado";
            this.Text = "ProductoxSupermercado";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductoxSupermercado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbidProducto;
        private System.Windows.Forms.ComboBox cbidSupermercado;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgProductoxSupermercado;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnDesasignar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnSalir;
    }
}