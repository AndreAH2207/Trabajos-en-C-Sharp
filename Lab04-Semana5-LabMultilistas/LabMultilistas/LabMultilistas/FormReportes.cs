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
    public partial class FormReportes : Form
    {
        private ArtistaService artistaService = new ArtistaService();
        private CuadroService cuadroService = new CuadroService();

        public FormReportes()
        {
            InitializeComponent();
        }

        private void btnListarArtistasConCuadrosMasBaratos_Click(object sender, EventArgs e)
        {
            var artistas = artistaService.ListarArtistasXCuadrosMasBaratos();
            dgReporteArtistas.DataSource = artistas
                .Select(a => new
                {
                    Codigo = a.Codigo,
                    Seudonimo = a.Seudonimo,
                    Edad = a.Edad,
                    PrecioMasBarato = a.Cuadros.Min(c => c.Precio)
                })
                .ToList();
        }

        private void btnListarArtistasConMasCuadrosDeTipoDiferenteANormal_Click(object sender, EventArgs e)
        {
            var artistas = artistaService.ListarArtistasConMasCuadrosDeTipoDiferenteANormal();
            dgReporteArtistas.DataSource = artistas
                .Select(a => new
                {
                    Codigo = a.Codigo,
                    Seudonimo = a.Seudonimo,
                    Edad = a.Edad,
                    CuadrosEspeciales = a.Cuadros.Count(c => c.Categoria != "Normal")
                })
                .ToList();
        }

        private void btnBuscarCuadrosArtistasMenosJovenes_Click(object sender, EventArgs e)
        {
            var cuadros = cuadroService.BuscarCuadrosArtistasMenosJovenes();
            dgReporteCuadros.DataSource = cuadros
                .Select(c => new
                {
                    Codigo = c.Codigo,
                    Titulo = c.Titulo,
                    Categoria = c.Categoria,
                    Precio = c.Precio
                })
                .ToList();
        }

        private void btnBuscarCuadrosPorTitulo_Click(object sender, EventArgs e)
        {
            string titulo = tbTituloCuadros.Text.Trim();
            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("Ingrese un título para buscar.");
                return;
            }

            var resultados = cuadroService.BuscarCuadroPorTitulo(titulo);
            dgReporteCuadros.DataSource = resultados
                .Select(c => new
                {
                    Codigo = c.Codigo,
                    Titulo = c.Titulo,
                    Categoria = c.Categoria,
                    Precio = c.Precio
                })
                .ToList();

            if (resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron cuadros con ese título.");
            }
        }

        private void btnListarArtistasConMasCuadrosEnCategoria_Click(object sender, EventArgs e)
        {
            string categoria = tbReporteArtistas.Text.Trim();

            if (string.IsNullOrEmpty(categoria))
            {
                MessageBox.Show("Por favor ingrese una categoría para generar el reporte.");
                return;
            }

            var artistas = artistaService.ListarArtistasConMasCuadrosEnCategoria(categoria);

            if (artistas.Count == 0)
            {
                MessageBox.Show("No se encontraron artistas con cuadros en esta categoría.");
                return;
            }

            dgReporteArtistas.DataSource = artistas
                .Select(a => new
                {
                    Codigo = a.Codigo,
                    Seudonimo = a.Seudonimo,
                    Edad = a.Edad,
                    CuadrosEnCategoria = a.Cuadros.Count(c => c.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                })
                .ToList();
        }
    }
}
