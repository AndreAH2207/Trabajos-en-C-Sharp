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
    public partial class FormMantenimientoPeliculas : Form
    {
        private String codigoCine;
        private PeliculaService peliculaService = new PeliculaService();

        public FormMantenimientoPeliculas(string codigoCine)
        {
            InitializeComponent();
            this.codigoCine = codigoCine;
            //Mostrar
            MostrarPelicula(peliculaService.ListarTodo(codigoCine));
        }

        private void MostrarPelicula(List<Pelicula> peliculas)
        {
            dgPeliculas.DataSource = null;
            if(peliculas.Count == 0)
            {
                return;
            }
            else
            {
                dgPeliculas.DataSource = peliculas;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validez campos
            if(tbCodigo.Text == "" || tbTitulo.Text == "" || tbValoracion.Text == "" || tbGenero.Text == "" || tbDuracion.Text == "" || tbRecaudacion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación de objeto
            Pelicula pelicula = new Pelicula()
            {
                Codigo = tbCodigo.Text,
                Titulo = tbTitulo.Text,
                Valoracion = tbValoracion.Text,
                Genero = tbGenero.Text,
                Duracion = int.Parse(tbDuracion.Text),
                Recaudacion = double.Parse(tbRecaudacion.Text)
            };

            // Registrar
            bool registrado = peliculaService.Registrar(codigoCine, pelicula);
            if (!registrado)
            {
                MessageBox.Show("Código ya existe");
                return;
            }

           

            //Mostrar
            MostrarPelicula(peliculaService.ListarTodo(codigoCine));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validación
            if (dgPeliculas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el registro a eliminar");
                return;
            }

            // Ubicate
            String codigoPelicula = dgPeliculas.SelectedRows[0].Cells[0].Value.ToString();

            // Eliminar
            peliculaService.Eliminar(codigoCine, codigoPelicula);

            //Mostramos
            MostrarPelicula(peliculaService.ListarTodo(codigoCine));
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarPelicula(peliculaService.ListarTodo(codigoCine));
        }

        private void btnOrdenarDuracion_Click(object sender, EventArgs e)
        {
            MostrarPelicula(peliculaService.OrdenarPorDuracion(codigoCine));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
