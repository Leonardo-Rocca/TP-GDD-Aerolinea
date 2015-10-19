using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Dominio
{
    class Sesion
    {
        public List<Funcionalidades> funcionalidadesDisponibles;
        //public static Usuario Usuario;

        public  void iniciar(string username, string password)
        {
           //("chequear_login", username, password);
       
          //  Sesion.Usuario = new Usuario(Convert.ToInt32(tablaUsuario.Rows[0]["id_usuario"]), tablaUsuario.Rows[0]["username"].ToString());

            //OBTENER FUNCDISP SEGUN EL ROL
            funcionalidadesDisponibles.Add(new Funcionalidades(99,"prueba",new Abm_Rol.Form1() ));
        }
   
    }
}
