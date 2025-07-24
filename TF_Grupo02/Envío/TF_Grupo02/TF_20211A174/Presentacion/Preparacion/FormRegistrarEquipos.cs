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
    public partial class FormRegistrarEquipos : Form
    {
        private NEquipo nEquipo = new NEquipo();
        public FormRegistrarEquipos()
        {
            InitializeComponent();
            MostrarEquipos(nEquipo.ListarTodo());
        }

        private void MostrarEquipos(List<Equipos> equipos)
        {
            dgEquipos.DataSource = null;
            if (equipos.Count == 0)
            {
                return;
            }
            dgEquipos.DataSource = equipos;
            dgEquipos.Columns["IdEquipo"].Visible = false;
            dgEquipos.Columns["Inscripciones"].Visible = false;
            dgEquipos.Columns["Jugadores"].Visible = false;
            dgEquipos.Columns["Partidos"].Visible = false;
            dgEquipos.Columns["Partidos1"].Visible = false;
            dgEquipos.Columns["Partidos2"].Visible = false;
            dgEquipos.Columns["ResumenEstadisticasEquipo"].Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombreEquipo.Text == "" || tbTelefonoContacto.Text == "" || tbCorreoElectronico.Text == "" || tbDireccionEquipo.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Equipos equipo = new Equipos()
            {
                NombreEquipo = tbNombreEquipo.Text,
                TelefonoEquipo = tbTelefonoContacto.Text,
                CorreoEquipo = tbCorreoElectronico.Text,
                DireccionEquipo = tbDireccionEquipo.Text,
                FechaRegistro = DateTime.Now
            };

            string mensaje = nEquipo.Registrar(equipo);
            MessageBox.Show(mensaje);
            MostrarEquipos(nEquipo.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgEquipos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un equipo");
                return;
            }

            if (tbNombreEquipo.Text == "" || tbTelefonoContacto.Text == "" || tbCorreoElectronico.Text == "" || tbDireccionEquipo.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            int IdEquipo = int.Parse(dgEquipos.SelectedRows[0].Cells["IdEquipo"].Value.ToString());
            Equipos equipo = new Equipos()
            {
                IdEquipo = IdEquipo,
                NombreEquipo = tbNombreEquipo.Text,
                TelefonoEquipo = tbTelefonoContacto.Text,
                CorreoEquipo = tbCorreoElectronico.Text,
                DireccionEquipo = tbDireccionEquipo.Text,
            };

            string mensaje = nEquipo.Modificar(equipo);
            MessageBox.Show(mensaje);
            MostrarEquipos(nEquipo.ListarTodo());
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarEquipos(nEquipo.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgEquipos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un equipo");
                return;
            }

            int idEquipo = Convert.ToInt32(dgEquipos.SelectedRows[0].Cells["IdEquipo"].Value);

            string mensaje = nEquipo.Eliminar(idEquipo);
            MessageBox.Show(mensaje);
            MostrarEquipos(nEquipo.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
