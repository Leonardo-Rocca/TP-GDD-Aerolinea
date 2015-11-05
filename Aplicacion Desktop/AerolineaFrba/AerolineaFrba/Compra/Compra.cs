using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Dominio;
namespace AerolineaFrba.Compra
{
    public static class Compra
    {
        public static PasajeEncomienda persona;
        public static  compraForm compra;
        public static bool pagaEnEfectivo = false;
        public static PasajeEncomienda comprador { get; set; }

        public static void inicializar(){
            pagaEnEfectivo = false;
        }
        internal static void realizarCompra()
        {
            //TO-DO 
            string idCompra = "100";//dammy
            PasajeEncomienda encomienda=  compra.encomiendas;
            string queryEncomienda = "Insert into DBAS.encomiendas (id_cliente,encomienda_cliente_KG,id_viaje,precio_encomienda,id_compra_PNR) values (" +
            encomienda.id + ", " + encomienda.butacaKg + ", " + compra.viaje.idViaje + " , " + compra.viaje.precioKg + " , " + idCompra;

      /*      foreach(PasajeEncomienda pasajero in compra.pasajes){
                string queryPasaje = "Insert into DBAS.encomiendas (id_cliente,encomienda_cliente_KG,id_viaje,precio_encomienda,id_compra_PNR) values (" +
            encomienda.id + ", " + encomienda.butacaKg + ", " + compra.viaje.idViaje + " , " + compra.viaje.precioKg + " , " + idCompra;
            }*/
        }


    }
}
