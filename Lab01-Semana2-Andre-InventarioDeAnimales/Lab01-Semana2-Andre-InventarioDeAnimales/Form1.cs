using Lab01_Semana2_Andre_InventarioDeAnimales.Controladores;
using Lab01_Semana2_Andre_InventarioDeAnimales.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_Semana2_Andre_InventarioDeAnimales
{
    public partial class FormMain : Form
    {
        private ControladorAnimal controladorAnimal = new ControladorAnimal();
        public FormMain()
        {
            InitializeComponent();
        }
        private void MostrarInventario(CAnimal[] animales)
        {
            dgAnimales.DataSource = null;
            dgAnimales.DataSource = animales;
        }

        private void btbRegistrar_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "" || tbNombre.Text == "" || tbEspecie.Text == "" || tbEdad.Text == "" || tbPeso.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
           
            CAnimal animal = new CAnimal()
            {
                Id = tbId.Text,
                Nombre = tbNombre.Text,
                Especie = tbEspecie.Text,
                Edad = int.Parse(tbEdad.Text),
                Peso = float.Parse(tbPeso.Text)
            };

            controladorAnimal.Registrar(animal);
            MostrarInventario(controladorAnimal.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgAnimales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el registro a eliminar");
                return;
            }
            string id = dgAnimales.SelectedRows[0].Cells[0].Value.ToString();
            controladorAnimal.Eliminar(id);
            MostrarInventario(controladorAnimal.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dgAnimales[0, dgAnimales.CurrentRow.Index].Value = tbId.Text;
            dgAnimales[1, dgAnimales.CurrentRow.Index].Value = tbNombre.Text;
            dgAnimales[2, dgAnimales.CurrentRow.Index].Value = tbEspecie.Text;
            dgAnimales[3, dgAnimales.CurrentRow.Index].Value = int.Parse(tbEdad.Text);
            dgAnimales[4, dgAnimales.CurrentRow.Index].Value = float.Parse(tbPeso.Text);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarInventario(controladorAnimal.Ordenar());
        }
    }
}
