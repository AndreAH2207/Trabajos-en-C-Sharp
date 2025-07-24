using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormResumenTorneo : Form
    {
        private NTorneo nTorneo = new NTorneo();
        private NPartido nPartido = new NPartido();
        private NReporte nReporte = new NReporte();
        private DResultado dResultado = new DResultado();

        public FormResumenTorneo()
        {
            InitializeComponent();
            CargarTorneosDisponibles();
        }

        private void CargarTorneosDisponibles()
        {
            var torneos = nTorneo.ListarTodo()
                .Where(t => t.Estado == "Finalizado" || t.Estado == "En curso")
                .ToList();

            cbTorneo.DataSource = torneos;
            cbTorneo.DisplayMember = "NombreTorneo";
            cbTorneo.ValueMember = "IdTorneo";

            if (torneos.Count > 0)
            {
                cbTorneo.SelectedIndex = 0;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerResumen_Click(object sender, EventArgs e)
        {
            if (cbTorneo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un torneo.");
                return;
            }

            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);

            // Campeón y Subcampeón
            var resultadoFinal = nPartido.ObtenerFinalistas(idTorneo);
            lblCampeon.Text = "Campeón: " + resultadoFinal.campeon;
            lblSubcampeon.Text = "Subcampeón: " + resultadoFinal.subcampeon;

            // Mostrar partidos finalizados
            var partidos = nPartido.ListarPartidosPorTorneoConRelaciones(idTorneo)
                .Where(p => p.Estado == "Finalizado")
                .ToList();

            var resultados = dResultado.ListarTodo();
            var resumen = new List<object>();

            foreach (var p in partidos)
            {
                string fecha = "Sin fecha";
                if (p.FechaHora.HasValue)
                {
                    fecha = p.FechaHora.Value.ToString("dd/MM/yyyy HH:mm");
                }

                string cancha = "Sin cancha";
                if (p.Canchas != null && p.Canchas.NombreCancha != null)
                {
                    cancha = p.Canchas.NombreCancha;
                }

                string local = "Equipo Local";
                if (p.Equipos != null && p.Equipos.NombreEquipo != null)
                {
                    local = p.Equipos.NombreEquipo;
                }

                string visitante = "Equipo Visitante";
                if (p.Equipos1 != null && p.Equipos1.NombreEquipo != null)
                {
                    visitante = p.Equipos1.NombreEquipo;
                }

                int golesLocal = 0;
                int golesVisitante = 0;
                string ganador = "No definido";

                var r = resultados.FirstOrDefault(x => x.IdPartido == p.IdPartido);
                if (r != null)
                {
                    if (r.GolesEquipoLocal.HasValue)
                        golesLocal = r.GolesEquipoLocal.Value;
                    if (r.GolesEquipoVisitante.HasValue)
                        golesVisitante = r.GolesEquipoVisitante.Value;
                }

                if (p.IdGanador.HasValue)
                {
                    if (p.IdGanador.Value == p.IdEquipoLocal && p.Equipos != null)
                        ganador = p.Equipos.NombreEquipo;
                    else if (p.IdGanador.Value == p.IdEquipoVisitante && p.Equipos1 != null)
                        ganador = p.Equipos1.NombreEquipo;
                }

                resumen.Add(new
                {
                    Fecha = fecha,
                    Cancha = cancha,
                    Local = local,
                    GolesLocal = golesLocal,
                    Visitante = visitante,
                    GolesVisitante = golesVisitante,
                    Ganador = ganador,
                    Ronda = p.Ronda,
                    Orden = p.OrdenJuego
                });
            }

            dgResumen.DataSource = null;
            dgResumen.DataSource = resumen;

            // Mostrar goleadores usando NReporte
            var goleadores = nReporte.JugadoresConMasGoles(idTorneo);
            dgGoleadores.DataSource = null;
            dgGoleadores.DataSource = goleadores;

            // Nombres claros para columnas
            if (dgResumen.Columns.Contains("GolesLocal"))
                dgResumen.Columns["GolesLocal"].HeaderText = "Goles Local";
            if (dgResumen.Columns.Contains("GolesVisitante"))
                dgResumen.Columns["GolesVisitante"].HeaderText = "Goles Visitante";

            if (dgGoleadores.Columns.Contains("Jugador"))
                dgGoleadores.Columns["Jugador"].HeaderText = "Jugador";
            if (dgGoleadores.Columns.Contains("Equipo"))
                dgGoleadores.Columns["Equipo"].HeaderText = "Equipo";
            if (dgGoleadores.Columns.Contains("Goles"))
                dgGoleadores.Columns["Goles"].HeaderText = "Goles";
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
