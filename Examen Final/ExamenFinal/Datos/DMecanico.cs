using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMecanico
    {
        public List<Mecanico> ListarTodo()
        {
            List<Mecanico> mecanicos = new List<Mecanico>();

            using(var context = new BDEFEntities())
            {
                mecanicos = context.Mecanico.Where(m => m.Eliminado == false).ToList();
            }
            return mecanicos;
        }
    }
}
