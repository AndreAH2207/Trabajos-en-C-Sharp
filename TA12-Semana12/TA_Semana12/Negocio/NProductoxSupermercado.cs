using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProductoxSupermercado
    {
        private DProductoxSupermercado dProductoxSupermercado = new DProductoxSupermercado();

        public String Asignar(ProductoxSupermercado productoxSupermercado)
        {
            return dProductoxSupermercado.Asignar(productoxSupermercado);
        }

        public String Desasignar(int ProductoId, int SupermercadoId)
        {
            return dProductoxSupermercado.Desasignar(ProductoId, SupermercadoId);
        }

        public List<ProductoxSupermercado> ListarTodo()
        {
            return dProductoxSupermercado.ListarTodo();
        }
    }
}
