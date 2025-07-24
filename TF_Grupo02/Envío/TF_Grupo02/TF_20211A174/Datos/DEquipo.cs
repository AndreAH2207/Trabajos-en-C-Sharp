using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DEquipo
    {
        public string Registrar(Equipos equipo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Equipos.Add(equipo);
                    context.SaveChanges();
                    return "Equipo registrado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar equipo: " + ex.Message;
            }
        }

        public string Modificar(Equipos equipo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var existente = context.Equipos.Find(equipo.IdEquipo);
                    if (existente != null)
                    {
                        existente.NombreEquipo = equipo.NombreEquipo;
                        existente.TelefonoEquipo = equipo.TelefonoEquipo;
                        existente.CorreoEquipo = equipo.CorreoEquipo;
                        existente.DireccionEquipo = equipo.DireccionEquipo;
                        context.SaveChanges();
                        return "Equipo modificado correctamente.";
                    }
                    return "Equipo no encontrado.";
                }
            }
            catch (Exception ex)
            {
                return "Error al modificar equipo: " + ex.Message;
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var equipo = context.Equipos.Find(id);
                    if (equipo != null)
                    {
                        context.Equipos.Remove(equipo);
                        context.SaveChanges();
                        return "Equipo eliminado correctamente.";
                    }
                    return "Equipo no encontrado.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar equipo: " + ex.Message;
            }
        }

        public List<Equipos> ListarTodo()
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Equipos.ToList();
            }
        }
    }
}
