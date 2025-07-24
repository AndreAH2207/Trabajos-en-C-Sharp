using Datos;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Data;

namespace Presentacion
{
    public partial class FormProductoxSupermercado : Form
    {
        private NProductoxSupermercado nProductoxSupermercado = new NProductoxSupermercado();
        private NProducto nProducto = new NProducto();
        private NSupermercado nSupermercado = new NSupermercado();

        public FormProductoxSupermercado()
        {
            InitializeComponent();
            MostarProductos(nProducto.ListarTodo());
            MostarSupermercados(nSupermercado.ListarTodo());
            MostrarProductoxSupermercado(nProductoxSupermercado.ListarTodo());
        }

        private void MostarProductos(List<Producto> productos)
        {
            cbidProducto.DataSource = null;
            if (productos.Count == 0)
            {
                return;
            }
            else
            {
                cbidProducto.DataSource = productos;
                cbidProducto.DisplayMember = "Nombre";
                cbidProducto.ValueMember = "ProductoId";
            }
        }

        private void MostarSupermercados(List<Supermercado> supermercados)
        {
            cbidSupermercado.DataSource = null;
            if (supermercados.Count == 0)
            {
                return;
            }
            else
            {
                cbidSupermercado.DataSource = supermercados;
                cbidSupermercado.DisplayMember = "NombreReferencial";
                cbidSupermercado.ValueMember = "SupermercadoId";
            }
        }

        private void MostrarProductoxSupermercado(List<ProductoxSupermercado> lista)
        {
            dgProductoxSupermercado.Columns.Clear(); 
            dgProductoxSupermercado.Rows.Clear(); 

            var productos = nProducto.ListarTodo();
            var supermercados = nSupermercado.ListarTodo();

            dgProductoxSupermercado.Columns.Add("ProductoId", "ID Producto");
            dgProductoxSupermercado.Columns["ProductoId"].Visible = false; 

            dgProductoxSupermercado.Columns.Add("NombreProducto", "Producto");

            dgProductoxSupermercado.Columns.Add("SupermercadoId", "ID Supermercado");
            dgProductoxSupermercado.Columns["SupermercadoId"].Visible = false; 

            dgProductoxSupermercado.Columns.Add("NombreSupermercado", "Supermercado");

            dgProductoxSupermercado.Columns.Add("Stock", "Stock");

            foreach (var item in lista)
            {
                string nombreProducto = "";
                string nombreSupermercado = "";

                Producto productoEncontrado = productos.FirstOrDefault(p => p.ProductoId == item.ProductoId);
                if (productoEncontrado != null)
                {
                    nombreProducto = productoEncontrado.Nombre;
                }

                Supermercado supermercadoEncontrado = supermercados.FirstOrDefault(s => s.SupermercadoId == item.SupermercadoId);
                if (supermercadoEncontrado != null)
                {
                    nombreSupermercado = supermercadoEncontrado.NombreReferencial;
                }

                dgProductoxSupermercado.Rows.Add(item.ProductoId, nombreProducto, item.SupermercadoId, nombreSupermercado, item.Stock);
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (cbidProducto.Text == "" || cbidSupermercado.Text == "" || tbStock.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos");
                return;
            }

            int productoId = int.Parse(cbidProducto.SelectedValue.ToString());
            int supermercadoId = int.Parse(cbidSupermercado.SelectedValue.ToString());

            ProductoxSupermercado productoxSupermercado = new ProductoxSupermercado()
            {
                ProductoId = productoId,
                SupermercadoId = supermercadoId,
                Stock = int.Parse(tbStock.Text)
            };

            String mensaje = nProductoxSupermercado.Asignar(productoxSupermercado);
            MessageBox.Show(mensaje);

            MostrarProductoxSupermercado(nProductoxSupermercado.ListarTodo());
        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            if(dgProductoxSupermercado.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una asignación");
                return;
            }

            var fila = dgProductoxSupermercado.SelectedRows[0];
            int productoId = Convert.ToInt32(fila.Cells["ProductoId"].Value);
            int supermercadoId = Convert.ToInt32(fila.Cells["SupermercadoId"].Value);

            string mensaje = nProductoxSupermercado.Desasignar(productoId, supermercadoId);
            MessageBox.Show(mensaje);

            MostrarProductoxSupermercado(nProductoxSupermercado.ListarTodo());
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarProductoxSupermercado(nProductoxSupermercado.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
