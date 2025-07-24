using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormGenerarFixture : Form
    {
        private NTorneo nTorneo = new NTorneo();
        private NInscripcion nInscripcion = new NInscripcion();
        private NPartido nPartido = new NPartido();
        private NCancha nCancha = new NCancha();

        public FormGenerarFixture()
        {
            InitializeComponent();
            cbTorneo.SelectedIndexChanged += cbTorneo_SelectedIndexChanged;
            CargarTorneos();

        }

        private void CargarTorneos()
        {
            var torneos = nTorneo.ListarTodo()
                .Where(t => t.Estado == "Abierto")
                .ToList();

            cbTorneo.DataSource = torneos;
            cbTorneo.DisplayMember = "NombreTorneo";
            cbTorneo.ValueMember = "IdTorneo";
        
        }

        private void MostrarFixture(List<Partidos> partidos)
        {
            dgFixture.DataSource = null;
            if (partidos.Count == 0) return;

            var listaFormateada = new List<object>();

            foreach (var p in partidos)
            {
                string nombreCancha = "Sin asignar";
                string nombreLocal = "Sin asignar";
                string nombreVisitante = "Sin asignar";

                if (p.Canchas != null && p.Canchas.NombreCancha != null)
                    nombreCancha = p.Canchas.NombreCancha;

                if (p.Equipos != null && p.Equipos.NombreEquipo != null)
                    nombreLocal = p.Equipos.NombreEquipo;

                if (p.Equipos1 != null && p.Equipos1.NombreEquipo != null)
                    nombreVisitante = p.Equipos1.NombreEquipo;

                listaFormateada.Add(new
                {
                    Fecha = p.FechaHora?.ToString("dd/MM/yyyy HH:mm"),
                    Cancha = nombreCancha,
                    Local = nombreLocal,
                    Visitante = nombreVisitante,
                    Ronda = p.Ronda,
                    Estado = p.Estado,
                    Orden = p.OrdenJuego
                });
            }

            dgFixture.DataSource = listaFormateada;
        }



        private string ObtenerNombreRonda(int cantidadEquipos)
        {
            if (cantidadEquipos == 2)
                return "Final";
            else if (cantidadEquipos == 4)
                return "Semifinal";
            else if (cantidadEquipos == 8)
                return "Cuartos de Final";
            else if (cantidadEquipos == 16)
                return "Octavos de Final";
            else
                return "Primera Ronda";
        }


        private void btnGenerarFixture_Click(object sender, EventArgs e)
        {
            if (cbTorneo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un torneo.");
                return;
            }

            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            var equipos = nInscripcion.ListarPorTorneoConfirmados(idTorneo);

            if (equipos.Count < 2 || equipos.Count % 2 != 0)
            {
                MessageBox.Show("Debe haber un número par de equipos (mínimo 2) para generar un fixture de eliminación directa.");
                return;
            }

            var canchas = nCancha.ListarTodo();
            if (canchas.Count == 0)
            {
                MessageBox.Show("Debe haber al menos una cancha registrada.");
                return;
            }

            if (nPartido.ListarPorTorneo(idTorneo).Any())
            {
                var msgDel = nPartido.EliminarPartidosPorTorneo(idTorneo);
                if (!msgDel.Contains("correctamente"))
                {
                    MessageBox.Show(msgDel);
                    return;
                }
            }

            var rnd = new Random();
            var emparej = equipos.OrderBy(x => rnd.Next()).ToList();
            var canchasRot = canchas.OrderBy(x => rnd.Next()).ToList();
            int orden = 1;
            var partidos = new List<Partidos>();

            for (int i = 0; i < emparej.Count; i += 2)
            {
                var canchaElegida = canchasRot[(i / 2) % canchasRot.Count].IdCancha;
                partidos.Add(new Partidos
                {
                    IdTorneo = idTorneo,
                    FechaHora = DateTime.Now.AddHours(orden * 2),
                    IdCancha = canchaElegida,
                    IdEquipoLocal = emparej[i].IdEquipo,
                    IdEquipoVisitante = emparej[i + 1].IdEquipo,
                    Estado = "Programado",
                    Ronda = ObtenerNombreRonda(equipos.Count),
                    OrdenJuego = orden++
                });
            }

            // Registrar partidos
            foreach (var p in partidos)
            {
                var msg = nPartido.Registrar(p);
                if (!msg.Contains("correctamente"))
                {
                    MessageBox.Show("Error al registrar partido: " + msg);
                    return;
                }
            }

            // Mostrar con relaciones
            var listas = nPartido.ListarPartidosPorTorneoConRelaciones(idTorneo);
            MostrarFixture(listas);
            MessageBox.Show("Fixture generado exitosamente.");

            // Cambiar estado del torneo
            var torneo = nTorneo.ObtenerPorId(idTorneo);
            torneo.Estado = "En curso";
            var modMsg = nTorneo.Modificar(torneo);
            if (modMsg.Contains("correctamente"))
                MessageBox.Show("Torneo actualizado a 'En curso'.");
            else
                MessageBox.Show("No se pudo actualizar torneo: " + modMsg);

            CargarTorneos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listas = nPartido.ListarPartidosPorTorneoConRelaciones((int)cbTorneo.SelectedValue)
            .Where(p => p.Estado == "Programado")
            .ToList();
            MostrarFixture(listas);
        }
    }
}