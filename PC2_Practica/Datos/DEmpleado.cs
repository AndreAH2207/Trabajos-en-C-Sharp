using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEmpleado
    {
        public string Agregar(Empleado empleado)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Empleado.Add(empleado);
                    context.SaveChanges();
                }
                return "Empleado agregado con éxito";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Editar(Empleado empleado)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Empleado empleadoTemp = context.Empleado.Find(empleado.EmpleadoId);
                    empleadoTemp.DNI = empleado.DNI;
                    empleadoTemp.Nombre = empleado.Nombre;
                    empleadoTemp.Apellidos = empleado.Apellidos;
                    empleadoTemp.FechaNacimiento = empleado.FechaNacimiento;
                    context.SaveChanges();
                }
                return "Empleado editado con éxito";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EliminarFisico(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Empleado empleadoTemp = context.Empleado.Find(id);
                    context.Empleado.Remove(empleadoTemp);
                    context.SaveChanges();
                }
                return "Empleado eliminado con éxito";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EliminarLogico(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Empleado empleadoTemp = context.Empleado.Find(id);
                    empleadoTemp.Eliminado = true;
                    context.SaveChanges();
                }
                return "Empleado eliminado con éxito";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<Empleado> ListarTodo()
        {
            List<Empleado> empleados = new List<Empleado>();
            using (var context = new BDEFEntities())
            {
                empleados = context.Empleado.Where(a => a.Eliminado == false).ToList();
            }
            return empleados;
        }
    }
}
