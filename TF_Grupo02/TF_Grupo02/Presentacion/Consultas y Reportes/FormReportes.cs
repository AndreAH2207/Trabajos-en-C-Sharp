using Datos;
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
        private NTorneo nTorneo = new NTorneo();
        private NReporte nReporte = new NReporte();
        public FormReportes()
        {
            InitializeComponent();
        }

        private void CargarTorneos()
        {
            cbTorneo.DataSource = nTorneo.ListarTodo();
            cbTorneo.DisplayMember = "NombreTorneo";
            cbTorneo.ValueMember = "IdTorneo";
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            dgReporte.DataSource = nReporte.TopAsistencias(idTorneo);
        }

        private void btnPromedioGoles_Click(object sender, EventArgs e)
        {
            dgReporte.DataSource = nReporte.PromedioGolesPorTorneo();

        }

        private void btnEfectividad_Click(object sender, EventArgs e)
        {
            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            dgReporte.DataSource = nReporte.RankingEfectividad(idTorneo);
        }

        private void btnDiferenciaGoles_Click(object sender, EventArgs e)
        {
            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            dgReporte.DataSource = nReporte.TopDiferenciaGoles(idTorneo);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
