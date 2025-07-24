using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion {
    public partial class FormPrincipal : Form {
        public FormPrincipal() {
            InitializeComponent();
        }

        private void btn_rolUsuario_Click(object sender, EventArgs e) {

            FormsParaUsuarios.FormLoginUsuarios frm = new FormsParaUsuarios.FormLoginUsuarios();

            frm.Show();
        }

        private void btn_rolAdministrativo_Click(object sender, EventArgs e) {

            FormsParaAdministrativos.FormLoginAdministrativos frm = new FormsParaAdministrativos.FormLoginAdministrativos();

            frm.Show();
        }
    }
}
