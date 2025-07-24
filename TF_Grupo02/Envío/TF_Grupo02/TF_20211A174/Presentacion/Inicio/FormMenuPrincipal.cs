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
    public partial class FormMenuPrincipal : Form
    {
        private Usuarios usuarioActual;
        private NUsuario nUsuario = new NUsuario();

        public FormMenuPrincipal(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void btnRegistrarTorneo_Click(object sender, EventArgs e)
        {
            FormRegistrarTorneos form = new FormRegistrarTorneos(usuarioActual.IdUsuario);
            form.Show();
        }

        private void btnRegistrarEquipos_Click(object sender, EventArgs e)
        {
            FormRegistrarEquipos form = new FormRegistrarEquipos();
            form.Show();
        }

        private void btnRegistrarJugadores_Click(object sender, EventArgs e)
        {
            FormRegistrarJugadores form = new FormRegistrarJugadores();
            form.Show();
        }

        private void btnRegistrarCanchas_Click(object sender, EventArgs e)
        {
            FormRegistrarCanchas form = new FormRegistrarCanchas();
            form.Show();
        }

        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            FormRegistrarInscripciones form = new FormRegistrarInscripciones();
            form.Show();
        }

        private void btnGenerarFixture_Click(object sender, EventArgs e)
        {
            FormGenerarFixture form = new FormGenerarFixture();
            form.Show();
        }

        private void btnEstadisticasJugadores_Click(object sender, EventArgs e)
        {
            FormEstadisticasJugador form = new FormEstadisticasJugador();
            form.Show();
        }

        private void btnRegistrarResultados_Click(object sender, EventArgs e)
        {
            FormRegistrarResultados form = new FormRegistrarResultados();
            form.Show();
        }


        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes form = new FormReportes();
            form.Show();
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sesión cerrada");
            this.Close();
            FormLogin form = new FormLogin();
            form.Show();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormEstadisticaEquipo form = new FormEstadisticaEquipo();
            form.Show();
        }

        private void btnResumenTorneo_Click(object sender, EventArgs e)
        {
            FormResumenTorneo form = new FormResumenTorneo();
            form.Show();
        }
    }
}
