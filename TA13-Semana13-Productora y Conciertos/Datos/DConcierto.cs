using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DConcierto
    {
        public String Registrar(Concierto concierto)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Concierto.Add(concierto);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id_Concierto)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Concierto conciertoTemp = context.Concierto.Find(id_Concierto);
                    context.Concierto.Remove(conciertoTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Concierto> ListarTodo(int idProductora)
        {
            List<Concierto> conciertos = new List<Concierto>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    conciertos = context.Concierto.Where(c=>c.IdProductora == idProductora).ToList();
                }
                return conciertos;
            }
            catch (Exception ex)
            {
                return conciertos;
            }
        }

        public List<Concierto> BuscarConciertosDeProductorasSinAmonestaciones()
        {
            List<Concierto> conciertos = new List<Concierto>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    conciertos = context.Concierto
                        .Where(c => c.Productora.CantAmonestaciones == 0)
                        .ToList();
                }
                return conciertos;
            }
            catch (Exception ex)
            {
                return conciertos;
            }
        }
    }
}
