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
    public partial class FormEstadisticaEquipo : Form
    {
        private NTorneo nTorneo = new NTorneo();
        private NResumenEstadisticaEquipo nResumen = new NResumenEstadisticaEquipo();

        public FormEstadisticaEquipo()
        {
            InitializeComponent();
            CargarTorneos();
        }

        private void MostrarResumen(int idTorneo)
        {
            var resumen = nResumen.ObtenerPorTorneo(idTorneo);

            dgEstadisticasEquipo.DataSource = null;
            dgEstadisticasEquipo.DataSource = resumen;

            // Nombres amigables para las columnas
            if (dgEstadisticasEquipo.Columns.Count > 0)
            {
                dgEstadisticasEquipo.Columns["Equipo"].HeaderText = "Nombre del Equipo";
                dgEstadisticasEquipo.Columns["PJ"].HeaderText = "Partidos Jugados";
                dgEstadisticasEquipo.Columns["PG"].HeaderText = "Partidos Ganados";
                dgEstadisticasEquipo.Columns["PP"].HeaderText = "Partidos Perdidos";
                dgEstadisticasEquipo.Columns["GF"].HeaderText = "Goles a Favor";
                dgEstadisticasEquipo.Columns["GC"].HeaderText = "Goles en Contra";
                dgEstadisticasEquipo.Columns["DIF"].HeaderText = "Diferencia de Goles";
            }
        }

        private void CargarTorneos()
        {
            var torneos = nTorneo.ListarTodo()
                .Where(t => t.Estado == "En curso" || t.Estado == "Finalizado")
                .ToList();

            cbTorneo.DataSource = torneos;
            cbTorneo.DisplayMember = "NombreTorneo";
            cbTorneo.ValueMember = "IdTorneo";

            if (torneos.Count > 0)
            {
                cbTorneo.SelectedIndex = 0;
                cbTorneo_SelectedIndexChanged(null, null);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            if (cbTorneo.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un torneo.");
                return;
            }

            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            MostrarResumen(idTorneo);
        }

        private void cbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTorneo.SelectedValue == null) return;

            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            MostrarResumen(idTorneo);
        }
    }
}
