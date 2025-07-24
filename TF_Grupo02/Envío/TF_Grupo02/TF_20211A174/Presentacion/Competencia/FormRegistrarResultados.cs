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
    public partial class FormRegistrarResultados : Form
    {
        private NTorneo nTorneo = new NTorneo();
        private NPartido nPartido = new NPartido();
        private NResultado nResultado = new NResultado();
        private List<Partidos> listaPartidos = new List<Partidos>();
        public FormRegistrarResultados()
        {
            InitializeComponent();
            CargarTorneos();
        }

        private void MostrarResultados(int idTorneo)
        {
            var resultados = nResultado.ListarPorTorneoConRelaciones(idTorneo);

            var listaFormateada = new List<object>();

            foreach (var r in resultados)
            {
                var p = r.Partidos;
                string local = "N/A";
                string visitante = "N/A";
                string fechaPartido = "N/A";
                string fechaRegistro = "N/A";
                string nombreGanador = "N/A";

                if (p != null)
                {
                    if (p.Equipos != null)
                        local = p.Equipos.NombreEquipo;

                    if (p.Equipos1 != null)
                        visitante = p.Equipos1.NombreEquipo;

                    if (p.FechaHora != null)
                        fechaPartido = p.FechaHora.Value.ToString("dd/MM/yyyy HH:mm");

                    if (p.IdGanador != null)
                    {
                        if (p.IdGanador == p.IdEquipoLocal)
                            nombreGanador = local;
                        else if (p.IdGanador == p.IdEquipoVisitante)
                            nombreGanador = visitante;
                        else
                            nombreGanador = "Desconocido";
                    }
                }

                if (r.FechaRegistro != null)
                    fechaRegistro = r.FechaRegistro.Value.ToString("dd/MM/yyyy HH:mm");

                listaFormateada.Add(new
                {
                    r.IdResultado,
                    Partido = local + " vs " + visitante,
                    FechaPartido = fechaPartido,
                    Ronda = p != null ? p.Ronda : "N/A",
                    Ganador = nombreGanador,
                    r.GolesEquipoLocal,
                    r.GolesEquipoVisitante,
                    FechaRegistro = fechaRegistro
                });
            }

            dgRegistrarResultados.DataSource = null;
            dgRegistrarResultados.DataSource = listaFormateada;
            if (dgRegistrarResultados.Columns.Contains("IdResultado"))
                dgRegistrarResultados.Columns["IdResultado"].Visible = false;
        }

        private void CargarTorneos()
        {
            var torneos = nTorneo.ListarTodo()
                .Where(t => t.Estado == "En curso")
                .ToList();

            cbTorneo.DataSource = torneos;
            cbTorneo.DisplayMember = "NombreTorneo";
            cbTorneo.ValueMember = "IdTorneo";

            if (torneos.Count > 0)
            {
                cbTorneo.SelectedIndex = 0;
                cbTorneo_SelectedIndexChanged(null, null);
            }
            else
            {
                MessageBox.Show("No hay torneos en curso para mostrar.");
            }
        }

        private string ObtenerSiguienteRonda(string rondaActual)
        {
            if (rondaActual == "Octavos de Final") return "Cuartos de Final";
            else if (rondaActual == "Cuartos de Final") return "Semifinal";
            else if (rondaActual == "Semifinal") return "Final";
            else return "Final";
        }


        private void ProgresarRonda(int idTorneo, string rondaActual)
        {
            var partidosDeRonda = nPartido.ListarPorTorneo(idTorneo)
                                          .Where(p => p.Ronda == rondaActual)
                                          .ToList();

            bool todosFinalizados = partidosDeRonda.All(p => p.Estado == "Finalizado" && p.IdGanador.HasValue);
            if (!todosFinalizados) return;

            var ganadores = partidosDeRonda.Select(p => p.IdGanador.Value).ToList();

            if (ganadores.Count < 2)
            {
                // Finalizó el torneo
                var torneo = nTorneo.ObtenerPorId(idTorneo);
                torneo.Estado = "Finalizado";
                var mensajeFinal = nTorneo.Modificar(torneo);
                MessageBox.Show("El torneo ha finalizado.");
                return;
            }

            if (ganadores.Count % 2 != 0)
            {
                MessageBox.Show("Número impar de ganadores. No se puede generar siguiente ronda.");
                return;
            }

            string siguienteRonda = ObtenerSiguienteRonda(rondaActual);
            var canchas = new NCancha().ListarTodo();
            if (canchas.Count == 0)
            {
                MessageBox.Show("No hay canchas disponibles.");
                return;
            }

            int diasExtra = 0;
            if (siguienteRonda == "Cuartos de Final") diasExtra = 2;
            else if (siguienteRonda == "Semifinal") diasExtra = 4;
            else if (siguienteRonda == "Final") diasExtra = 6;


            var rnd = new Random();
            for (int i = 0; i < ganadores.Count; i += 2)
            {
                Partidos nuevo = new Partidos
                {
                    IdTorneo = idTorneo,
                    FechaHora = DateTime.Now.AddDays(diasExtra).AddHours(2 * (i / 2)),
                    IdCancha = canchas[rnd.Next(canchas.Count)].IdCancha,
                    IdEquipoLocal = ganadores[i],
                    IdEquipoVisitante = ganadores[i + 1],
                    Estado = "Programado",
                    Ronda = siguienteRonda,
                    OrdenJuego = i / 2 + 1
                };

                string mensaje = nPartido.Registrar(nuevo);
                if (!mensaje.Contains("correctamente"))
                {
                    MessageBox.Show("Error al generar siguiente ronda: " + mensaje);
                    return;
                }
            }

            MessageBox.Show("Nueva ronda generada: " + siguienteRonda);
        }

        private void btnRegistarResultado_Click(object sender, EventArgs e)
        {
            if (cbPartido.Text == "" || cbTorneo.Text == "" || numGolesLocal.Text == "" || numGolesVisitante.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            if (cbPartido.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un partido.");
                return;
            }

            int idPartido = Convert.ToInt32(cbPartido.SelectedValue);
            int golesLocal = (int)numGolesLocal.Value;
            int golesVisitante = (int)numGolesVisitante.Value;

            Resultados resultado = new Resultados
            {
                IdPartido = idPartido,
                GolesEquipoLocal = golesLocal,
                GolesEquipoVisitante = golesVisitante,
                FechaRegistro = DateTime.Now
            };

            string mensaje = nResultado.Registrar(resultado);
            MessageBox.Show(mensaje);

            var partido = nPartido.ObtenerPorId(idPartido);
            partido.Estado = "Finalizado";

            if (golesLocal > golesVisitante && partido.IdEquipoLocal.HasValue)
                partido.IdGanador = partido.IdEquipoLocal.Value;
            else if (golesVisitante > golesLocal && partido.IdEquipoVisitante.HasValue)
                partido.IdGanador = partido.IdEquipoVisitante.Value;

            string modificarMensaje = nPartido.Modificar(partido);
            if (!modificarMensaje.Contains("correctamente"))
            {
                MessageBox.Show("Error al actualizar partido: " + modificarMensaje);
                return;
            
            }

            var resumen = new NResumenEstadisticaEquipo();

            resumen.ActualizarResumen(
                partido.IdTorneo.Value,
                partido.IdEquipoLocal.Value,
                golesLocal > golesVisitante,
                golesLocal,
                golesVisitante
            );

            resumen.ActualizarResumen(
                partido.IdTorneo.Value,
                partido.IdEquipoVisitante.Value,
                golesVisitante > golesLocal,
                golesVisitante,
                golesLocal
            );


            ProgresarRonda(partido.IdTorneo.Value, partido.Ronda);

            cbTorneo_SelectedIndexChanged(null, null);

            MostrarResultados(partido.IdTorneo.Value);
        }
    

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTorneo.SelectedValue == null) return;

            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            listaPartidos = nPartido.ListarPorTorneo(idTorneo)
                                    .Where(p => p.Estado == "Programado" || p.Estado == "Pendiente")
                                    .ToList();

            cbPartido.DataSource = listaPartidos;
            cbPartido.DisplayMember = "IdPartido";
            cbPartido.ValueMember = "IdPartido";

            MostrarResultados(idTorneo);
        }

        private void cbPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPartido.SelectedValue == null) return;
            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            MostrarResultados(idTorneo);
        }

        private void btnVerEquipos_Click(object sender, EventArgs e)
        {
            if (cbPartido.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un partido.");
                return;
            }

            int idPartido = Convert.ToInt32(cbPartido.SelectedValue);
            var partido = listaPartidos.FirstOrDefault(p => p.IdPartido == idPartido);

            if (partido != null)
            {
                string nombreLocal = "Equipo Local";
                string nombreVisitante = "Equipo Visitante";

                if (partido.Equipos != null)
                    nombreLocal = partido.Equipos.NombreEquipo;
                if (partido.Equipos1 != null)
                    nombreVisitante = partido.Equipos1.NombreEquipo;

                lblGolesLocal.Text = "Goles de " + nombreLocal + ":";
                lblGolesVisitante.Text = "Goles de " + nombreVisitante + ":";
            }
        }
    }
}
