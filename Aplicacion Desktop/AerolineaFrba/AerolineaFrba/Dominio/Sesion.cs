using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.FormsPrincipales;
using AerolineaFrba.Abm_Rol;
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

            if (username == "" && password == "") //---> es usuario
            {
              //TO-DO
                ListadoRol lf = new ListadoRol();
                funcionalidadesDisponibles.Add(new Funcionalidades(99, "Listado Rol", lf));
                return;
            }
            //OBTENER FUNCDISP SEGUN EL ROL

            ABMRolForm prueba = new ABMRolForm();
            Form1 prueba2= new Form1();
            funcionalidadesDisponibles.Add(new Funcionalidades(99,"ABM Rol",prueba ));
            funcionalidadesDisponibles.Add(new Funcionalidades(99, "ABM Aeronaves", prueba2)); 
        }

        public List<Funcionalidades> getFuncionalidadesDisponibles{
           get {return funcionalidadesDisponibles ;}
        }

    }
}
