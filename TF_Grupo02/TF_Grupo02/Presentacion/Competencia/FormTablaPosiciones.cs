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
    public partial class FormTablaPosiciones : Form
    {
        private NTorneo nTorneo = new NTorneo();
        private NResumenEstadisticaEquipo nResumen = new NResumenEstadisticaEquipo();
        private NEquipo nEquipo = new NEquipo();


        public FormTablaPosiciones()
        {
            InitializeComponent();
            CargarTorneos();

        }

        private void CargarTorneos()
        {
            var torneos = nTorneo.ListarTodo()
                .Where(t => t.Estado == "En curso" || t.Estado == "Finalizado")
                .ToList();

            cbTorneo.DataSource = torneos;
            cbTorneo.DisplayMember = "NombreTorneo";
            cbTorneo.ValueMember = "IdTorneo";
        }

        private void btnVerTabla_Click(object sender, EventArgs e)
        {
            if (cbTorneo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un torneo.");
                return;
            }

            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            var posiciones = nResumen.ObtenerPorTorneo(idTorneo);

            dgTablaPosiciones.DataSource = null;
            dgTablaPosiciones.DataSource = posiciones;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
