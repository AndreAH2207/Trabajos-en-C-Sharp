using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormSupermercado : Form
    {
        NSupermercado nSupermercado = new NSupermercado();

        public FormSupermercado()
        {
            InitializeComponent();
            MostrarSupermercados(nSupermercado.ListarTodo());
        }

        private void MostrarSupermercados(List<Supermercado> supermercados)
        {
            dgSupermercado.DataSource = null;
            if (supermercados.Count == 0)
            {
                return;
            }
            else
            {
                dgSupermercado.DataSource = supermercados;
                dgSupermercado.Columns["ProductoxSupermercado"].Visible = false;
                dgSupermercado.Columns["SupermercadoId"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombreReferencail.Text == "" || tbDireccion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Supermercado supermercado = new Supermercado()
            {
                NombreReferencial = tbNombreReferencail.Text,
                Direccion = tbDireccion.Text
            };

            String mensaje = nSupermercado.Registrar(supermercado);
            MessageBox.Show(mensaje);

            MostrarSupermercados(nSupermercado.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgSupermercado.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Supermercado");
                return;
            }

            int id_supermercado = int.Parse(dgSupermercado.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nSupermercado.Eliminar(id_supermercado);
            MessageBox.Show(mensaje);

            MostrarSupermercados(nSupermercado.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgSupermercado.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Supermercado");
                return;
            }

            if (tbNombreReferencail.Text == "" || tbDireccion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            int id_supermercado = int.Parse(dgSupermercado.SelectedRows[0].Cells[0].Value.ToString());
            Supermercado supermercado = new Supermercado()
            {
                SupermercadoId = id_supermercado,
                NombreReferencial = tbNombreReferencail.Text,
                Direccion = tbDireccion.Text
            };

            String mensaje = nSupermercado.Modificar(supermercado);
            MessageBox.Show(mensaje);

            MostrarSupermercados(nSupermercado.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarNombreReferencail_Click(object sender, EventArgs e)
        {
            if (tbNombreReferencail.Text == "")
            {
                MessageBox.Show("Ingrese el Nombre");
                return;
            }

            String nombreRef = tbNombreReferencail.Text;
            MostrarSupermercados(nSupermercado.BuscarPorNombreReferenciala(nombreRef));
        }

        private void btnVerProductos_Click_1(object sender, EventArgs e)
        {
            if (dgSupermercado.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            int codigoSupermercado = int.Parse(dgSupermercado.SelectedRows[0].Cells["SupermercadoId"].Value.ToString());
            FormProducto form = new FormProducto(codigoSupermercado);
            form.Show();
        }
    }
}
