using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Presentacion
{
    public partial class WindowConcesionario : Window
    {
        private NConcesionario nConcesionario = new NConcesionario();
        private EConcesionario concesionarioSeleccionado = null;

        public WindowConcesionario()
        {
            InitializeComponent();
            MostrarConcesionarios(nConcesionario.ListarTodo());
        }

        private void MostrarConcesionarios(List<EConcesionario> concesionarios)
        {
            dgConcesionarios.ItemsSource = null;
            dgConcesionarios.ItemsSource = concesionarios;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (tbCodigo.Text == "" || tbDueño.Text == "" || tbNombre.Text == "" || datePFechaInicio.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }

            EConcesionario concesionario = new EConcesionario()
            {
                Codigo = tbCodigo.Text,
                Dueño = tbDueño.Text,
                FechaInicio = DateTime.Parse(datePFechaInicio.Text),
                Nombre = tbNombre.Text,
                Vehiculos = new List<EVehiculo>()
            };

            bool registrado = nConcesionario.Registrar(concesionario);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro codigo");
                return;
            }

            MostrarConcesionarios(nConcesionario.ListarTodo());
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            MostrarConcesionarios(nConcesionario.ListarTodo());
        }

        private void btnVehiculos_Click(object sender, RoutedEventArgs e)
        {
            if (concesionarioSeleccionado == null)
            {
                MessageBox.Show("Seleccione un concesionario");
                return;
            }

            String codigo = concesionarioSeleccionado.Codigo;
            WindowVehiculo window = new WindowVehiculo(codigo);
            window.Show();
        }

        private void btnOrdenarXFecha_Click(object sender, RoutedEventArgs e)
        {
            MostrarConcesionarios(nConcesionario.OrdenarPorFecha());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgConcesionarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            concesionarioSeleccionado = dgConcesionarios.SelectedItem as EConcesionario;
        }
    }
}
