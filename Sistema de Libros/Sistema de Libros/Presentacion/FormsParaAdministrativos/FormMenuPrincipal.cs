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

namespace Presentacion.FormsParaAdministrativos {
    public partial class FormMenuPrincipal : Form {

        NAdministrador NA = new NAdministrador();

        public FormMenuPrincipal() {
            InitializeComponent();


            lbl_nombreEnSesion.Text = NA.ObtenerUsuarioLogeado().Nombre +
                                      " " +
                                      NA.ObtenerUsuarioLogeado().Apellido;
        }

        private void btn_reportes_Click(object sender, EventArgs e) {

            FormMenuReportes frm = new FormMenuReportes();

            frm.Show();
        }

        private void btn_verPrestamo_Click(object sender, EventArgs e) {

            FormVerPrestamo frm = new FormVerPrestamo();

            frm.Show();
        }

        private void btn_registrarLibro_Click(object sender, EventArgs e) {

            FormRegistrarLibro frm = new FormRegistrarLibro();

            frm.Show();
        }

        private void btn_registrarAutor_Click(object sender, EventArgs e) {

            FormRegistrarAutor frm = new FormRegistrarAutor();

            frm.Show();
        }

        private void btn_buscarLibro_Click(object sender, EventArgs e) {

            FormBuscarLibro frm = new FormBuscarLibro();

            frm.Show();
        }

        private void btn_asignarEstado_Click(object sender, EventArgs e) {

            FormAsignarEstado frm = new FormAsignarEstado();

            frm.Show();
        }
    }
}
