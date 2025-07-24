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

namespace Presentacion.FormsParaAdministrativos {
    public partial class FormRegistrarAdministrativos : Form {

        NAdministrador NA = new NAdministrador();

        public FormRegistrarAdministrativos() {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {

            
            if (tbRegistrarNombres.Text.Trim() == "" || tbRegistrarApellidos.Text.Trim() == "" || tb_codigo.Text.Trim() == "" || tbRegistrarContraseña.Text.Trim() == "") {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }


            Administradores administradores = new Administradores() {
                Contraseña = tbRegistrarContraseña.Text.Trim(),
                Nombre = tbRegistrarNombres.Text.Trim(),
                Apellido = tbRegistrarApellidos.Text.Trim(),
                Codigo = tb_codigo.Text.Trim()
            };

            
            string mensaje = NA.Registrar(administradores);
            MessageBox.Show(mensaje);

        }
    }
}
