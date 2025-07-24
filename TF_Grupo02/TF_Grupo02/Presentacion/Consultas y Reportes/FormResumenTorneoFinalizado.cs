using Negocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormResumenTorneoFinalizado : Form
    {
        private NTorneo nTorneo = new NTorneo();
        private NPartido nPartido = new NPartido();
        private NResumenEstadisticaEquipo nResumen = new NResumenEstadisticaEquipo();
        private NEstadisticaJugador nEstadistica = new NEstadisticaJugador();

        public FormResumenTorneoFinalizado()
        {
            InitializeComponent();
            CargarTorneosFinalizados();
        }

        private void CargarTorneosFinalizados()
        {
            var torneos = nTorneo.ListarTodo()
                .Where(t => t.Estado == "Finalizado")
                .ToList();

            cbTorneo.DataSource = torneos;
            cbTorneo.DisplayMember = "NombreTorneo";
            cbTorneo.ValueMember = "IdTorneo";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerResumen_Click(object sender, EventArgs e)
        {
            if (cbTorneo.SelectedItem == null) return;

            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);

            // Campeón y Subcampeón
            var (campeon, subcampeon) = nPartido.ObtenerFinalistas(idTorneo);
            lblCampeon.Text = campeon;
            lblSubcampeon.Text = subcampeon;

            // Tabla de posiciones
            dgResumen.DataSource = null;
            dgResumen.DataSource = nResumen.ObtenerPorTorneo(idTorneo);

            // Top goleadores
            dgGoleadores.DataSource = null;
            dgGoleadores.DataSource = nEstadistica.ObtenerTopGoleadores(idTorneo);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
