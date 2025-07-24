using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NMecanico
    {
        private DMecanico dMecanico = new DMecanico();

        public List<Mecanico> ListarTodo()
        {
            return dMecanico.ListarTodo();
        }
    }
}
