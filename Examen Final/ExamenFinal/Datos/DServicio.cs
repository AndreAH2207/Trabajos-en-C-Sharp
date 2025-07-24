using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DServicio
    { 
        public string Registrar(Servicio servicio)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    servicio = context.Servicio.Add(servicio);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Modificar(Servicio servicio)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Servicio servicioTemp = context.Servicio.Find(servicio.ServicioId);
                    servicioTemp.FechaHoraServicio = servicio.FechaHoraServicio;
                    servicioTemp.MecanicoId = servicio.MecanicoId;
                    servicioTemp.VehiculoId = servicio.VehiculoId;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string Atender(Servicio servicio)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Servicio servicioTemp = context.Servicio.Find(servicio.ServicioId);
                    servicioTemp.Atendido = true;
                    context.SaveChanges();
                }
                return "Usuario ha sido atendido";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Eliminar(int servicioId)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Servicio servicioTemp = context.Servicio.Find(servicioId);
                    context.Servicio.Remove(servicioTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Servicio> ListarTodo()
        {
           List<Servicio> servicios = new List<Servicio> ();

            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = true;
                servicios = context.Servicio.ToList();
            }
            return servicios;
        }
    }
}
