using Lab02_Semana3_SistemaDeMantenimientoDeCines.Entities;
using Lab02_Semana3_SistemaDeMantenimientoDeCines.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Semana3_SistemaDeMantenimientoDeCines
{
    public partial class FormMain : Form
    {
        private CineServices cineServices = new CineServices();
        public FormMain()
        {
            InitializeComponent();
        }

        private void MostrarCines(List<Cine> cines)
        {
            dgCines.DataSource = null;

            if (cines.Count == 0)
            {
                return;
            }
            else
            {
                dgCines.DataSource = cines;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbDireccion.Text == "" ||
                tbArea.Text == "" || tbGerente.Text == "" ||
                tbNumeroSalas.Text == "" || tbSitioWeb.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Cine cine = new Cine()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Direccion = tbDireccion.Text,
                Area = double.Parse(tbArea.Text),
                Gerente = tbGerente.Text,
                NumeroSalas = int.Parse(tbNumeroSalas.Text),
                SitioWeb = tbSitioWeb.Text
            };

            bool registrado = cineServices.Registrar(cine);
            if(!registrado)
            {
                MessageBox.Show("Codigo ya existe");
                return ;
            }
            MostrarCines(cineServices.ListarTodo());

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarCines(cineServices.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgCines.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }
            string codigo = dgCines.SelectedRows[0].Cells[0].Value.ToString();
            cineServices.Eliminar(codigo);
            MostrarCines(cineServices.ListarTodo());
        }

        private void btnBuscarXDireccion_Click(object sender, EventArgs e)
        {
            if(tbBuscarXDireccion.Text == "")
            {
                MessageBox.Show("Ingrese direccion");
                return;
            }

            string direccion = tbBuscarXDireccion.Text;

            MostrarCines(cineServices.BuscarPorDireccion(direccion));
        }
        private void btnOrdenarXArea_Click(object sender, EventArgs e)
        {
            MostrarCines(cineServices.OrdenarPorArea());
        }
    }
}
