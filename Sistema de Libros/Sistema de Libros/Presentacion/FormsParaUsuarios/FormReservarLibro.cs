using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;


namespace Presentacion.FormsParaUsuarios {
    public partial class FormReservarLibro : Form {

        NUsuario NU = new NUsuario();
        NReserva NR = new NReserva();
        NLibro NL = new NLibro();

        public FormReservarLibro() {
            InitializeComponent();

            lbl_nombresesion.Text = NU.ObtenerUsuarioLogeado().Nombre +
                                      " " +
                                      NU.ObtenerUsuarioLogeado().Apellido;

            cbTitulo.DataSource = NL.ObtenerTitulos();
        }


        private void brn_reservar_Click(object sender, EventArgs e) {

            if (cbTitulo.SelectedItem == null) {
                MessageBox.Show("Seleccione un título válido.");
                return;
            }

            string titulo = cbTitulo.SelectedItem.ToString();
            DateTime fechaDevolucion = dtimePicker_fechaDevolucion.Value;

            
            if (fechaDevolucion <= DateTime.Now) {
                MessageBox.Show("La fecha de devolución debe ser futura.");
                return;
            }

            DLibro dLibro = new DLibro();
            Libros libro = dLibro.ObtenerLibroPorTitulo(titulo);

            if (libro == null) {
                MessageBox.Show("No se encontró el libro especificado.");
                return;
            }

            NReserva nReserva = new NReserva();
            bool resultado = nReserva.CrearReserva(libro.Id, fechaDevolucion, NU.ObtenerUsuarioLogeado());

            if (resultado) {
                MessageBox.Show("Reserva realizada exitosamente.");
                
            }
            else {
                MessageBox.Show("Hubo un problema al realizar la reserva. Inténtelo de nuevo.");
            }



        }
    }
}
