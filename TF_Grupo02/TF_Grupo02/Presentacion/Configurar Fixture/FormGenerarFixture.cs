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
    public partial class FormGenerarFixture : Form
    {
        private NTorneo nTorneo = new NTorneo();
        private NInscripcion nInscripcion = new NInscripcion();
        private NPartido nPartido = new NPartido();
        private NCanchas nCancha = new NCanchas();

        public FormGenerarFixture()
        {
            InitializeComponent();
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
                MessageBox.Show("Se necesitan al menos 2 equipos y un número par para generar un fixture de eliminación directa.");
                return;
            }

            var canchas = nCancha.ListarTodo();
            if (canchas.Count == 0)
            {
                MessageBox.Show("No hay canchas registradas.");
                return;
            }

            // Mezclar equipos aleatoriamente
            var rnd = new Random();
            var emparejamientos = equipos.OrderBy(x => rnd.Next()).ToList();

            int ordenJuego = 1;
            for (int i = 0; i < emparejamientos.Count; i += 2)
            {
                Partidos partido = new Partidos
                {
                    IdTorneo = idTorneo,
                    FechaHora = DateTime.Now.AddDays(ordenJuego), // cada partido en día distinto
                    IdCancha = canchas[0].IdCancha,
                    IdEquipoLocal = emparejamientos[i].IdEquipo,
                    IdEquipoVisitante = emparejamientos[i + 1].IdEquipo,
                    Estado = "Programado",
                    Ronda = "Cuartos de Final", // puedes adaptar esto según el número
                    OrdenJuego = ordenJuego
                };

                string mensaje = nPartido.Registrar(partido);
                if (!mensaje.Contains("correctamente"))
                {
                    MessageBox.Show("Error al registrar partido: " + mensaje);
                    return;
                }

                ordenJuego++;
            }

            MessageBox.Show("Fixture generado exitosamente.");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}