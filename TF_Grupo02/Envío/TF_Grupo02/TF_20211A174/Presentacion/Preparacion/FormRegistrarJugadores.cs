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
    public partial class FormRegistrarJugadores : Form
    {
        private NJugador nJugador = new NJugador();
        private NEquipo nEquipo = new NEquipo();


        public FormRegistrarJugadores()
        {
            InitializeComponent();
            MostrarEquipos(nEquipo.ListarTodo());
            MostrarJugadores(nJugador.ListarTodo());
            BotonMostrarEquipos();
        }

        private void MostrarEquipos(List<Equipos> equipos)
        {
            cbEquipo.DataSource = null;

            if (equipos.Count > 0)
            {
                cbEquipo.DataSource = equipos;
                cbEquipo.DisplayMember = "NombreEquipo";
                cbEquipo.ValueMember = "IdEquipo";
            }
        }

        private void BotonMostrarEquipos()
        {
            var equipos = nEquipo.ListarTodo();
            cbMostrarPorEquipo.DataSource = null;

            if (equipos.Count == 0)
                return;

            cbMostrarPorEquipo.DataSource = equipos;
            cbMostrarPorEquipo.DisplayMember = "NombreEquipo";
            cbMostrarPorEquipo.ValueMember = "IdEquipo";
        }


        private void MostrarJugadores(List<Jugadores> jugadores)
        {
            dgJugadores.DataSource = null;

            if (jugadores.Count == 0)
                return;

            List<object> lista = new List<object>();

            foreach (var j in jugadores)
            {
                string fechaNac = "";
                if (j.FechaNacimiento != null)
                    fechaNac = j.FechaNacimiento.Value.ToString("dd/MM/yyyy");

                string fechaReg = "";
                if (j.FechaRegistro != null)
                    fechaReg = j.FechaRegistro.Value.ToString("dd/MM/yyyy HH:mm");

                string nombreEquipo = "Sin equipo";
                if (j.Equipos != null && j.Equipos.NombreEquipo != null)
                    nombreEquipo = j.Equipos.NombreEquipo;

                lista.Add(new
                {
                    j.IdJugador,
                    j.Nombres,
                    j.Apellidos,
                    j.DNI,
                    FechaNacimiento = fechaNac,
                    FechaRegistro = fechaReg,
                    Equipo = nombreEquipo
                });
            }

            dgJugadores.DataSource = lista;
            dgJugadores.Columns["IdJugador"].Visible = false;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbEquipo.Text == "" || tbNombreJugador.Text == "" || tbApellidosJugador.Text == "" || tbDNI.Text == "" || dtpFechaNacimiento.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos.");
                return;
            }

            Jugadores jugador = new Jugadores()
            {
                Nombres = tbNombreJugador.Text,
                Apellidos = tbApellidosJugador.Text,
                DNI = tbDNI.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                IdEquipo = Convert.ToInt32(cbEquipo.SelectedValue),
                FechaRegistro = DateTime.Now
            };

            string mensaje = nJugador.Registrar(jugador);
            MessageBox.Show(mensaje);
            MostrarJugadores(nJugador.ListarTodo());

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cbEquipo.Text == "" || tbNombreJugador.Text == "" || tbApellidosJugador.Text == "" || tbDNI.Text == "" || dtpFechaNacimiento.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos.");
                return;
            }
            if (dgJugadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un jugador.");
                return;
            }

            int idJugador = Convert.ToInt32(dgJugadores.SelectedRows[0].Cells["IdJugador"].Value);

            Jugadores jugador = new Jugadores()
            {
                IdJugador = idJugador,
                Nombres = tbNombreJugador.Text,
                Apellidos = tbApellidosJugador.Text,
                DNI = tbDNI.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                IdEquipo = Convert.ToInt32(cbEquipo.SelectedValue)
            };

            string mensaje = nJugador.Modificar(jugador);
            MessageBox.Show(mensaje);
            MostrarJugadores(nJugador.ListarTodo());

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarJugadores(nJugador.ListarTodo());

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgJugadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un jugador.");
                return;
            }

            int idJugador = Convert.ToInt32(dgJugadores.SelectedRows[0].Cells["IdJugador"].Value);

            string mensaje = nJugador.Eliminar(idJugador);
            MessageBox.Show(mensaje);
            MostrarJugadores(nJugador.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrarPorEquipo_Click(object sender, EventArgs e)
        {
            if (cbMostrarPorEquipo.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un equipo.");
                return;
            }

            int idEquipo = Convert.ToInt32(cbMostrarPorEquipo.SelectedValue);
            var jugadoresFiltrados = nJugador.ListarPorEquipo(idEquipo);
            MostrarJugadores(jugadoresFiltrados);
        }

    }
}
