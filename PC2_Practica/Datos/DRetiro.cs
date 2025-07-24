using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DRetiro
    {
        public string Agregar(Retiro retiro)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Retiro.Add(retiro);
                    context.SaveChanges();
                }
                return "Retiro agregado con éxito";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Editar(Retiro retiro)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Retiro retiroTemp = context.Retiro.Find(retiro.RetiroId);
                    retiroTemp.Monto = retiro.Monto;
                    retiroTemp.CuentaInterbancaria = retiro.CuentaInterbancaria;
                    context.SaveChanges();
                }
                return "Retiro editado con éxito";
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
                    Retiro retiroTemp = context.Retiro.Find(id);
                    context.Retiro.Remove(retiroTemp);
                    context.SaveChanges();
                }
                return "Retiro eliminado con éxito";
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
                    Retiro retiroTemp = context.Retiro.Find(id);
                    retiroTemp.Eliminado = true;
                    context.SaveChanges();
                }
                return "Retiro eliminado con éxito";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<Retiro> ListarTodo()
        {
            List<Retiro> retiros = new List<Retiro>();

            using (var context = new BDEFEntities())
            {
                retiros = context.Retiro.Where(a => a.Eliminado == false).ToList();
            }
            return retiros;
        }


    }
}
