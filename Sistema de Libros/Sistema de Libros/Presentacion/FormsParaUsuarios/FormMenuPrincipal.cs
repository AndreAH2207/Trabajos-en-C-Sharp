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

namespace Presentacion.FormsParaUsuarios {
    public partial class FormMenuPrincipal : Form {

        NUsuario nUsuario = new NUsuario();

        public FormMenuPrincipal() {
            InitializeComponent();

            lbl_nombreUsuarioEnSesion.Text = nUsuario.ObtenerUsuarioLogeado().Nombre +
                                      " " +
                                      nUsuario.ObtenerUsuarioLogeado().Apellido;
        }

        private void btn_reservarLibro_Click(object sender, EventArgs e) {

            FormReservarLibro frm = new FormReservarLibro();

            frm.Show();
        }
    }
}
