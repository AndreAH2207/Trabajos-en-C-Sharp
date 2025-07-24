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
    public partial class FormRegistrarResultados : Form
    {
        private NTorneo nTorneo = new NTorneo();
        private NPartido nPartido = new NPartido();
        private NResultado nResultado = new NResultado();
        private List<Partidos> listaPartidos = new List<Partidos>();




        public FormRegistrarResultados()
        {
            InitializeComponent();
            CargarTorneos();
        }

        private void CargarTorneos()
        {
            var torneos = nTorneo.ListarTodo()
                .Where(t => t.Estado == "En curso")
                .ToList();

            cbTorneo.DataSource = torneos;
            cbTorneo.DisplayMember = "NombreTorneo";
            cbTorneo.ValueMember = "IdTorneo";
        }



        private void btnRegistarResultado_Click(object sender, EventArgs e)
        {
            if (cbPartido.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un partido.");
                return;
            }

            int idPartido = Convert.ToInt32(cbPartido.SelectedValue);
            int golesLocal = (int)numGolesLocal.Value;
            int golesVisitante = (int)numGolesVisitante.Value;

            // Validar que no se haya registrado ya
            var existentes = nResultado.ListarPorPartido(idPartido);
            if (existentes.Count > 0)
            {
                MessageBox.Show("Este partido ya tiene un resultado registrado.");
                return;
            }

            Resultados resultado = new Resultados
            {
                IdPartido = idPartido,
                GolesEquipoLocal = golesLocal,
                GolesEquipoVisitante = golesVisitante,
                FechaRegistro = DateTime.Now
            };

            string mensaje = nResultado.Registrar(resultado);
            MessageBox.Show(mensaje);

            var partido = nPartido.ObtenerPorId(idPartido);
            partido.Estado = "Finalizado";
            if (golesLocal > golesVisitante)
                partido.IdGanador = partido.IdEquipoLocal;
            else if (golesVisitante > golesLocal)
                partido.IdGanador = partido.IdEquipoVisitante;

            nPartido.Modificar(partido);

            MessageBox.Show("Resultado registrado correctamente.");
            cbTorneo_SelectedIndexChanged(null, null); 
        }
    

        private void btnSalir_Click(object sender, EventArgs e)
        {
        this.Close();
        }

        private void cbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTorneo.SelectedItem == null) return;

            int idTorneo = Convert.ToInt32(cbTorneo.SelectedValue);
            listaPartidos = nPartido.ListarPorTorneo(idTorneo)
                .Where(p => p.Estado == "Programado")
                .ToList();

            var partidosView = listaPartidos.Select(p => new
            {
                IdPartido = p.IdPartido,
                Descripcion = $"{p.Equipos.NombreEquipo} vs {p.Equipos1.NombreEquipo} - {p.FechaHora}"
            }).ToList();

            cbPartido.DataSource = partidosView;
            cbPartido.DisplayMember = "Descripcion";
            cbPartido.ValueMember = "IdPartido";
        }
    }
}
