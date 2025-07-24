using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio {
    public class NAdministrador {

        DAdministrador DA = new DAdministrador();
        private static Administradores administradorLogueado;


        public NAdministrador() { }


        public String Registrar(Administradores p_administrador) {

            return DA.Registrar(p_administrador);
        }

        public Administradores Login(string p_codigo, string p_contraseña) {

            return DA.Login(p_codigo, p_contraseña);
        }

        public void AsignarUsuarioLogeado(Administradores p_administrador) {
            administradorLogueado = p_administrador;
        }

        public Administradores ObtenerUsuarioLogeado() {
            return administradorLogueado;
        }


    }
}
