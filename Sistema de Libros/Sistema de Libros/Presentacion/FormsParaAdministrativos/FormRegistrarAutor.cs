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
    public partial class FormRegistrarAutor : Form {

        NAdministrador NA = new NAdministrador();
        NAutor nAutor = new NAutor();

        public FormRegistrarAutor() {
            InitializeComponent();

            lbl_nombreEnSesion.Text = NA.ObtenerUsuarioLogeado().Nombre +
                                      " " +
                                      NA.ObtenerUsuarioLogeado().Apellido;
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {

            // Verificación de campos vacíos
            if (tbRegistrarNombres.Text.Trim() == "" || tbRegistrarApellidos.Text.Trim() == "" || tbRegistrarNacionalidad.Text.Trim() == "") {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Autores autores = new Autores() {
                Nombre = tbRegistrarNombres.Text,
                Apellido = tbRegistrarApellidos.Text,
                Nacionalidad = tbRegistrarNacionalidad.Text
            };


            string mensaje = nAutor.Registrar(autores);
            MessageBox.Show(mensaje);
        }


    }
}
