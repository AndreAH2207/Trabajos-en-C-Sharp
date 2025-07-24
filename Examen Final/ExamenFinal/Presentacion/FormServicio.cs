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
    public partial class FormServicio : Form
    {
        private NMecanico nMecanico = new NMecanico();
        private NServicio nServicio = new NServicio();
        private NVehiculo nVehiculo = new NVehiculo();

        public FormServicio()
        {
            InitializeComponent();
            MostrarMecanicos(nMecanico.ListarTodo());
            MostrarServicio(nServicio.ListarTodo());
            MostrarVehiculo(nVehiculo.ListarTodo());
        }

        private void MostrarMecanicos(List<Mecanico> mecanicos)
        {
            cbMecanico.DataSource = null;

            if(mecanicos.Count > 0)
            {
                cbMecanico.DataSource = mecanicos;
                cbMecanico.DisplayMember = "NombreCompleto";
                cbMecanico.ValueMember = "MecanicoId";
            }
        }
        private void MostrarVehiculo(List<Vehiculo> vehiculos)
        {
            cbVehiculo.DataSource = null;

            if (vehiculos.Count > 0)
            {
                cbVehiculo.DataSource = vehiculos;
                cbVehiculo.DisplayMember = "Placa";
                cbVehiculo.ValueMember = "VehiculoId";
            }
        }

        private void MostrarServicio(List<Servicio> servicios)
        {
            dgServicio.DataSource = null;
            if(servicios.Count > 0)
            {
                dgServicio.DataSource = servicios;
                dgServicio.Columns["Vehiculo"].Visible = false;
                dgServicio.Columns["Mecanico"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbTipoServicio.Text == "" || cbMecanico.Text == "" || cbVehiculo.Text == "" || dtpFechaHoraServicio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
            }

            int vehiculoId = int.Parse(cbVehiculo.SelectedValue.ToString());
            int mecanicoId = int.Parse(cbMecanico.SelectedValue.ToString());

            Servicio servicio = new Servicio()
            {
                VehiculoId = vehiculoId,
                MecanicoId = mecanicoId,
                TipoServicio = tbTipoServicio.Text,
                FechaHoraServicio = dtpFechaHoraServicio.Value,
                FechaCreacion = DateTime.Now,
            };

            string mensaje = nServicio.Registrar(servicio);
            MessageBox.Show(mensaje);

            MostrarServicio(nServicio.ListarTodo());
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cbMecanico.Text == "" || cbVehiculo.Text == "" || dtpFechaHoraServicio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos"); return;
            }

            if(dgServicio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro"); return;
            }

            int vehiculoId = int.Parse(cbVehiculo.SelectedValue.ToString());
            int mecanicoId = int.Parse(cbMecanico.SelectedValue.ToString());
            int servicioId = int.Parse(dgServicio.SelectedRows[0].Cells["ServicioId"].Value.ToString());

            Servicio servicio = new Servicio()
            {
                ServicioId = servicioId,
                VehiculoId = vehiculoId,
                MecanicoId = mecanicoId,
                FechaHoraServicio = dtpFechaHoraServicio.Value,
            };

            string mensaje = nServicio.Modificar(servicio);
            MessageBox.Show(mensaje);

            MostrarServicio(nServicio.ListarTodo());

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgServicio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro"); return;
            }


            int servicioId = int.Parse(dgServicio.SelectedRows[0].Cells["ServicioId"].Value.ToString());

            string mensaje = nServicio.Eliminar(servicioId);
            MessageBox.Show(mensaje);

            MostrarServicio(nServicio.ListarTodo());
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (dgServicio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro"); return;
            }

            int servicioId = int.Parse(dgServicio.SelectedRows[0].Cells["ServicioId"].Value.ToString());

            Servicio servicio = new Servicio()
            {
                ServicioId = servicioId,
            };

            string mensaje = nServicio.Atender(servicio);
            MessageBox.Show(mensaje);

            MostrarServicio(nServicio.ListarTodo());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes form = new FormReportes();
            form.Show();
        }

    }
}
