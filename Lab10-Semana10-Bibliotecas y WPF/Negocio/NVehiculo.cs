using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NVehiculo
    {
        private DVehiculo dVehiculo = new DVehiculo();
        public bool Registrar(String codigo, EVehiculo vehiculo)
        {
            if (dVehiculo.Existe(codigo, vehiculo.Placa))
            {
                return false;
            }
            else
            {
                dVehiculo.Registrar(codigo, vehiculo);
                return true;
            }
        }
        public List<EVehiculo> ListarTodo(String codigo)
        {
            return dVehiculo.ListarTodo(codigo);
        }
        public List<EVehiculo> OrdenarPorPrecio(String codigo)
        {
            return dVehiculo.OrdenarPorPrecio(codigo);
        }
    }
}
