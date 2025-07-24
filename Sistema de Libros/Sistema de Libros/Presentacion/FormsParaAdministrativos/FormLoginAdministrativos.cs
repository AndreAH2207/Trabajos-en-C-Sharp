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
    public partial class FormLoginAdministrativos : Form {

        NAdministrador NA = new NAdministrador();        

        public FormLoginAdministrativos() {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e) {

            string codigo = tbCodigo.Text;
            string contraseña = tbContrasenia.Text;


            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(contraseña)) {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try {
                Administradores administrador = NA.Login(codigo, contraseña);

                if (administrador != null) {

                    NA.AsignarUsuarioLogeado(administrador);

                    MessageBox.Show($"Bienvenido {administrador.Nombre} {administrador.Apellido}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormMenuPrincipal form = new FormMenuPrincipal();

                    form.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Usuario o contraseña incorrectos. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ocurrió un error al intentar iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_registrar_Click(object sender, EventArgs e) {

            FormRegistrarAdministrativos frm = new FormRegistrarAdministrativos();

            frm.Show();
        }
    }
}
