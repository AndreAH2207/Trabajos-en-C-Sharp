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
    public partial class FormRegistrarInscripciones : Form
    {
        private NInscripcion nInscripcion = new NInscripcion();
        private NTorneo nTorneo = new NTorneo();
        private NEquipo nEquipo = new NEquipo();
        public FormRegistrarInscripciones()
        {
            InitializeComponent();
            var torneos = nTorneo.ListarTodo();
            var equipos = nEquipo.ListarTodo();

            if (torneos.Count == 0 || equipos.Count == 0)
            {
                MessageBox.Show("Debe registrar torneos y equipos antes de inscribir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            MostrarTorneos(torneos);
            MostrarEquipos(equipos);
            MostrarInscripciones(nInscripcion.ListarTodo());
        }

        private void MostrarTorneos(List<Torneos> torneos)
        {
            cbTorneo.DataSource = torneos;
            cbTorneo.DisplayMember = "NombreTorneo";
            cbTorneo.ValueMember = "IdTorneo";
        }

        private void MostrarEquipos(List<Equipos> equipos)
        {
            cbEquipo.DataSource = equipos;
            cbEquipo.DisplayMember = "NombreEquipo";
            cbEquipo.ValueMember = "IdEquipo";
        }

        private void MostrarInscripciones(List<Inscripciones> inscripciones)
        {
            dgInscripciones.DataSource = null;
            if (inscripciones.Count == 0) return;

            var listaFormateada = new List<object>();

            foreach (var inscripcion in inscripciones)
            {
                string nombreTorneo = "Torneo eliminado";
                string nombreEquipo = "Equipo eliminado";

                if (inscripcion.Torneos != null && inscripcion.Torneos.NombreTorneo != null)
                {
                    nombreTorneo = inscripcion.Torneos.NombreTorneo;
                }

                if (inscripcion.Equipos != null && inscripcion.Equipos.NombreEquipo != null)
                {
                    nombreEquipo = inscripcion.Equipos.NombreEquipo;
                }

                listaFormateada.Add(new
                {
                    inscripcion.IdInscripcion, 
                    Torneo = nombreTorneo,
                    Equipo = nombreEquipo,
                    FechaInscripcion = inscripcion.FechaInscripcion?.ToString("dd/MM/yyyy HH:mm") ?? "",
                    inscripcion.Estado
                });
            }

            dgInscripciones.DataSource = listaFormateada;


            if (dgInscripciones.Columns.Contains("IdInscripcion"))
                dgInscripciones.Columns["IdInscripcion"].Visible = false;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbTorneo.Text == "" || cbEquipo.Text == "" || cbEstado.Text == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            int idEquipo = Convert.ToInt32(cbEquipo.SelectedValue);

            // Verificar si ya está inscrito
            var inscripcionesExistentes = nInscripcion.ListarTodo();
            bool yaInscrito = inscripcionesExistentes.Any(i =>
                i.IdTorneo == idTorneo && i.IdEquipo == idEquipo);

            if (yaInscrito)
            {
                MessageBox.Show("Este equipo ya está inscrito en el torneo seleccionado.");
                return;
            }

            int cantidadInscritos = inscripcionesExistentes.Count(i => i.IdTorneo == idTorneo);
            if (cantidadInscritos >= 8)
            {
                MessageBox.Show("Este torneo ya tiene 8 equipos inscritos. No se pueden inscribir más.");
                return;
            }

            Inscripciones inscripcion = new Inscripciones
            {
                IdTorneo = idTorneo,
                IdEquipo = idEquipo,
                FechaInscripcion = DateTime.Now,
                Estado = cbEstado.Text
            };

            string mensaje = nInscripcion.Registrar(inscripcion);
            MessageBox.Show(mensaje);
            MostrarInscripciones(nInscripcion.ListarTodo());
        }
    

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cbTorneo.Text == "" || cbEquipo.Text == "" || cbEstado.Text == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (dgInscripciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una inscripción.");
                return;
            }

            int id = Convert.ToInt32(dgInscripciones.SelectedRows[0].Cells["IdInscripcion"].Value);

            Inscripciones inscripcion = new Inscripciones
            {
                IdInscripcion = id,
                IdTorneo = Convert.ToInt32(cbTorneo.SelectedValue),
                IdEquipo = Convert.ToInt32(cbEquipo.SelectedValue),
                Estado = cbEstado.Text
            };

            string mensaje = nInscripcion.Modificar(inscripcion);
            MessageBox.Show(mensaje);
            MostrarInscripciones(nInscripcion.ListarTodo());
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarInscripciones(nInscripcion.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgInscripciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una inscripción a eliminar.");
                return;
            }

            int id = Convert.ToInt32(dgInscripciones.SelectedRows[0].Cells["IdInscripcion"].Value);
            string mensaje = nInscripcion.Eliminar(id);
            MessageBox.Show(mensaje);
            MostrarInscripciones(nInscripcion.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
