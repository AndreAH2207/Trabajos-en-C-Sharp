using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCancha
    {
        public String Registrar(Canchas canchas)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Canchas.Add(canchas);
                    context.SaveChanges();
                    return "Cancha registrada correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar Cancha: " + ex.Message;
            }
        }
        public String Modificar(Canchas canchas)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Canchas canchasTemp = context.Canchas.Find(canchas.IdCancha);
                    canchasTemp.NombreCancha = canchas.NombreCancha;
                    canchasTemp.Ubicacion = canchas.Ubicacion;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Canchas> ListarTodo()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Canchas.ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<Canchas>();
            }
        }
        public String Eliminar(int IdCancha)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Canchas canchas1 = context.Canchas.Find(IdCancha);
                    context.Canchas.Remove(canchas1);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
