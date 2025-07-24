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

namespace Presentacion.FormsParaAdministrativos {
    public partial class FormVerEstadoDePrestamos : Form {
        
        private NPrestamos NP = new NPrestamos();
        private NAdministrador NA = new NAdministrador();

        public FormVerEstadoDePrestamos() {
            InitializeComponent();

            lbl_nombreEnSesion.Text = NA.ObtenerUsuarioLogeado().Nombre +
                                      " " +
                                      NA.ObtenerUsuarioLogeado().Apellido;

            cb_estado.SelectedItem = "Prestado";

            
            MostrarPrestamos(NP.VerEstadoDelPrestamo(cb_estado.Text, dtimepicker_fechaInicio.Value, dtimepicker_fechaFinal.Value));
        }

        private void MostrarPrestamos(List<dynamic> prestamos) {
            dataGridView1.DataSource = null;
            if (prestamos.Count == 0) {
                return;
            }
            else {
                dataGridView1.DataSource = prestamos;
            }
        }


        
        private void btnBuscar_Click_1(object sender, EventArgs e) {

            if (cb_estado.Text == "") { return; MessageBox.Show("Ingrese todos los campos"); }




            string estado = cb_estado.Text;
            DateTime fechaInicio = dtimepicker_fechaInicio.Value;
            DateTime fechaFinal = dtimepicker_fechaFinal.Value;


            if (fechaFinal < fechaInicio) {
                MessageBox.Show("La fecha final no puede ser anterior a la fecha de inicio.");
                return;
            }

            var prestamos = NP.VerEstadoDelPrestamo(estado, fechaInicio, fechaFinal);

            if (prestamos.Count > 0) {
                MostrarPrestamos(prestamos);
            }
            else {
                MessageBox.Show("No se encontraron préstamos con los filtros seleccionados.");
                dataGridView1.DataSource = null;
            }
        }
    }
}

