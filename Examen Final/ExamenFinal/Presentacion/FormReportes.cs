    using Negocio;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Presentacion
    {
        public partial class FormReportes : Form
        {
            private NReporte nReporte = new NReporte();
            public FormReportes()
            {
                InitializeComponent();
            }
            private void MostrarReportes(List<object> reportes)
            {
                dgReporte.DataSource = null;
                if(reportes.Count > 0)
                {
                    dgReporte.DataSource = reportes;
                }

            }

            private void btnObtenerServiciosEnRangoDeFechasPorTipoServicio_Click(object sender, EventArgs e)
            {
                if(tbTipoServicio.Text == "" || dtpFechaFin.Text == "" || dtpFechaInicio.Text == "")
                {
                    MessageBox.Show("Ingrese todos los campos"); return;
                }

                DateTime fechaFin = dtpFechaFin.Value;
                DateTime fechaInicio = dtpFechaInicio.Value;
                string tipoServicio = tbTipoServicio.Text;

                MostrarReportes(nReporte.ObtenerServiciosEnRangoDeFechasPorTipoServicio(fechaInicio, fechaFin, tipoServicio));
            }

            private void btnObtenerCantidadServiciosAtendidosPorMecanico_Click(object sender, EventArgs e)
            {
                MostrarReportes(nReporte.ObtenerCantidadServiciosAtendidosPorMecanico());
            }

            private void btnSalir_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }
