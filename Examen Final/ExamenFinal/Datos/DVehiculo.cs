using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVehiculo
    {
        public List<Vehiculo> ListarTodo()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            using(var context = new BDEFEntities())
            {
                vehiculos = context.Vehiculo.Where(v=>v.Eliminado == false).ToList();
            }
            return vehiculos;
        }
    }
}
