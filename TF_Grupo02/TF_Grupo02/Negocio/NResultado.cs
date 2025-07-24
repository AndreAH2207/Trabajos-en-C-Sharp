using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NResultado
    {
        private DResultado dResultado = new DResultado();

        public string Registrar(Resultados resultado)
        {
            if (resultado == null || resultado.IdPartido <= 0)
            {
                return "Datos de resultado inválidos.";
            }

            return dResultado.Registrar(resultado);
        }

        public Resultados ObtenerPorPartido(int idPartido)
        {
            if (idPartido <= 0)
                return null;

            return dResultado.ObtenerPorPartido(idPartido);
        }

        public List<Resultados> ListarPorPartido(int idPartido)
        {
            if (idPartido <= 0)
                return new List<Resultados>();

            return dResultado.ListarPorPartido(idPartido);
        }

        public List<Resultados> ListarTodo()
        {
            return dResultado.ListarTodo();
        }
    }
}
