using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProductora
    {
        public String Registrar(Productora productora)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Productora.Add(productora);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id_Productora)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Productora productoraTemp = context.Productora.Find(id_Productora);
                    context.Productora.Remove(productoraTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Productora> ListarTodo()
        {
            List<Productora> productoras = new List<Productora>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    productoras = context.Productora.ToList();
                }
                return productoras;
            }
            catch (Exception ex)
            {
                return productoras;
            }
        }

        public List<Productora> BuscarProductorasConConciertosEnRango(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Productora> productoras = new List<Productora>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productoras = context.Productora
                        .Where(p => p.Concierto.Any(c => c.Fecha >= fechaInicio && c.Fecha <= fechaFin))
                        .ToList();
                }
                return productoras;
            }
            catch (Exception ex)
            {
                return productoras;
            }
        }


    }
}
