using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAFP
    {
        public string Agregar(AFP afp)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.AFP.Add(afp);
                    context.SaveChanges();
                }
                return "AFP agregada con éxito";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Editar(AFP afp)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    AFP afpTemp = context.AFP.Find(afp.AFPId);
                    afpTemp.Nombre = afp.Nombre;
                    context.SaveChanges();
                }
                return "AFP editada con éxito";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EliminarFisico(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    AFP afpTemp = context.AFP.Find(id);
                    context.AFP.Remove(afpTemp);
                    context.SaveChanges();
                }
                return "AFP eliminada con éxito";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EliminarLogico(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    AFP afpTemp = context.AFP.Find(id);
                    afpTemp.Eliminado = true;
                    context.SaveChanges();
                }
                return "AFP eliminada con éxito";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<AFP> ListarTodo()
        {
            List<AFP> afps = new List<AFP>();
            using (var context = new BDEFEntities())
            {
                afps = context.AFP.Where(a=>a.Eliminado == false).ToList();
            }
            return afps;
        }
    }
}
