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
using AerolineaFrba.Generacion_Viaje;
using AerolineaFrba.Consulta_Millas;

namespace AerolineaFrba.Dominio
{
    public static class Sesion
    {
        public static List<Funcionalidades> funcionalidadesDisponibles = new List<Funcionalidades>();
        public static Usuario Usuario;

        public static void iniciar(string username, string password,string rol)
        {
           //("chequear_login", username, password);
       
          //  Sesion.Usuario = new Usuario(Convert.ToInt32(tablaUsuario.Rows[0]["id_usuario"]), tablaUsuario.Rows[0]["username"].ToString());
            if (rol == "Administrador General")
            {
          
                 string comando = "execute dbas.loginUsuario '"+ username +"', '" +password+ "'"; 
                 DataTable dt =  (new ConexionSQL()).cargarTablaSQL(comando);
               
            }

            Usuario= new Usuario("a","p",rol,9999);

            //OBTENER FUNCDISP SEGUN EL ROL
            string qfuncion = "select * from  DBAS.obtenerFuncionalidadesAsociadas ('" + rol + "')";
            DataTable dtfunciones =  (new ConexionSQL()).cargarTablaSQL(qfuncion);

            cargarFuncionalidades(dtfunciones);
            
        
        }

        private static void cargarFuncionalidades(DataTable dtfunciones)
        {
            funcionalidadesDisponibles = new List<Funcionalidades>();

                for (int i = 0; i <= (dtfunciones.Rows.Count - 1); i++)
            {
                    funcionalidadesDisponibles.Add(obtenerFuncionalidad(dtfunciones.Rows[i][0].ToString() ));
              }
        }

        private static Funcionalidades obtenerFuncionalidad(string descripcionF)
        {
            if(descripcionF=="ABM de Rol")
             return (new Funcionalidades(99, "ABM ROL",
                new ABMGenericoForm("ABM Rol", new CrearRolForm(), new ModificarForm("Modificar Rol", "Modificar", 1), new ModificarForm("Eliminar Rol", "Eliminar", 2))));
               
            if(descripcionF=="ABM de Ciudades")
            return (new Funcionalidades(99, "ABM Ciudades",
                 new ABMGenericoForm("ABM Ciudades", new crearCiudadForm(), new modificarEliminarCityForm(1), new modificarEliminarCityForm(2))));

            if(descripcionF=="ABM de Ruta Aerea")
            return (new Funcionalidades(99, "ABM Rutas",
               new ABMGenericoForm("ABM Rutas", new crearRutaForm(), new ModificarEliminarRuta(1), new ModificarEliminarRuta(2))));

            if (descripcionF == "ABM de Aeronaves")
            return (new Funcionalidades(99, "ABM Aeronave", new ABMGenericoForm("ABM Aeronave", new AltaAeronave(), new ModificarAeronave(0), new ModificarAeronave(1))));
                      
            if(descripcionF=="Generar Viaje")
            return  (new Funcionalidades(99, "Generar Viaje", new Generar_Viaje()));
            
            if (descripcionF == "Listado Estadístico")
            return (new Funcionalidades(99, "Listado Estadistico", new Top5.DiscriminadorTop5()));

             if (descripcionF == "Registro de llegada Destino")
            return (new Funcionalidades(99, "Registro de llegada Destino", new Registro_Llegada_Destino.RegistroLLegadaForm()));

               if (descripcionF == "Compra de Pasaje/Encomienda")
            return (new Funcionalidades(99, "Comprar Pasaje/Encomienda", new SeleccionViajeForm()));
            
            if (descripcionF == "Consulta de millas de pasajero frecuente")
            return (new Funcionalidades(99, "Consultar millas", new ConsultarMillasForm()));
            //Registro de Usuario
            //default..
            return (new Funcionalidades(99, "Devolucion ", new Devolucion.Devolucion()));

//Cancelación/Devolución de pasaje y/o encomienda
//Canje de millas de pasajero frecuente

        }

        public static List<Funcionalidades> getFuncionalidadesDisponibles{
           get {return funcionalidadesDisponibles ;}
        }

    }
}
