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
        private NJugador nJugador = new NJugador();
        private NEstadisticaJugador nEstadistica = new NEstadisticaJugador();

        public FormEstadisticasJugador()
        {
            InitializeComponent();
            CargarTorneos();

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

        private void btnVerEstadisticas_Click(object sender, EventArgs e)
        {
            if (cbPartido.SelectedItem == null) return;

            int idPartido = Convert.ToInt32(cbPartido.SelectedValue);
            var partido = nPartido.ObtenerPorId(idPartido);

            var jugadoresLocal = nJugador.ListarPorEquipo(partido.IdEquipoLocal);
            var jugadoresVisitante = nJugador.ListarPorEquipo(partido.IdEquipoVisitante);

            var todos = jugadoresLocal.Concat(jugadoresVisitante).ToList();

            var estadisticasRegistradas = nEstadistica.ListarPorPartido(idPartido);

            var data = todos.Select(j =>
            {
                var est = estadisticasRegistradas.FirstOrDefault(e => e.IdJugador == j.IdJugador);
                return new
                {
                    j.IdJugador,
                    Nombre = j.Nombres + " " + j.Apellidos,
                    Goles = est?.Goles ?? 0,
                    Asistencias = est?.Asistencias ?? 0,
                    Faltas = est?.Faltas ?? 0
                };
            }).ToList();

            dgEstadisticasJugadores.DataSource = data;

            dgEstadisticasJugadores.Columns["IdJugador"].Visible = false;
            dgEstadisticasJugadores.Columns["Nombre"].ReadOnly = true;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            cbPartido.DataSource = nPartido.ListarPorTorneo(idTorneo).Where(p => p.Estado == "Finalizado").ToList();
            cbPartido.DisplayMember = "IdPartido";
            cbPartido.ValueMember = "IdPartido";
        }

        private void cbPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idPartido = Convert.ToInt32(cbPartido.SelectedValue);
            var partido = nPartido.ObtenerPorId(idPartido);

            var jugadoresLocal = nJugador.ListarPorEquipo(partido.IdEquipoLocal);
            var jugadoresVisitante = nJugador.ListarPorEquipo(partido.IdEquipoVisitante);

            var todos = jugadoresLocal.Concat(jugadoresVisitante).ToList();

            dgEstadisticasJugadores.DataSource = todos.Select(j => new
            {
                j.IdJugador,
                Nombre = j.Nombres + " " + j.Apellidos,
                Goles = 0,
                Asistencias = 0,
                Faltas = 0
            }).ToList();

            dgEstadisticasJugadores.Columns["IdJugador"].Visible = false;
            dgEstadisticasJugadores.Columns["Nombre"].ReadOnly = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbPartido.SelectedItem == null) return;

            int idPartido = Convert.ToInt32(cbPartido.SelectedValue);

            foreach (DataGridViewRow fila in dgvEstadisticas.Rows)
            {
                if (fila.IsNewRow) continue;

                int idJugador = Convert.ToInt32(fila.Cells["IdJugador"].Value);
                int goles = Convert.ToInt32(fila.Cells["Goles"].Value ?? 0);
                int asistencias = Convert.ToInt32(fila.Cells["Asistencias"].Value ?? 0);
                int faltas = Convert.ToInt32(fila.Cells["Faltas"].Value ?? 0);

                // Verificar si ya existe
                var existente = nEstadistica.ObtenerPorPartidoYJugador(idPartido, idJugador);

                if (existente != null)
                {
                    existente.Goles = goles;
                    existente.Asistencias = asistencias;
                    existente.Faltas = faltas;
                    nEstadistica.Modificar(estudiante: existente);
                }
                else
                {
                    var nuevo = new EstadisticasJugador
                    {
                        IdPartido = idPartido,
                        IdJugador = idJugador,
                        Goles = goles,
                        Asistencias = asistencias,
                        Faltas = faltas,
                        FechaRegistro = DateTime.Now
                    };
                    nEstadistica.Registrar(nuevo);
                }
            }

            MessageBox.Show("Estadísticas guardadas correctamente.");
        }
    }
}
