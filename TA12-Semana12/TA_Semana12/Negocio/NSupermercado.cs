using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NSupermercado
    {
        private DSupermercado dSupermercado = new DSupermercado();

        public String Registrar(Supermercado supermercado)
        {
            return dSupermercado.Registrar(supermercado);
        }

        public String Modificar(Supermercado supermercado)
        {
            return dSupermercado.Modificar(supermercado);
        }

        public String Eliminar(int id_Supermercado)
        {
            return dSupermercado.Eliminar(id_Supermercado);
        }

        public List<Supermercado> ListarTodo()
        {
            return dSupermercado.ListarTodo();
        }

        public List<Supermercado> BuscarPorNombreReferenciala(String nombreR)
        {
            return dSupermercado.BuscarPorNombreReferencial(nombreR);
        }
    }
}
