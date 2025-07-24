using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para WindowVehiculo.xaml
    /// </summary>
    public partial class WindowVehiculo : Window
    {
        private String codigo;
        private NVehiculo nVehiculo = new NVehiculo();

        public WindowVehiculo(String codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            MostrarVehiculos(nVehiculo.ListarTodo(codigo));
        }

        private void MostrarVehiculos(List<EVehiculo> vehiculos)
        {
            dgVehiculos.ItemsSource = null;
            dgVehiculos.ItemsSource = vehiculos;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if(tbPlaca.Text == "" || tbMarca.Text == "" || tbModelo.Text == "" || tbPrecio.Text == "" || tbKilometraje.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }

            EVehiculo vehiculo = new EVehiculo()
            {
                Placa = tbPlaca.Text,
                Marca = tbMarca.Text,
                Modelo = tbModelo.Text,
                Precio = double.Parse(tbPrecio.Text),
                Kilometraje = double.Parse(tbKilometraje.Text)
            };

            bool registrado = nVehiculo.Registrar(codigo, vehiculo);
            if(!registrado)
            {
                MessageBox.Show("Seleccione otro concesionario, placa o vehiculo");
                return;
            }

            MostrarVehiculos(nVehiculo.ListarTodo(codigo));
        }

        private void btnListarTodo_Click(object sender, RoutedEventArgs e)
        {
            MostrarVehiculos(nVehiculo.ListarTodo(codigo));
        }

        private void btnOrdenarPorPrecio_Click(object sender, RoutedEventArgs e)
        {
            MostrarVehiculos(nVehiculo.OrdenarPorPrecio(codigo));
        }

        private void btnSalir_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
