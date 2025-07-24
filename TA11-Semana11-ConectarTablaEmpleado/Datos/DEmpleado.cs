using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEmpleado
    { 
        public string Registrar(Empleado empleado)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Empleado.Add(empleado);
                    context.SaveChanges();  
                }
                return "Empleado registrado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarLogico(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Empleado empleadoTemp = context.Empleado.Find(id);
                    empleadoTemp.Estado = "I";
                    context.SaveChanges();
                }
                return "Empleado eliminado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Empleado> ListarTodoActivo()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    empleados = context.Empleado.Where(e=>e.Estado.Equals("A")).ToList();           
                }
                return empleados;
            }
            catch (Exception ex)
            {
                return empleados;
            }
        }
        public List<Empleado> OrdenarSegunFechaNacimiento()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    empleados = context.Empleado.Where(e=>e.Estado == "A").OrderBy(e=>e.FechaNacimiento).ToList();
                }
                return empleados;
            }
            catch (Exception ex)
            {
                return empleados;
            }
        }

        public List<Empleado> BuscarPorArea(string area)
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    empleados = context.Empleado.Where(e=>e.Area.Contains(area) && e.Estado == "A").ToList();
                }
                return empleados;
            }
            catch (Exception ex)
            {
                return empleados;
            }
        }
    }
}
