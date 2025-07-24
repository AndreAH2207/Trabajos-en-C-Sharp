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
    public partial class FormBuscarLibro : Form {


        NLibro NL = new NLibro();
        NAdministrador NA = new NAdministrador();
        NAutor NAUTOR = new NAutor();

        public FormBuscarLibro() {
            InitializeComponent();


            lbl_nombreEnSesion.Text = NA.ObtenerUsuarioLogeado().Nombre +
                                      " " +
                                      NA.ObtenerUsuarioLogeado().Apellido;

            cbGenero.DataSource = NL.ObtenerGeneros();
            cbAutor.DataSource = NAUTOR.ObtenerNombresDeAutores();
            cbIdioma.DataSource = NL.ObtenerIdiomas();

        }

        private void btnFiltrar_Click(object sender, EventArgs e) {

            if (cbGenero.Text == "" ) {return;}
            if (cbAutor.Text == "" ) {return;}
            if (cbIdioma.Text == "" ) {return;}

            
            string genero = cbGenero.Text.ToString();
            string autor = cbAutor.Text.ToString();
            string idioma = cbIdioma.Text.ToString();
            DateTime fechaInicio = dttimepicker_desde.Value;
            DateTime fechaFin = dttimepicker_hasta.Value;

            DLibro dLibro = new DLibro();
            var libros = dLibro.BuscarLibros(genero, autor, idioma, fechaInicio, fechaFin);

            dgBuscarLibro.DataSource = libros;

        }
    }
}
