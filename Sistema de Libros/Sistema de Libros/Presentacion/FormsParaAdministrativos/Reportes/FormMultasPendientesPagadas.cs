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

namespace Presentacion.FormsParaAdministrativos.Reportes {
    public partial class FormMultasPendientesPagadas : Form {

        private NMulta NM = new NMulta();
        private NAdministrador NA = new NAdministrador();

        public FormMultasPendientesPagadas() {
            InitializeComponent();

            lbl_nombreEnSesion.Text = NA.ObtenerUsuarioLogeado().Nombre +
                                      " " +
                                      NA.ObtenerUsuarioLogeado().Apellido;


            bool estado;
            if (comboBox1.Text == "Pendiente") {

                estado = true;
            }
            else {
                estado = false;
            }

            DateTime fechaInicio = dateTimePicker1.Value;
            DateTime fechaFinal = dateTimePicker2.Value;
            string dni = numud_Dni.Text;

            MostrarMultas(NM.VerEstadoDeLaMulta(estado, numud_Dni.Text, dateTimePicker1.Value, dateTimePicker2.Value));
        }

        private void MostrarMultas(List<dynamic> multas) {
            dataGridView3.DataSource = null;
            if (multas.Count == 0) {
                return;
            }
            else {
                dataGridView3.DataSource = multas;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e) {
            
            if (numud_Dni.Text == "" || comboBox1.Text == "") {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            bool estado;
            if (comboBox1.Text == "Pendiente") {

                estado = true;
            }
            else {
                estado = false;
            }

            DateTime fechaInicio = dateTimePicker1.Value;
            DateTime fechaFinal = dateTimePicker2.Value;
            string dni = numud_Dni.Text;

            if (fechaFinal < fechaInicio) {
                MessageBox.Show("La fecha final no puede ser anterior a la fecha de inicio.");
                return;
            }

            List<dynamic> lista = NM.VerEstadoDeLaMulta(estado, numud_Dni.Text, dateTimePicker1.Value, dateTimePicker2.Value);

            if (lista.Count > 0) {
                MostrarMultas(lista);
            }
            else {
                MessageBox.Show("No se encontraron préstamos con los filtros seleccionados.");
                dataGridView3.DataSource = null;
            }
        }
    }
}
