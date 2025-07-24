using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProducto
    {
        private DProducto dProducto = new DProducto();

        public String Registrar(Producto producto)
        {
            return dProducto.Registrar(producto);
        }

        public String Modificar(Producto producto)
        {
            return dProducto.Modificar(producto);
        }

        public String Eliminar(int id_Producto)
        {
            return dProducto.Eliminar(id_Producto);
        }

        public List<Producto> ListarTodo()
        {
            return dProducto.ListarTodo();
        }

        public List<Producto> BuscarPorMarca(String marca)
        {
            return dProducto.BuscarPorMarca(marca);
        }
    }
}
