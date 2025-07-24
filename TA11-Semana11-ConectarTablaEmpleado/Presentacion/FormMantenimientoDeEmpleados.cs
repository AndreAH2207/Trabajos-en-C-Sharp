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
    public partial class FormMantenimientoDeEmpleados : Form
    {
        private NEmpleado nEmpleado = new NEmpleado();
        public FormMantenimientoDeEmpleados()
        {
            InitializeComponent();
        }

        private void MostrarEmpleados(List<Empleado> empleados)
        {
            dgEmpleados.DataSource = null;

            if (empleados.Count == 0)
            {
                return;
            }

            dgEmpleados.DataSource = empleados;
            dgEmpleados.Columns["Id"].Visible = false;
            dgEmpleados.Columns["Estado"].Visible = false;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombreCompleto.Text == "" || cbArea.Text == "" || tbSueldo.Text == "" || dtpFechaNacimiento.Text == "")
            {
                MessageBox.Show("Rellene los campos");
                return;
            }

            decimal sueldo = 0;
            try
            {
                sueldo = decimal.Parse(tbSueldo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sueldo solo registra datos numéricos");
                return;
            }

            Empleado empleado = new Empleado()
            {
                NombreCompleto = tbNombreCompleto.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Area = cbArea.Text,
                Sueldo = sueldo
            };

            string mensaje = nEmpleado.Registrar(empleado);
            MessageBox.Show(mensaje);

            MostrarEmpleados(nEmpleado.ListarTodoActivo());
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            if (dgEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado");
                return;
            }
            int id = int.Parse(dgEmpleados.SelectedRows[0].Cells[0].Value.ToString());
            string mensaje = nEmpleado.EliminarLogico(id);
            MessageBox.Show(mensaje);
            MostrarEmpleados(nEmpleado.ListarTodoActivo());
        }

        private void btnListarEmpleados_Click(object sender, EventArgs e)
        {
            MostrarEmpleados(nEmpleado.ListarTodoActivo());
        }

        private void btnOrdenarSegunFechaNacimiento_Click(object sender, EventArgs e)
        {
            MostrarEmpleados(nEmpleado.OrdenarSegunFechaNacimiento());
        }

        private void btnBuscarPorArea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbBuscarPorArea.Text))
            {
                MessageBox.Show("Seleccione un área para buscar.");
                return;
            }

            string area = cbBuscarPorArea.Text;
            MostrarEmpleados(nEmpleado.BuscarPorArea(area));
        }
    }
}
