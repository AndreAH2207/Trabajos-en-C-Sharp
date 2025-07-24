using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVehiculo
    {
        public bool Existe(String codigo, String placa)
        {
            List<EConcesionario> concesionarios = DConcesionario.ListarTodo();
            return concesionarios.Exists(c => c.Vehiculos.Exists(v => c.Codigo.Equals(codigo) && v.Placa.Equals(placa)));
        }

        public void Registrar(String codigo, EVehiculo vehiculo)
        {
            List<EConcesionario> concesionarios = DConcesionario.ListarTodo();
            EConcesionario concesionario = concesionarios.Find(c => c.Codigo.Equals(codigo));
            concesionario.Vehiculos.Add(vehiculo);
        }

        public List<EVehiculo> ListarTodo(String codigo)
        {
            List<EConcesionario> concesionarios = DConcesionario.ListarTodo();
            EConcesionario concesionario = concesionarios.Find(c => c.Codigo.Equals(codigo));
            return concesionario.Vehiculos;
        }

        public List<EVehiculo> OrdenarPorPrecio(String codigo)
        {
            List<EConcesionario> concesionarios = DConcesionario.ListarTodo();
            EConcesionario concesionario = concesionarios.Find(c => c.Codigo.Equals(codigo));

            return concesionario.Vehiculos.OrderBy(v => v.Precio).ToList();
        }
    }
}
