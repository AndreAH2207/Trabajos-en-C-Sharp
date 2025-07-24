using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormProducto : Form
    {
        private NProducto nProducto = new NProducto();
        private int supermercadoId;

        public FormProducto(int supermercadoId)
        {
            InitializeComponent();
            this.supermercadoId = supermercadoId;
            MostrarProductos(nProducto.ListarTodo());
        }

        private void MostrarProductos(List<Producto> productos)
        {
            dgProductos.DataSource = null;
            if (productos.Count == 0)
            {
                return;
            }
            else
            {
                dgProductos.DataSource = productos;
                dgProductos.Columns["ProductoId"].Visible = false;
                dgProductos.Columns["ProductoxSupermercado"].Visible = false;
            }
        }

        private void btnBuscarPorMarca_Click(object sender, EventArgs e)
        {
            if (tbMarca.Text == "")
            {
                MessageBox.Show("Ingrese la marca");
                return;
            }

            String marca = tbMarca.Text;
            MostrarProductos(nProducto.BuscarPorMarca(marca));
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || cbCategoria.Text == "" || tbMarca.Text == "" || tbPrecio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Producto producto = new Producto()
            {
                Nombre = tbNombre.Text,
                Categoria = cbCategoria.Text,
                Marca = tbMarca.Text,
                Precio = decimal.Parse(tbPrecio.Text)
            };

            String mensaje = nProducto.Registrar(producto);
            MessageBox.Show(mensaje);

            MostrarProductos(nProducto.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Producto");
                return;
            }

            int id_producto = int.Parse(dgProductos.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nProducto.Eliminar(id_producto);
            MessageBox.Show(mensaje);

            MostrarProductos(nProducto.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Producto");
                return;
            }

            if (tbNombre.Text == "" || cbCategoria.Text == "" || tbMarca.Text == "" || tbPrecio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            int id_producto = int.Parse(dgProductos.SelectedRows[0].Cells[0].Value.ToString());
            Producto producto = new Producto()
            {
                ProductoId = id_producto,
                Nombre = tbNombre.Text,
                Categoria = cbCategoria.Text,
                Marca = tbMarca.Text,
                Precio = decimal.Parse(tbPrecio.Text)
            };

            String mensaje = nProducto.Modificar(producto);
            MessageBox.Show(mensaje);

            MostrarProductos(nProducto.ListarTodo());
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarProductos(nProducto.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
