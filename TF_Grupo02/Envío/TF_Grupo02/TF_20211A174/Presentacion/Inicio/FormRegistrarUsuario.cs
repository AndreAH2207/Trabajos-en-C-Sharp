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
    public partial class FormRegistrarUsuario : Form
    {
        private NUsuario nUsuario = new NUsuario();
        public FormRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación simple
            if (tbNombreCompleto.Text == "" || tbCorreo.Text == "" || tbClaveHash.Text == "") 
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuarios nuevoUsuario = new Usuarios
            {
                NombreCompleto = tbNombreCompleto.Text,
                Correo = tbCorreo.Text,
                ClaveHash = tbClaveHash.Text,
                FechaRegistro = DateTime.Now
            };

            string resultado = nUsuario.Registrar(nuevoUsuario);

            if (resultado == "Registrado correctamente")
            {
                MessageBox.Show("Usuario registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }     
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
