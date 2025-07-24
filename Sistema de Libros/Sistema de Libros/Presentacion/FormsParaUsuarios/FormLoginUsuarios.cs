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


namespace Presentacion.FormsParaUsuarios {
    public partial class FormLoginUsuarios : Form {

        private NUsuario nUsuario = new NUsuario();

        public FormLoginUsuarios() {
            InitializeComponent();
        }
        private void btn_login_Click(object sender, EventArgs e) {

            string dni = numud_Dni.Text;
            string contraseña = tbContrasenia.Text;


            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(contraseña)) {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try {
                Usuarios usuario = nUsuario.Login(dni, contraseña);

                if (usuario != null) {

                    nUsuario.AsignarUsuarioLogeado(usuario);

                    MessageBox.Show($"Bienvenido {usuario.Nombre} {usuario.Apellido}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            FormRegistrarUsuarios frm = new FormRegistrarUsuarios();
            frm.Show();
        }

    }
}
