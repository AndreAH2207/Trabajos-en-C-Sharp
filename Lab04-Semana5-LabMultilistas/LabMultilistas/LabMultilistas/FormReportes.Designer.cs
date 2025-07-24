namespace LabMultilistas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ReportesArtistas = new System.Windows.Forms.TabPage();
            this.dgReporteArtistas = new System.Windows.Forms.DataGridView();
            this.btnListarArtistasConMasCuadrosDeTipoDiferenteANormal = new System.Windows.Forms.Button();
            this.btnListarArtistasConCuadrosMasBaratos = new System.Windows.Forms.Button();
            this.btnListarArtistasConMasCuadrosEnCategoria = new System.Windows.Forms.Button();
            this.tbReporteArtistas = new System.Windows.Forms.TextBox();
            this.ReportesCuadros = new System.Windows.Forms.TabPage();
            this.dgReporteCuadros = new System.Windows.Forms.DataGridView();
            this.btnBuscarCuadrosArtistasMenosJovenes = new System.Windows.Forms.Button();
            this.btnBuscarCuadrosPorTitulo = new System.Windows.Forms.Button();
            this.tbTituloCuadros = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.ReportesArtistas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteArtistas)).BeginInit();
            this.ReportesCuadros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteCuadros)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ReportesArtistas);
            this.tabControl1.Controls.Add(this.ReportesCuadros);
            this.tabControl1.Location = new System.Drawing.Point(28, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 365);
            this.tabControl1.TabIndex = 0;
            // 
            // ReportesArtistas
            // 
            this.ReportesArtistas.Controls.Add(this.dgReporteArtistas);
            this.ReportesArtistas.Controls.Add(this.btnListarArtistasConMasCuadrosDeTipoDiferenteANormal);
            this.ReportesArtistas.Controls.Add(this.btnListarArtistasConCuadrosMasBaratos);
            this.ReportesArtistas.Controls.Add(this.btnListarArtistasConMasCuadrosEnCategoria);
            this.ReportesArtistas.Controls.Add(this.tbReporteArtistas);
            this.ReportesArtistas.Location = new System.Drawing.Point(4, 22);
            this.ReportesArtistas.Name = "ReportesArtistas";
            this.ReportesArtistas.Padding = new System.Windows.Forms.Padding(3);
            this.ReportesArtistas.Size = new System.Drawing.Size(667, 339);
            this.ReportesArtistas.TabIndex = 0;
            this.ReportesArtistas.Text = "Reporte de Artistas";
            this.ReportesArtistas.UseVisualStyleBackColor = true;
            // 
            // dgReporteArtistas
            // 
            this.dgReporteArtistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporteArtistas.Location = new System.Drawing.Point(246, 28);
            this.dgReporteArtistas.Name = "dgReporteArtistas";
            this.dgReporteArtistas.Size = new System.Drawing.Size(401, 276);
            this.dgReporteArtistas.TabIndex = 4;
            // 
            // btnListarArtistasConMasCuadrosDeTipoDiferenteANormal
            // 
            this.btnListarArtistasConMasCuadrosDeTipoDiferenteANormal.Location = new System.Drawing.Point(24, 193);
            this.btnListarArtistasConMasCuadrosDeTipoDiferenteANormal.Name = "btnListarArtistasConMasCuadrosDeTipoDiferenteANormal";
            this.btnListarArtistasConMasCuadrosDeTipoDiferenteANormal.Size = new System.Drawing.Size(206, 35);
            this.btnListarArtistasConMasCuadrosDeTipoDiferenteANormal.TabIndex = 3;
            this.btnListarArtistasConMasCuadrosDeTipoDiferenteANormal.Text = "Listar los artistas con más cuadros de tipo diferente a Normal.";
            this.btnListarArtistasConMasCuadrosDeTipoDiferenteANormal.UseVisualStyleBackColor = true;
            this.btnListarArtistasConMasCuadrosDeTipoDiferenteANormal.Click += new System.EventHandler(this.btnListarArtistasConMasCuadrosDeTipoDiferenteANormal_Click);
            // 
            // btnListarArtistasConCuadrosMasBaratos
            // 
            this.btnListarArtistasConCuadrosMasBaratos.Location = new System.Drawing.Point(24, 154);
            this.btnListarArtistasConCuadrosMasBaratos.Name = "btnListarArtistasConCuadrosMasBaratos";
            this.btnListarArtistasConCuadrosMasBaratos.Size = new System.Drawing.Size(206, 33);
            this.btnListarArtistasConCuadrosMasBaratos.TabIndex = 2;
            this.btnListarArtistasConCuadrosMasBaratos.Text = "Listar Artistas con Cuadros más Baratos";
            this.btnListarArtistasConCuadrosMasBaratos.UseVisualStyleBackColor = true;
            this.btnListarArtistasConCuadrosMasBaratos.Click += new System.EventHandler(this.btnListarArtistasConCuadrosMasBaratos_Click);
            // 
            // btnListarArtistasConMasCuadrosEnCategoria
            // 
            this.btnListarArtistasConMasCuadrosEnCategoria.Location = new System.Drawing.Point(24, 91);
            this.btnListarArtistasConMasCuadrosEnCategoria.Name = "btnListarArtistasConMasCuadrosEnCategoria";
            this.btnListarArtistasConMasCuadrosEnCategoria.Size = new System.Drawing.Size(206, 35);
            this.btnListarArtistasConMasCuadrosEnCategoria.TabIndex = 1;
            this.btnListarArtistasConMasCuadrosEnCategoria.Text = "Listar artistas con más cuadros en una categoría específica.";
            this.btnListarArtistasConMasCuadrosEnCategoria.UseVisualStyleBackColor = true;
            this.btnListarArtistasConMasCuadrosEnCategoria.Click += new System.EventHandler(this.btnListarArtistasConMasCuadrosEnCategoria_Click);
            // 
            // tbReporteArtistas
            // 
            this.tbReporteArtistas.Location = new System.Drawing.Point(24, 65);
            this.tbReporteArtistas.Name = "tbReporteArtistas";
            this.tbReporteArtistas.Size = new System.Drawing.Size(206, 20);
            this.tbReporteArtistas.TabIndex = 0;
            // 
            // ReportesCuadros
            // 
            this.ReportesCuadros.Controls.Add(this.dgReporteCuadros);
            this.ReportesCuadros.Controls.Add(this.btnBuscarCuadrosArtistasMenosJovenes);
            this.ReportesCuadros.Controls.Add(this.btnBuscarCuadrosPorTitulo);
            this.ReportesCuadros.Controls.Add(this.tbTituloCuadros);
            this.ReportesCuadros.Location = new System.Drawing.Point(4, 22);
            this.ReportesCuadros.Name = "ReportesCuadros";
            this.ReportesCuadros.Padding = new System.Windows.Forms.Padding(3);
            this.ReportesCuadros.Size = new System.Drawing.Size(667, 339);
            this.ReportesCuadros.TabIndex = 1;
            this.ReportesCuadros.Text = "Reporte de Cuadros";
            this.ReportesCuadros.UseVisualStyleBackColor = true;
            // 
            // dgReporteCuadros
            // 
            this.dgReporteCuadros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporteCuadros.Location = new System.Drawing.Point(244, 31);
            this.dgReporteCuadros.Name = "dgReporteCuadros";
            this.dgReporteCuadros.Size = new System.Drawing.Size(401, 276);
            this.dgReporteCuadros.TabIndex = 9;
            // 
            // btnBuscarCuadrosArtistasMenosJovenes
            // 
            this.btnBuscarCuadrosArtistasMenosJovenes.Location = new System.Drawing.Point(22, 215);
            this.btnBuscarCuadrosArtistasMenosJovenes.Name = "btnBuscarCuadrosArtistasMenosJovenes";
            this.btnBuscarCuadrosArtistasMenosJovenes.Size = new System.Drawing.Size(206, 38);
            this.btnBuscarCuadrosArtistasMenosJovenes.TabIndex = 7;
            this.btnBuscarCuadrosArtistasMenosJovenes.Text = "Buscar los cuadros de los artistas menos jóvenes.";
            this.btnBuscarCuadrosArtistasMenosJovenes.UseVisualStyleBackColor = true;
            this.btnBuscarCuadrosArtistasMenosJovenes.Click += new System.EventHandler(this.btnBuscarCuadrosArtistasMenosJovenes_Click);
            // 
            // btnBuscarCuadrosPorTitulo
            // 
            this.btnBuscarCuadrosPorTitulo.Location = new System.Drawing.Point(22, 124);
            this.btnBuscarCuadrosPorTitulo.Name = "btnBuscarCuadrosPorTitulo";
            this.btnBuscarCuadrosPorTitulo.Size = new System.Drawing.Size(206, 21);
            this.btnBuscarCuadrosPorTitulo.TabIndex = 6;
            this.btnBuscarCuadrosPorTitulo.Text = "Buscar cuadros por título";
            this.btnBuscarCuadrosPorTitulo.UseVisualStyleBackColor = true;
            this.btnBuscarCuadrosPorTitulo.Click += new System.EventHandler(this.btnBuscarCuadrosPorTitulo_Click);
            // 
            // tbTituloCuadros
            // 
            this.tbTituloCuadros.Location = new System.Drawing.Point(22, 98);
            this.tbTituloCuadros.Name = "tbTituloCuadros";
            this.tbTituloCuadros.Size = new System.Drawing.Size(206, 20);
            this.tbTituloCuadros.TabIndex = 5;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 389);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormReportes";
            this.Text = "FormResportes";
            this.tabControl1.ResumeLayout(false);
            this.ReportesArtistas.ResumeLayout(false);
            this.ReportesArtistas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteArtistas)).EndInit();
            this.ReportesCuadros.ResumeLayout(false);
            this.ReportesCuadros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteCuadros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ReportesArtistas;
        private System.Windows.Forms.TabPage ReportesCuadros;
        private System.Windows.Forms.DataGridView dgReporteArtistas;
        private System.Windows.Forms.Button btnListarArtistasConMasCuadrosDeTipoDiferenteANormal;
        private System.Windows.Forms.Button btnListarArtistasConCuadrosMasBaratos;
        private System.Windows.Forms.Button btnListarArtistasConMasCuadrosEnCategoria;
        private System.Windows.Forms.TextBox tbReporteArtistas;
        private System.Windows.Forms.DataGridView dgReporteCuadros;
        private System.Windows.Forms.Button btnBuscarCuadrosArtistasMenosJovenes;
        private System.Windows.Forms.Button btnBuscarCuadrosPorTitulo;
        private System.Windows.Forms.TextBox tbTituloCuadros;
    }
}