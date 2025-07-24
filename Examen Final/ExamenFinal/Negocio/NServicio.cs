using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NServicio
    {
        private DServicio dServicio = new DServicio();
        public String Registrar(Servicio servicio)
        {
            return dServicio.Registrar(servicio);
        }

        public String Modificar(Servicio servicio)
        {
            return dServicio.Modificar(servicio);
        }

        public String Eliminar(int servicioId)
        {
            return dServicio.Eliminar(servicioId);
        }

        public String Atender(Servicio servicio)
        {
            return dServicio.Atender(servicio);
        }

        public List<Servicio> ListarTodo()
        {
            return dServicio.ListarTodo();
        }
    }
}
