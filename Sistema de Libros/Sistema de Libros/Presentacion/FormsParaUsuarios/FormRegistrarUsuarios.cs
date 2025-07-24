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
    public partial class FormRegistrarUsuarios : Form {

        private NUsuario nUsuario = new NUsuario();

        public FormRegistrarUsuarios() {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            // Verificación de campos vacíos
            if (tbRegistrarNombres.Text.Trim() == "" || tbRegistrarApellidos.Text.Trim() == "" || tbRegistrarCorreo.Text.Trim() == "" || numud_telefono.Value == 0 || tbRegistrarPais.Text.Trim() == "" || tbRegistrarCiudad.Text.Trim() == "" || numud_Dni.Text.Trim() == "" || tbRegistrarContraseña.Text.Trim() == "") {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Crear el objeto Usuario
            Usuarios usuario = new Usuarios() {
                Contraseña = tbRegistrarContraseña.Text.Trim(),
                Nombre = tbRegistrarNombres.Text.Trim(),
                Apellido = tbRegistrarApellidos.Text.Trim(),
                Dni = numud_Dni.Text.Trim(),
                Correo = tbRegistrarCorreo.Text.Trim(),
                Telefono = numud_telefono.Value.ToString(),
                Pais = tbRegistrarPais.Text.Trim(),
                Ciudad = tbRegistrarCiudad.Text.Trim()
            };

            // Registrar el usuario y mostrar el mensaje
            string mensaje = nUsuario.Registrar(usuario);
            MessageBox.Show(mensaje);
        }

        private void FormRegistrarUsuarios_Load(object sender, EventArgs e) {

        }
    }
}
