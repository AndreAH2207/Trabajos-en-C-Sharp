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
    public partial class FormRegistrarCanchas : Form
    {
        private NCancha nCancha = new NCancha();
        public FormRegistrarCanchas()
        {
            InitializeComponent();
            MostrarCanchas(nCancha.ListarTodo());
        }

        private void MostrarCanchas(List<Canchas> canchas)
        {

            dgCanchas.DataSource = null;
            if (canchas.Count == 0)
            {
                return;
            }
            dgCanchas.DataSource = canchas;
            dgCanchas.Columns["IdCancha"].Visible = false;
            dgCanchas.Columns["Partidos"].Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombreCancha.Text == "" || tbUbicacionCancha.Text == "")
            {
                MessageBox.Show("Complete todos los campos obligatorios.");
                return;
            }

            Canchas cancha = new Canchas()
            {
                NombreCancha = tbNombreCancha.Text,
                Ubicacion = tbUbicacionCancha.Text,
            };

            string mensaje = nCancha.Registrar(cancha);
            MessageBox.Show(mensaje);
            MostrarCanchas(nCancha.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbNombreCancha.Text == "" || tbUbicacionCancha.Text == "")
            {
                MessageBox.Show("Complete todos los campos obligatorios.");
                return;
            }

            if (dgCanchas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione la cancha a modificar.");
                return;
            }

            int idCancha = Convert.ToInt32(dgCanchas.SelectedRows[0].Cells["IdCancha"].Value);

            Canchas cancha = new Canchas()
            {
                IdCancha = idCancha,
                NombreCancha = tbNombreCancha.Text,
                Ubicacion = tbUbicacionCancha.Text,
            };

            string mensaje = nCancha.Modificar(cancha);
            MessageBox.Show(mensaje);
            MostrarCanchas(nCancha.ListarTodo());
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarCanchas(nCancha.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgCanchas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione la cancha a eliminar.");
                return;
            }

            int id = Convert.ToInt32(dgCanchas.SelectedRows[0].Cells["IdCancha"].Value);

            string mensaje = nCancha.Eliminar(id);
            MessageBox.Show(mensaje);
            MostrarCanchas(nCancha.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
