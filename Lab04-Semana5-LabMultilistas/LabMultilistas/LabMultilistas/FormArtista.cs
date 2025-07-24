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
    public partial class FormArtista : Form
    {
        private ArtistaService artistaService = new ArtistaService();

        public FormArtista()
        {
            InitializeComponent();
            // Mostrar
            MostrarArtistas(artistaService.ListarTodo());
        }

        private void MostrarArtistas(List<Artista> artistas)
        {
            dgArtistas.DataSource = null;
            if (artistas.Count == 0)
            {
                return;
            }
            else
            {
                dgArtistas.DataSource = artistas;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación
            if (tbCodigo.Text == "" || tbSeudonimo.Text == "" || tbEdad.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Artista artista = new Artista()
            {
                Codigo = tbCodigo.Text,
                Seudonimo = tbSeudonimo.Text,
                Edad = int.Parse(tbEdad.Text),
                // Importante
                Cuadros = new List<Cuadro>()
            };

            // Registro
            bool registrado = artistaService.Registrar(artista);
            if (!registrado)
            {
                MessageBox.Show("Código repetido");
                return;
            }

            // Mostrar
            MostrarArtistas(artistaService.ListarTodo());
        }

        private void btnVerCuadros_Click(object sender, EventArgs e)
        {
            // Validación
            if (dgArtistas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un artista");
                return;
            }

            // Primera columna de la primera fila
            String codigoArtista = dgArtistas.SelectedRows[0].Cells[0].Value.ToString();

            FormCuadro form = new FormCuadro(codigoArtista);
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReportes form = new FormReportes();
            form.Show();
        }
    }
}
