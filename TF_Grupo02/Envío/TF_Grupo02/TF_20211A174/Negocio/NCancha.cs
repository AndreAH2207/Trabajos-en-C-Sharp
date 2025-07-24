using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCancha
    {
        private DCancha dCancha = new DCancha();
        public String Registrar(Canchas canchas)
        {
            return dCancha.Registrar(canchas);
        }

        public String Modificar(Canchas canchas)
        {
            return dCancha.Modificar(canchas);
        }

        public String Eliminar(int IdCancha)
        {
            return dCancha.Eliminar(IdCancha);
        }

        public List<Canchas> ListarTodo()
        {
            return dCancha.ListarTodo();
        }
    }
}
