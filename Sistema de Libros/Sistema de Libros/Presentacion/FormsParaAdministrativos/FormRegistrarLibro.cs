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
    public partial class FormRegistrarLibro : Form {

        private NLibroAutor NLA = new NLibroAutor();
        private NLibro NL = new NLibro();
        private NAutor NA = new NAutor();
        private NAdministrador NAD = new NAdministrador();

        public FormRegistrarLibro() {
            InitializeComponent();

            lbl_nombreUsuario.Text = NAD.ObtenerUsuarioLogeado().Nombre +
                                      " " +
                                      NAD.ObtenerUsuarioLogeado().Apellido;

            cb_autor.DataSource = NA.ObtenerNombresDeAutores();
        }

        private void btn_registrarLibro_Click(object sender, EventArgs e) {

            if (tb_titulo.Text.Trim() == "") { return; MessageBox.Show("Ingrese todos los campos"); }
            if (cb_autor.Text.Trim() == "") { return; MessageBox.Show("Ingrese todos los campos"); }
            if (tb_genero.Text.Trim() == "") { return; MessageBox.Show("Ingrese todos los campos"); }
            if (tb_idioma.Text.Trim() == "") { return; MessageBox.Show("Ingrese todos los campos"); }
            if (tb_ubicacion.Text.Trim() == "") { return; MessageBox.Show("Ingrese todos los campos"); }

            
            Libros libro = new Libros() {
                Titulo = tb_titulo.Text.Trim(),
                Genero = tb_genero.Text.Trim(),
                Idioma = tb_idioma.Text.Trim(),
                FechaPublicacion = dtimepicker_fechaPublicacion.Value,
                CantidadPaginas = (int)numud_cantidadDePaginas.Value,
                Ubicacion = tb_ubicacion.Text.Trim(),
                Activo = true,
                Eliminado = false
            };

            

            int id_autor = NA.ObtenerAutor(cb_autor.Text).Id;
            
            string mensaje = NL.Registrar(libro);
            MessageBox.Show(mensaje);

            Libros lib = NL.ObtenerLibroPorTitulo(libro.Titulo);

            Console.WriteLine(id_autor);
            Console.Write(lib.Id);

            NLA.Registrar(lib.Id, id_autor);

        }

        private void btn_registrarAutor_Click(object sender, EventArgs e) {

        }
    }
}
