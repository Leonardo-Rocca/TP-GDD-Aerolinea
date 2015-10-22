using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.FormsPrincipales;
using AerolineaFrba.Abm_Rol;
using AerolineaFrba.Abm_Ciudad;

namespace AerolineaFrba.Dominio
{
    public  class Sesion
    {
        public List<Funcionalidades> funcionalidadesDisponibles = new List<Funcionalidades>();
        //public static Usuario Usuario;

        public  void iniciar(string username, string password,string rol)
        {
           //("chequear_login", username, password);
       
          //  Sesion.Usuario = new Usuario(Convert.ToInt32(tablaUsuario.Rows[0]["id_usuario"]), tablaUsuario.Rows[0]["username"].ToString());

            if (username == "" && password == "") //---> es usuario
            {
              //TO-DO
                ListadoRol lf = new ListadoRol();
                funcionalidadesDisponibles.Add(new Funcionalidades(99, "Listado Rol", lf));
                funcionalidadesDisponibles.Add(new Funcionalidades(99, "aeronave", new ABMGenericoForm("ABM Aernaves",new CrearRolForm(),null,null)));
                return;
            }
            //OBTENER FUNCDISP SEGUN EL ROL

            //--Creo y Agrego ABM ROL
             funcionalidadesDisponibles.Add(new Funcionalidades(99, "ABM ROL",
                 new ABMGenericoForm("ABM Rol", new CrearRolForm(), new ModificarForm("Modificar Rol", "Modificar", 1), new ModificarForm("Eliminar Rol", "Eliminar", 2))));

             funcionalidadesDisponibles.Add(new Funcionalidades(99, "ABM Aeoronaves",
                  new ABMGenericoForm("ABM Aeoronaves", new crearCiudadForm(), null, null)));
        
        }

        public List<Funcionalidades> getFuncionalidadesDisponibles{
           get {return funcionalidadesDisponibles ;}
        }

    }
}
