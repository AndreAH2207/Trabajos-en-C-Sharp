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
    public partial class FormRegistrarTorneos : Form
    {
        private NTorneo nTorneo = new NTorneo();
        private int idUsuario;


        public FormRegistrarTorneos(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            MostrarTorneos(nTorneo.ListarTodo());   
        }


        private void MostrarTorneos(List<Torneos> torneos)
        {
            dgTorneos.DataSource = null;
            if (torneos.Count == 0) return;

            var listaFormateada = new List<object>();

            foreach (var t in torneos)
            {
                string nombreOrganizador = "Sin asignar";
                if (t.Usuarios != null && t.Usuarios.NombreCompleto != null)
                    nombreOrganizador = t.Usuarios.NombreCompleto;

                listaFormateada.Add(new
                {
                    t.IdTorneo,
                    t.NombreTorneo,
                    t.Categoria,
                    t.Genero,
                    FechaInicio = t.FechaInicio.Value.ToString("dd/MM/yyyy"),
                    FechaFin = t.FechaFin.Value.ToString("dd/MM/yyyy"),
                    t.Estado,
                    t.CostoInscripcion,
                    t.PremioTotal,
                    t.NumeroPremiados,
                    Organizador = nombreOrganizador
                });
            }

            dgTorneos.DataSource = listaFormateada;
            dgTorneos.Columns["IdTorneo"].Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombreTorneo.Text == "" || cbCategoria.Text == "" || cbGenero.Text == ""
                || dtpFechaInicio.Text == "" || dtpFechaFin.Text == "" || tbCostoInscripcion.Text == ""
                || cbEstado.Text == "" || tbPremioTotal.Text == "" || tbNumeroPremiados.Text == "")
            {
                MessageBox.Show("Complete todos los campos obligatorios.");
                return;
            }

            Torneos torneo = new Torneos()
            {
                NombreTorneo = tbNombreTorneo.Text,
                Categoria = cbCategoria.Text,
                Genero = cbGenero.Text,
                FechaInicio = dtpFechaInicio.Value,
                FechaFin = dtpFechaFin.Value,
                Estado = cbEstado.Text,
                CostoInscripcion = decimal.Parse(tbCostoInscripcion.Text),
                PremioTotal = decimal.Parse(tbPremioTotal.Text),
                NumeroPremiados = int.Parse(tbNumeroPremiados.Text),
                IdOrganizador = this.idUsuario 
            };

            string mensaje = nTorneo.Registrar(torneo);
            MessageBox.Show(mensaje);
            MostrarTorneos(nTorneo.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbNombreTorneo.Text == "" || cbCategoria.Text == "" || cbGenero.Text == ""
            || dtpFechaInicio.Text == "" || dtpFechaFin.Text == "" || tbCostoInscripcion.Text == ""
            || cbEstado.Text == "" || tbPremioTotal.Text == "" || tbNumeroPremiados.Text == "")
            {
                MessageBox.Show("Complete todos los campos obligatorios.");
                return;
            }

            if (dgTorneos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un torneo a modificar.");
                return;
            }

            int idTorneo = Convert.ToInt32(dgTorneos.SelectedRows[0].Cells["IdTorneo"].Value);

            Torneos torneo = new Torneos()
            {
                IdTorneo = idTorneo,
                NombreTorneo = tbNombreTorneo.Text,
                Categoria = cbCategoria.Text,
                Genero = cbGenero.Text,
                FechaInicio = dtpFechaInicio.Value,
                FechaFin = dtpFechaFin.Value,
                Estado = cbEstado.Text,
                CostoInscripcion = decimal.Parse(tbCostoInscripcion.Text),
                PremioTotal = decimal.Parse(tbPremioTotal.Text),
                NumeroPremiados = int.Parse(tbNumeroPremiados.Text),
            };

            string mensaje = nTorneo.Modificar(torneo);
            MessageBox.Show(mensaje);
            MostrarTorneos(nTorneo.ListarTodo());
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarTorneos(nTorneo.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgTorneos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el torneo a eliminar.");
                return;
            }

            int id = Convert.ToInt32(dgTorneos.SelectedRows[0].Cells[0].Value);

            string mensaje = nTorneo.Eliminar(id);
            MessageBox.Show(mensaje);
            MostrarTorneos(nTorneo.ListarTodo());   
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
