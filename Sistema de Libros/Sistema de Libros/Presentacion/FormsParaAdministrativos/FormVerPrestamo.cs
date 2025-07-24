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
    public partial class FormVerPrestamo : Form {

        NPrestamos NP = new NPrestamos();
        NAdministrador NA = new NAdministrador();

        public FormVerPrestamo() {
            InitializeComponent();

            lbl_nombreEnSesion.Text = NA.ObtenerUsuarioLogeado().Nombre +
                                      " " +
                                      NA.ObtenerUsuarioLogeado().Apellido;
        }

        public void MostrarEnDg() {

            dg_prestamos.DataSource = null;

            dg_prestamos.DataSource = NP.PrestamosParaForm(numud_Dni.Value.ToString());
        }

        private void numud_Dni_ValueChanged(object sender, EventArgs e) {

            MostrarEnDg();
        }

        private void btn_verPrestamosConMultas_Click(object sender, EventArgs e) {

            FormVerEstadoDePrestamos frm = new FormVerEstadoDePrestamos();

            frm.Show();
        }
    }
}
