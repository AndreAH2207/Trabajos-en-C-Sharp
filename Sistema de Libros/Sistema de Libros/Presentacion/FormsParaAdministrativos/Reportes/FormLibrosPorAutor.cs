using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;


namespace Presentacion.FormsParaAdministrativos {
    public partial class FormLibrosPorAutor : Form {

        private NLibro nLibro = new NLibro();
        private NAutor nAutor = new NAutor();
        private NAdministrador NA = new NAdministrador();

        public FormLibrosPorAutor() {
            InitializeComponent();

            NUsuario nUsuario = new NUsuario();

            lbl_nombreEnSesion.Text = NA.ObtenerUsuarioLogeado().Nombre +
                                      " " +
                                      NA.ObtenerUsuarioLogeado().Apellido;

            cb_autor.DataSource = nAutor.ObtenerNombresDeAutores();
        }

        private void MostrarLibros(List<dynamic> libros) {

            dg_libros.DataSource = null;
            dg_libros.DataSource = libros;
        }


        private void cb_autor_SelectedIndexChanged(object sender, EventArgs e) {

            if (cb_autor.Text.Trim() == "") {

                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            string nombreCompleto = cb_autor.Text;

            Autores aut = nAutor.ObtenerAutor(nombreCompleto);

            MostrarLibros(nLibro.ObtenerLibrosPorAutor(aut));
        }
    }
}
