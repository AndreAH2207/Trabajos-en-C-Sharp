using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DConcesionario
    {
        private static List<EConcesionario> concesionarios = new List<EConcesionario>();

        public bool Existe(String codigo)
        {
            return concesionarios.Exists(c => c.Codigo.Equals(codigo));
        }

        public void Registrar(EConcesionario concesionario)
        {
            concesionarios.Add(concesionario);
        }

        public static List<EConcesionario> ListarTodo()
        {
            return concesionarios;
        }


        public List<EConcesionario> OrdenarPorFecha()
        {
            return concesionarios.OrderBy(c => c.FechaInicio).ToList();
        }
    }
}
