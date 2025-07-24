using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DTorneo
    {
        public string Registrar(Torneos torneo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Torneos.Add(torneo);
                    context.SaveChanges();
                    return "Torneo registrado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar torneo: " + ex.Message;
            }
        }

        public string Modificar(Torneos torneo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var existente = context.Torneos.Find(torneo.IdTorneo);
                    if (existente != null)
                    {
                        existente.NombreTorneo = torneo.NombreTorneo;
                        existente.Categoria = torneo.Categoria;
                        existente.Genero = torneo.Genero;
                        existente.FechaInicio = torneo.FechaInicio;
                        existente.FechaFin = torneo.FechaFin;
                        existente.Estado = torneo.Estado;
                        existente.CostoInscripcion = torneo.CostoInscripcion;
                        existente.PremioTotal = torneo.PremioTotal;
                        existente.NumeroPremiados = torneo.NumeroPremiados;
                        context.SaveChanges();
                        return "Torneo modificado correctamente.";
                    }
                    return "Torneo no encontrado.";
                }
            }
            catch (Exception ex)
            {
                return "Error al modificar torneo: " + ex.Message;
            }
        }

        public string Eliminar(int idTorneo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var torneo = context.Torneos.Find(idTorneo);
                    if (torneo != null)
                    {
                        context.Torneos.Remove(torneo);
                        context.SaveChanges();
                        return "Torneo eliminado correctamente.";
                    }
                    return "Torneo no encontrado.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar torneo: " + ex.Message;
            }
        }

        public List<Torneos> ListarTodo()
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Torneos.Include("Usuarios").ToList();
            }
        }
        public Torneos ObtenerPorId(int idTorneo)
        {
            using (var context = new BDEFEntities())
            {
                return context.Torneos.Find(idTorneo);
            }
        }
    }
}
