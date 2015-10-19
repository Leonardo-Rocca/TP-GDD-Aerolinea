using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.FormsPrincipales;

namespace AerolineaFrba.Dominio
{
    public  class Sesion
    {
        public List<Funcionalidades> funcionalidadesDisponibles = new List<Funcionalidades>();
        //public static Usuario Usuario;

        public  void iniciar(string username, string password)
        {
           //("chequear_login", username, password);
       
          //  Sesion.Usuario = new Usuario(Convert.ToInt32(tablaUsuario.Rows[0]["id_usuario"]), tablaUsuario.Rows[0]["username"].ToString());

            //OBTENER FUNCDISP SEGUN EL ROL

            Form1 prueba= new Form1();
            funcionalidadesDisponibles.Add(new Funcionalidades(99,"prueba",prueba ));
        }

        public List<Funcionalidades> getFuncionalidadesDisponibles{
           get {return funcionalidadesDisponibles ;}
    
        }
    }
}
