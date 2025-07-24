using MantenimientoDePeliculas.entities;
using MantenimientoDePeliculas.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoDePeliculas
{
    public partial class FormMantenimientoCines : Form
    {
        private CineService cineService = new CineService();

        public FormMantenimientoCines()
        {
            InitializeComponent();
            // Mostramos
            MostrarCines(cineService.ListarTodo());
        }

        private void MostrarCines(List<Cine> cines)
        {
            dgCines.DataSource = null;

            if(cines.Count == 0)
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
            if(tbCodigo.Text == "" || tbNombre.Text == "" || tbDireccion.Text == "" || tbArea.Text == "" || tbGerente.Text == "" || tbRuc.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Cine lugar = new Cine()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Direccion = tbDireccion.Text,
                Area = double.Parse(tbArea.Text),
                Gerente = tbGerente.Text,
                RUC = tbRuc.Text,
            };

            bool registrado = cineService.Registrar(lugar);
            if(!registrado)
            {
                MessageBox.Show("Código ya existe");
                return;
            }

            MostrarCines(cineService.ListarTodo());

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarCines(cineService.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validación
            if(dgCines.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el registro a eliminar");
                return;
            }

            // Ubicate
            String codigo = dgCines.SelectedRows[0].Cells[0].Value.ToString();

            // Eliminamos
            cineService.Eliminar(codigo);

            // Demostramos
            MostrarCines(cineService.ListarTodo());
        }

        private void btnOrdenarGerente_Click(object sender, EventArgs e)
        {
            MostrarCines(cineService.OrdenarPorGerente());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(tbBuscar.Text == "")
            {
                MessageBox.Show("Ingrese el nombre");
                return;
            }

            String nombre = tbBuscar.Text;

            MostrarCines(cineService.BuscarPorNombre(nombre));
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            // Validación
            if(dgCines.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cine");
                return;
            }

            String codigoCine = dgCines.SelectedRows[0].Cells[0].Value.ToString();

            FormMantenimientoPeliculas form = new FormMantenimientoPeliculas(codigoCine);
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
