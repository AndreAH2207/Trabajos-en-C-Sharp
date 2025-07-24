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
    public partial class FormEstadisticasJugador : Form
    {
        private NTorneo nTorneo = new NTorneo();
        private NPartido nPartido = new NPartido();
        private NEstadisticaJugador nEstadistica = new NEstadisticaJugador();
        private NJugador nJugador = new NJugador();
        private NResultado nResultado = new NResultado();
        private List<Jugadores> jugadoresDelPartido = new List<Jugadores>();
        private List<EstadisticasJugador> estadisticasExistentes = new List<EstadisticasJugador>();


        public FormEstadisticasJugador()
        {
            InitializeComponent();
            CargarTorneos();
            dgEstadisticasJugadores.CellValidating += dgEstadisticasJugadores_CellValidating;
            dgEstadisticasJugadores.CellEndEdit += dgEstadisticasJugadores_CellEndEdit; 
        }

        private void CargarTorneos()
        {
            var torneos = nTorneo.ListarTodo()
                                  .Where(t => t.Estado == "En curso" || t.Estado == "Finalizado")
                                  .ToList();

            cbTorneo.DataSource = torneos;
            cbTorneo.DisplayMember = "NombreTorneo";
            cbTorneo.ValueMember = "IdTorneo";
        }

        private string GenerarDescripcionPartido(Partidos p)
        {
            string equipoLocal = "Equipo Local";
            if (p.Equipos != null)
            {
                equipoLocal = p.Equipos.NombreEquipo;
            }

            string equipoVisitante = "Equipo Visitante";
            if (p.Equipos1 != null)
            {
                equipoVisitante = p.Equipos1.NombreEquipo;
            }

            string fecha = "sin fecha";
            if (p.FechaHora != null)
            {
                fecha = p.FechaHora.Value.ToString("dd/MM/yyyy");
            }

            return p.Ronda + " - " + equipoLocal + " vs " + equipoVisitante + " (" + fecha + ")";
        }

        private void btnVerEstadisticas_Click(object sender, EventArgs e)
        {
            if (cbPartido.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un partido.");
                return;
            }

            int idPartido = Convert.ToInt32(cbPartido.SelectedValue);
            var partido = nPartido.ObtenerPorId(idPartido);

            if (partido == null || partido.IdEquipoLocal == null || partido.IdEquipoVisitante == null)
            {
                MessageBox.Show("El partido seleccionado no es válido o no tiene equipos asignados.");
                return;
            }

            int idLocal = (int)partido.IdEquipoLocal;
            int idVisitante = (int)partido.IdEquipoVisitante;

            jugadoresDelPartido = nJugador.ListarPorEquipo(idLocal)
                                          .Concat(nJugador.ListarPorEquipo(idVisitante))
                                          .ToList();

            estadisticasExistentes = nEstadistica.ListarPorPartido(idPartido); 

            // Crear DataTable
            DataTable tabla = new DataTable();
            tabla.Columns.Add("IdJugador", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Equipo", typeof(string));
            tabla.Columns.Add("Goles", typeof(int));
            tabla.Columns.Add("Asistencias", typeof(int));
            tabla.Columns.Add("Faltas", typeof(int));
            tabla.Columns.Add("IdEstadistica", typeof(int));

            foreach (var j in jugadoresDelPartido)
            {
                var est = estadisticasExistentes.FirstOrDefault(et => et.IdJugador == j.IdJugador);

                int goles = 0;
                int asistencias = 0;
                int faltas = 0;
                int idEstadistica = 0;

                if (est != null)
                {
                    goles = est.Goles.Value;
                    asistencias = est.Asistencias.Value;
                    faltas = est.Faltas.Value;
                    idEstadistica = est.IdEstadistica;
                }
                string nombreEquipo = "Sin equipo";
                if (j.Equipos != null)
                {
                    nombreEquipo = j.Equipos.NombreEquipo;
                }

                tabla.Rows.Add(j.IdJugador, j.Nombres + " " + j.Apellidos, nombreEquipo, goles, asistencias, faltas, idEstadistica); 

            }

            dgEstadisticasJugadores.DataSource = tabla;

            // Ocultar columnas internas
            dgEstadisticasJugadores.Columns["IdJugador"].Visible = false;
            dgEstadisticasJugadores.Columns["IdEstadistica"].Visible = false;

            // Nombres de columnas
            dgEstadisticasJugadores.Columns["Nombre"].HeaderText = "Jugador";
            dgEstadisticasJugadores.Columns["Equipo"].HeaderText = "Equipo"; 
            dgEstadisticasJugadores.Columns["Goles"].HeaderText = "Goles";
            dgEstadisticasJugadores.Columns["Asistencias"].HeaderText = "Asistencias";
            dgEstadisticasJugadores.Columns["Faltas"].HeaderText = "Faltas";

            // Configurar edición
            dgEstadisticasJugadores.Columns["Nombre"].ReadOnly = true;
            dgEstadisticasJugadores.Columns["Equipo"].ReadOnly = true;
            dgEstadisticasJugadores.Columns["Goles"].ReadOnly = false;
            dgEstadisticasJugadores.Columns["Asistencias"].ReadOnly = false;
            dgEstadisticasJugadores.Columns["Faltas"].ReadOnly = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTorneo.SelectedValue == null) return;

            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            var partidos = nPartido.ListarPartidosPorTorneoConRelaciones(idTorneo)
                                   .Where(p => p.Estado == "Finalizado")
                                   .Select(p => new
                                   {
                                       p.IdPartido,
                                       Descripcion = GenerarDescripcionPartido(p)
                                   })
                                   .ToList();

            cbPartido.DataSource = partidos;
            cbPartido.DisplayMember = "Descripcion";
            cbPartido.ValueMember = "IdPartido";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbPartido.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un partido.");
                return;
            }

            int idPartido = Convert.ToInt32(cbPartido.SelectedValue);
            var partido = nPartido.ObtenerPorId(idPartido);
            var resultado = nResultado.ObtenerPorPartido(idPartido);

            int golesOficialLocal = resultado.GolesEquipoLocal.Value;
            int golesOficialVisitante = resultado.GolesEquipoVisitante.Value;

            int golesAsignadosLocal = 0;
            int golesAsignadosVisitante = 0;

            foreach (DataGridViewRow row in dgEstadisticasJugadores.Rows)
            {
                if (row.IsNewRow) continue;

                int idJugador = Convert.ToInt32(row.Cells["IdJugador"].Value);
                int goles = Convert.ToInt32(row.Cells["Goles"].Value);

                var jugador = jugadoresDelPartido.FirstOrDefault(j => j.IdJugador == idJugador);
                if (jugador != null)
                {
                    if (jugador.IdEquipo == partido.IdEquipoLocal)
                        golesAsignadosLocal += goles;
                    else if (jugador.IdEquipo == partido.IdEquipoVisitante)
                        golesAsignadosVisitante += goles;
                }
            }

            if (golesAsignadosLocal > golesOficialLocal || golesAsignadosVisitante > golesOficialVisitante)
            {
                MessageBox.Show("La suma de goles asignados por jugador supera los goles oficiales del equipo.");
                return;
            }

            foreach (DataGridViewRow row in dgEstadisticasJugadores.Rows)
            {
                if (row.IsNewRow) continue;

                int idJugador = Convert.ToInt32(row.Cells["IdJugador"].Value);
                int idEstadistica = Convert.ToInt32(row.Cells["IdEstadistica"].Value);
                int goles = Convert.ToInt32(row.Cells["Goles"].Value);
                int asistencias = Convert.ToInt32(row.Cells["Asistencias"].Value);
                int faltas = Convert.ToInt32(row.Cells["Faltas"].Value);

                var estadistica = new EstadisticasJugador
                {
                    IdEstadistica = idEstadistica,
                    IdJugador = idJugador,
                    IdPartido = idPartido,
                    Goles = goles,
                    Asistencias = asistencias,
                    Faltas = faltas,
                    FechaRegistro = DateTime.Now
                };

                string mensaje = "";
                if (idEstadistica == 0)
                {
                    mensaje = nEstadistica.Registrar(estadistica);
                }
                else
                {
                    mensaje = nEstadistica.Modificar(estadistica);
                }

                if (!mensaje.Contains("correctamente"))
                {
                    MessageBox.Show("Error en jugador " + idJugador + ": " + mensaje);
                    return;
                }
            }

            MessageBox.Show("Estadísticas guardadas exitosamente.");
        }

        private void dgEstadisticasJugadores_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string col = dgEstadisticasJugadores.Columns[e.ColumnIndex].Name;
            if (col == "Goles" || col == "Asistencias" || col == "Faltas")
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int val) || val < 0)
                {
                    MessageBox.Show("Ingrese un número entero válido (0 o mayor).");
                    e.Cancel = true;
                }
            }
        }

        private void dgEstadisticasJugadores_CellEndEdit(object sender, DataGridViewCellEventArgs e) // CAMBIO: Validación inmediata tras editar goles
        {
            if (dgEstadisticasJugadores.Columns[e.ColumnIndex].Name != "Goles") return;
            if (cbPartido.SelectedValue == null) return;

            int idPartido = Convert.ToInt32(cbPartido.SelectedValue);
            var partido = nPartido.ObtenerPorId(idPartido);
            var resultado = nResultado.ObtenerPorPartido(idPartido);

            int golesOficialLocal = (resultado.GolesEquipoLocal != null) ? resultado.GolesEquipoLocal.Value : 0;
            int golesOficialVisitante = (resultado.GolesEquipoVisitante != null) ? resultado.GolesEquipoVisitante.Value : 0;

            int golesAsignadosLocal = 0;
            int golesAsignadosVisitante = 0;

            foreach (DataGridViewRow row in dgEstadisticasJugadores.Rows)
            {
                if (row.IsNewRow) continue;

                int goles = 0;
                int.TryParse(row.Cells["Goles"].Value.ToString(), out goles);

                int idJugador = Convert.ToInt32(row.Cells["IdJugador"].Value);
                var jugador = jugadoresDelPartido.FirstOrDefault(j => j.IdJugador == idJugador);

                if (jugador != null)
                {
                    if (jugador.IdEquipo == partido.IdEquipoLocal)
                        golesAsignadosLocal += goles;
                    else if (jugador.IdEquipo == partido.IdEquipoVisitante)
                        golesAsignadosVisitante += goles;
                }
            }

            if (golesAsignadosLocal > golesOficialLocal || golesAsignadosVisitante > golesOficialVisitante)
            {
                MessageBox.Show("La suma de goles asignados supera los goles oficiales del equipo.");
                dgEstadisticasJugadores.Rows[e.RowIndex].Cells["Goles"].Value = 0; 
            }
        }
    }
}
