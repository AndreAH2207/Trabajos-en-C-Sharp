using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormLogin : Form
    {
        private NUsuario nUsuario = new NUsuario();

        public FormLogin()
        {
            InitializeComponent();
            tbContrasenia.UseSystemPasswordChar = true;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            string correo = tbCorreo.Text.Trim();
            string clave = tbContrasenia.Text.Trim();

            Usuarios usuario = nUsuario.LoginUsuario(correo, clave);

            if (usuario != null)
            {
                MessageBox.Show("Bienvenido " + usuario.NombreCompleto);

                this.Hide();
                FormMenuPrincipal formMenu = new FormMenuPrincipal(usuario);

                formMenu.FormClosed += (s, args) => Application.Exit();
                formMenu.Show();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistrarUsuario form = new FormRegistrarUsuario();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
