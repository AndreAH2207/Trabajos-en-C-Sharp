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
            CargarTorneos();
        }

        private void CargarTorneos()
        {
            var torneos = new NTorneo().ListarTodo()
            .Where(t => t.Estado == "Finalizado" || t.Estado == "En curso")
            .ToList();
            cbTorneo.DataSource = nTorneo.ListarTodo();
            cbTorneo.DisplayMember = "NombreTorneo";
            cbTorneo.ValueMember = "IdTorneo"; 
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            if (cbTorneo.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un torneo.");
                return;
            }

            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            dgReporte.DataSource = nReporte.TopAsistencias(idTorneo);
        }

        private void btnPromedioGoles_Click(object sender, EventArgs e)
        {
            dgReporte.DataSource = nReporte.PromedioGolesPorTorneo();
        }

        private void btnEfectividad_Click(object sender, EventArgs e)
        {
            if (cbTorneo.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un torneo.");
                return;
            }

            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            dgReporte.DataSource = nReporte.RankingEfectividad(idTorneo);
        }

        private void btnDiferenciaGoles_Click(object sender, EventArgs e)
        {
            if (cbTorneo.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un torneo.");
                return;
            }

            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            dgReporte.DataSource = nReporte.TopDiferenciaGoles(idTorneo);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbTorneo.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un torneo.");
                return;
            }

            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            dgReporte.DataSource = nReporte.PromedioFaltas(idTorneo);
        }
    }
}
