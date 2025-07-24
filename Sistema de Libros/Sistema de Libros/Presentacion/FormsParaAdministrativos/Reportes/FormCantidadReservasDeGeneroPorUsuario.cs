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

namespace Presentacion.FormsParaAdministrativos.Reportes {
    public partial class FormCantidadReservasDeGeneroPorUsuario : Form {

        private NUsuario NU = new NUsuario();
        private NLibro NL = new NLibro();
        private NAdministrador NA = new NAdministrador();

        public FormCantidadReservasDeGeneroPorUsuario() {
            InitializeComponent();

            lbl_nombreEnSesion.Text = NA.ObtenerUsuarioLogeado().Nombre +
                                      " " +
                                      NA.ObtenerUsuarioLogeado().Apellido;


            List<string> generos = new List<string>();
            List<string> dnis = new List<string>();

            foreach (Libros l in NL.ListarTodo()) {

                if ( !generos.Exists(g => g.Equals(l.Genero)) ) {
                    generos.Add(l.Genero);
                }                
            }

            foreach (Usuarios u in NU.ListarTodo()) {

                if (!dnis.Exists(d => d.Equals(u.Dni))) {
                    dnis.Add(u.Dni);
                }
            }

            cb_genero.DataSource = generos;
            cb_dniUsuario.DataSource = dnis;
        }

        private void cb_genero_SelectedIndexChanged(object sender, EventArgs e) {

            dg_genero.DataSource = null;
            dg_genero.DataSource = NU.CantidadReservasDeGeneroPorUsuario(cb_dniUsuario.Text, cb_genero.Text);
        }

        private void cb_dniUsuario_SelectedIndexChanged(object sender, EventArgs e) {
            
            dg_genero.DataSource = null;
            dg_genero.DataSource = NU.CantidadReservasDeGeneroPorUsuario(cb_dniUsuario.Text, cb_genero.Text);
        }
    }
}
