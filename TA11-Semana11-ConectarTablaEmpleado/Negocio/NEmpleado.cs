using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NEmpleado
    {
        private DEmpleado dEmpleado = new DEmpleado();

        public string Registrar(Empleado empleado)
        {
            empleado.Estado = "A";
            return dEmpleado.Registrar(empleado);
        }

        public string EliminarLogico(int id)
        {
            return dEmpleado.EliminarLogico(id);
        }

        public List<Empleado> ListarTodoActivo()
        {
            return dEmpleado.ListarTodoActivo();
        }

        public List<Empleado> OrdenarSegunFechaNacimiento()
        {
            return dEmpleado.OrdenarSegunFechaNacimiento();
        }

        public List<Empleado> BuscarPorArea(string area)
        {
            return dEmpleado.BuscarPorArea(area); 
        }
    }
}
