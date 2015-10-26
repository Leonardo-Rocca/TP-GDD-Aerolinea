using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using AerolineaFrba.FormsPrincipales;
using AerolineaFrba.Abm_Rol;
using AerolineaFrba.Abm_Ciudad;
using AerolineaFrba.Abm_Ruta;
using AerolineaFrba.Abm_Aeronave;


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
            if (rol == "Administrador")
            {
          
                 string comando = "execute dbas.loginUsuario '"+ username +"', '" +password+ "'"; 
                 DataTable dt =  (new ConexionSQL()).cargarTablaSQL(comando);
               
            }

            if (username == "" && password == "") //---> es usuario
            {
              //TO-DO
    
            }
            //OBTENER FUNCDISP SEGUN EL ROL

            //--Creo y Agrego ABM ROL
             funcionalidadesDisponibles.Add(new Funcionalidades(99, "ABM ROL",
                 new ABMGenericoForm("ABM Rol", new CrearRolForm(), new ModificarForm("Modificar Rol", "Modificar", 1), new ModificarForm("Eliminar Rol", "Eliminar", 2))));

             funcionalidadesDisponibles.Add(new Funcionalidades(99, "ABM Ciudades",
                  new ABMGenericoForm("ABM Ciudades", new crearCiudadForm(), new modificarEliminarCityForm("Modificar ciudad","Modificar",1), new modificarEliminarCityForm("Eliminar Ciudad","Eliminar",2) )));

             funcionalidadesDisponibles.Add(new Funcionalidades(99, "ABM Rutas",
                new ABMGenericoForm("ABM Rutas", new crearRutaForm(), new crearRutaForm(), new crearRutaForm())));

             funcionalidadesDisponibles.Add(new Funcionalidades(99, "ABM Aeronave",
               new ABMGenericoForm("ABM Aeronave", new AltaAeronave(), new ModificarAeronave(), new crearRutaForm())));
        }

        public List<Funcionalidades> getFuncionalidadesDisponibles{
           get {return funcionalidadesDisponibles ;}
        }

    }
}
