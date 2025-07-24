using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace Presentacion.FormsParaAdministrativos {
    public partial class FormAsignarEstado : Form {

        NLibro NL = new NLibro();
        NAdministrador NA = new NAdministrador();
        NAutor NAUTOR = new NAutor();
        

        public FormAsignarEstado() {
            InitializeComponent();

            lbl_nombreEnSesion.Text = NA.ObtenerUsuarioLogeado().Nombre +
                                      " " +
                                      NA.ObtenerUsuarioLogeado().Apellido;

            cbGenero.DataSource = NL.ObtenerGeneros();
            cbAutor.DataSource = NAUTOR.ObtenerNombresDeAutores();
            cbIdioma.DataSource = NL.ObtenerIdiomas();
        }

        private void dgBuscarLibro_SelectionChanged(object sender, EventArgs e) {

            
            
        }

        private void btnFiltrar_Click(object sender, EventArgs e) {

            if (cbGenero.Text == "") { return; }
            if (cbAutor.Text == "") { return; }
            if (cbIdioma.Text == "") { return; }


            string genero = cbGenero.Text.ToString();
            string autor = cbAutor.Text.ToString();
            string idioma = cbIdioma.Text.ToString();
            DateTime fechaInicio = dttimepicker_desde.Value;
            DateTime fechaFin = dttimepicker_hasta.Value;

            DLibro dLibro = new DLibro();
            var libros = dLibro.BuscarLibros(genero, autor, idioma, fechaInicio, fechaFin);

            dgBuscarLibro.DataSource = libros;

        }

        private void btnAsignarEstado_Click(object sender, EventArgs e) {

            string titulo = dgBuscarLibro.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show(titulo);
            string nuevoEstado = comboBoxEstado.Text.ToString();


            Libros libro = NL.ObtenerLibroPorTitulo(titulo);

            bool resultado = NL.ActualizarEstadoLibro(libro.Titulo.ToString(), nuevoEstado);

            if (resultado) {
                MessageBox.Show("El estado del ejemplar se actualizó correctamente.");

                btnFiltrar_Click(sender, e);
            }
            else {
                MessageBox.Show("No se pudo actualizar el estado del ejemplar.");
            }
        }
    }
}
