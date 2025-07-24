using Presentacion.FormsParaAdministrativos.Reportes;
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
    public partial class FormMenuReportes : Form {

        private NAdministrador NA = new NAdministrador();

        public FormMenuReportes() {
            InitializeComponent();

            lbl_nombreEnSesion.Text = NA.ObtenerUsuarioLogeado().Nombre +
                                      " " +
                                      NA.ObtenerUsuarioLogeado().Apellido;
        }

        private void btn_verLibros_Click(object sender, EventArgs e) {

            FormLibrosPorAutor frm = new FormLibrosPorAutor();

            frm.Show();
        }

        private void btn_reservasPorUsuarioSegunGenero_Click(object sender, EventArgs e) {

            FormCantidadReservasDeGeneroPorUsuario frm;
            frm = new FormCantidadReservasDeGeneroPorUsuario();

            frm.Show();
        }

        private void btn_librosPorEstado_Click(object sender, EventArgs e) {

            FormLibrosConEstadoDeficiente frm = new FormLibrosConEstadoDeficiente();

            frm.Show();
        }

        private void btn_verMultas_Click(object sender, EventArgs e) {

            Reportes.FormMultasPendientesPagadas frm = new FormMultasPendientesPagadas();

            frm.Show();
        }
    }
}
