using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos {
    public class DAdministrador {

        public DAdministrador() { }


        public String Registrar(Administradores p_administrador) {

            try {

                using (var context = new BDEFEntities()) {

                    if (!context.Administradores.ToList().Exists(a => a.Codigo == p_administrador.Codigo)) {

                        context.Administradores.Add(p_administrador);
                        context.SaveChanges();

                        return "Registrado correctamente";
                    }
                    else {

                        return "Codigo repetido";
                    }
                    
                }
                
            }
            catch (Exception ex) {
                return ex.Message;
            }
        }


        public Administradores Login(string p_codigo, string p_contraseña) {

            try {
            
                using (var context = new BDEFEntities()) {
                    var administradorTemp = context.Administradores.FirstOrDefault(a => a.Codigo == p_codigo && a.Contraseña == p_contraseña && a.Eliminado == false);
                    if (administradorTemp == null) {
                        Console.WriteLine("Administrador no encontrado o credenciales incorrectas.");
                    }
                    return administradorTemp;
                }

            }
            catch (Exception ex) {
                Console.WriteLine("Error en Login: " + ex.Message);
                return null;
            }
        }





    }
}
