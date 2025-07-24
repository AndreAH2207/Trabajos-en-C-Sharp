using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NVehiculo
    {
        private DVehiculo dVehiculo = new DVehiculo();

        public List<Vehiculo> ListarTodo()
        {
            return dVehiculo.ListarTodo();
        }
    }
}
