using LabMultilistas.entities;
using LabMultilistas.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabMultilistas
{
    public partial class FormCuadro : Form
    {
        private String codigoArtista;
        private CuadroService cuadroService = new CuadroService();

        public FormCuadro(String codigoArtista)
        {
            InitializeComponent();
            this.codigoArtista = codigoArtista;
            // Mostrar
            MostrarCuadros(cuadroService.ListarTodo(codigoArtista));
        }

        private void MostrarCuadros(List<Cuadro> cuadros)
        {
            dgCuadros.DataSource = null;
            if (cuadros.Count == 0)
            {
                return;
            }
            else
            {
                dgCuadros.DataSource = cuadros;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación
            if (tbCodigo.Text == "" || tbTitulo.Text == "" || cbCategoria.Text == "" || tbPrecio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Cuadro cuadro = new Cuadro()
            {
                Codigo = tbCodigo.Text,
                Titulo = tbTitulo.Text,
                Categoria = cbCategoria.Text,
                Precio = double.Parse(tbPrecio.Text)
            };

            // Registrar
            bool registrado = cuadroService.Registrar(codigoArtista, cuadro);
            if (!registrado)
            {
                MessageBox.Show("Código repetido");
                return;
            }

            // Mostrar
            MostrarCuadros(cuadroService.ListarTodo(codigoArtista));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
