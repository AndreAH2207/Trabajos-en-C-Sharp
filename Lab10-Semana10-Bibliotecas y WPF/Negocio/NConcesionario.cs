using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NConcesionario
    {
        private DConcesionario dConcesionario = new DConcesionario();

        public bool Registrar(EConcesionario concesionario)
        {
            if (dConcesionario.Existe(concesionario.Codigo))
            {
                return false;
            }
            else
            {
                dConcesionario.Registrar(concesionario);
                return true;
            }
        }

        public List<EConcesionario> ListarTodo()
        {
            return DConcesionario.ListarTodo();
        }

        public List<EConcesionario> OrdenarPorFecha()
        {
            return dConcesionario.OrdenarPorFecha();
        }
    }
}
