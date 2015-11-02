using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

using AerolineaFrba.FormsPrincipales;
using AerolineaFrba.Abm_Rol;
using AerolineaFrba.Abm_Ciudad;
using AerolineaFrba.Abm_Ruta;
using AerolineaFrba.Abm_Aeronave;
using AerolineaFrba.Compra;

namespace AerolineaFrba.Dominio
{
    public static class Sesion
    {
        public static List<Funcionalidades> funcionalidadesDisponibles = new List<Funcionalidades>();
        private static Usuario Usuario =new Usuario("a","p","r",9999);

        public static void iniciar(string username, string password,string rol)
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

                funcionalidadesDisponibles = new List<Funcionalidades>();
            //--Creo y Agrego ABM ROL
             funcionalidadesDisponibles.Add(new Funcionalidades(99, "ABM ROL",
                 new ABMGenericoForm("ABM Rol", new CrearRolForm(), new ModificarForm("Modificar Rol", "Modificar", 1), new ModificarForm("Eliminar Rol", "Eliminar", 2))));

             funcionalidadesDisponibles.Add(new Funcionalidades(99, "ABM Ciudades",
                  new ABMGenericoForm("ABM Ciudades", new crearCiudadForm(), new modificarEliminarCityForm(1), new modificarEliminarCityForm(2) )));

             funcionalidadesDisponibles.Add(new Funcionalidades(99, "ABM Rutas",
                new ABMGenericoForm("ABM Rutas", new crearRutaForm(), new ModificarEliminarRuta(1), new ModificarEliminarRuta(2) )));

             funcionalidadesDisponibles.Add(new Funcionalidades(99, "ABM Aeronave",
               new ABMGenericoForm("ABM Aeronave", new AltaAeronave(), new ModificarAeronave(), new crearRutaForm())));

            funcionalidadesDisponibles.Add(new Funcionalidades(99, "c1",new compraForm()));
            funcionalidadesDisponibles.Add(new Funcionalidades(99, "c2",new compraPasajeForm() ));
            funcionalidadesDisponibles.Add(new Funcionalidades(99, "c3",new datosPasajeroForm()));


        }

        public static List<Funcionalidades> getFuncionalidadesDisponibles{
           get {return funcionalidadesDisponibles ;}
        }

    }
}
