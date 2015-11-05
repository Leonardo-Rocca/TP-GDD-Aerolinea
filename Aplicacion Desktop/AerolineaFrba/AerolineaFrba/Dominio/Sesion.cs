﻿using System;
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

                funcionalidadesDisponibles = new List<Funcionalidades>();
            //--Creo y Agrego ABM ROL
             funcionalidadesDisponibles.Add(new Funcionalidades(99, "ABM ROL",
                 new ABMGenericoForm("ABM Rol", new CrearRolForm(), new ModificarForm("Modificar Rol", "Modificar", 1), new ModificarForm("Eliminar Rol", "Eliminar", 2))));

             funcionalidadesDisponibles.Add(new Funcionalidades(99, "ABM Ciudades",
                  new ABMGenericoForm("ABM Ciudades", new crearCiudadForm(), new modificarEliminarCityForm(1), new modificarEliminarCityForm(2) )));

             funcionalidadesDisponibles.Add(new Funcionalidades(99, "ABM Rutas",
                new ABMGenericoForm("ABM Rutas", new crearRutaForm(), new ModificarEliminarRuta(1), new ModificarEliminarRuta(2) )));

             funcionalidadesDisponibles.Add(new Funcionalidades(99, "ABM Aeronave",
               new ABMGenericoForm("ABM Aeronave", new AltaAeronave(), new ModificarAeronave(0), new ModificarAeronave(1))));

             funcionalidadesDisponibles.Add(new Funcionalidades(99, "Generar Viaje",
             new Generar_Viaje()));

             funcionalidadesDisponibles.Add(new Funcionalidades(99, "Devolucion de pasajes y/o encomiendas",
             new Devolucion.Devolucion()));

             funcionalidadesDisponibles.Add(new Funcionalidades(99, "Listado Estadistico",new Top5.DiscriminadorTop5()));

            funcionalidadesDisponibles.Add(new Funcionalidades(99, "Comprar Pasaje/Encomienda", new SeleccionViajeForm()));

            funcionalidadesDisponibles.Add(new Funcionalidades(99, "Consultar millas", new ConsultarMillasForm()));
        
        }

        public static List<Funcionalidades> getFuncionalidadesDisponibles{
           get {return funcionalidadesDisponibles ;}
        }

    }
}
