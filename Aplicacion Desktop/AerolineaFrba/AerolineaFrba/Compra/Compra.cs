using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

using AerolineaFrba.Dominio;

namespace AerolineaFrba.Compra
{
    public static class Compra
    {
        public static PasajeEncomienda persona;
        public static  compraForm compra;
        public static bool pagaEnEfectivo = false;
        public static PasajeEncomienda comprador { get; set; }
        public static Tarjeta tarjeta;

        public static void inicializar(){
            pagaEnEfectivo = false;
            tarjeta = new Tarjeta("0", "0","2016-12-10", "0", "0", "0");
        }

        internal static void realizarCompra()
        {
            comprador.darDeAltaClienteSiNoExiste();
           
           
            string qGenerarCompra = "execute  DBAS.generarCompra " + comprador.idCliente + "," + tarjeta.numeroTarjeta + " , " + tarjeta.codigo + ", '"+tarjeta.dateTime+"' ," + tarjeta.tipoTarjetaId + "," + tarjeta.cuotasElegidas + " ," + tarjeta.tipo;
            (new ConexionSQL()).ejecutarComandoSQL(qGenerarCompra);
         
            
                CultureInfo culture = new CultureInfo("es-ES");

                try
                {                //obtengo el ultimo
                DataTable dt = (new ConexionSQL()).cargarTablaSQL("select top 1 (id_compra_PNR) AS codigo FROM DBAS.compras ORDER BY 1 DESC");
                DataRow row = dt.Rows[0];
                string idCompra = row[0].ToString();

                if(compra.encomiendas!=null){
                    PasajeEncomienda encomienda = compra.encomiendas;
                encomienda.darDeAltaClienteSiNoExiste();

                string queryEncomienda = "Insert into DBAS.encomiendas (id_cliente ,encomienda_cliente_KG ,id_viaje, precio_encomienda, id_compra_PNR ,fecha_compra_encomienda) values (" +
                                      encomienda.idCliente + ", " + encomienda.butacaKg + ", " + compra.viaje.idViaje + " , @Parametro, " + idCompra +",'"+DateTime.Parse(Program.nuevaFechaSistema())+"' )";    //+Double.Parse(compra.viaje.precioKg,culture) +

                string precioTotalEncomienda = (Convert.ToDouble(compra.viaje.precioKg)* Convert.ToDouble(encomienda.butacaKg)).ToString();
                (new ConexionSQL()).ejecutarComandoSQLConParametro(queryEncomienda,precioTotalEncomienda );
                

                }
                foreach (PasajeEncomienda pasajero in compra.pasajes)
                {
                    string queryPasaje = "Insert into DBAS.pasajes (id_cliente,id_viaje, id_butaca, precio_pasaje ,id_compra_PNR) values (" +
                     pasajero.idCliente + ", " + compra.viaje.idViaje + " , " + pasajero.butacaKg + " , @Parametro , " + idCompra + ")";
                     pasajero.darDeAltaClienteSiNoExiste();

                     (new ConexionSQL()).ejecutarComandoSQLConParametro(queryPasaje, compra.viaje.precioPasaje);
                }

                MessageBox.Show("Su compra ha sido 'exitosa'.Su PNR es: "+idCompra+". Con dicho número se deberá acercar el día del viaje a canjear sus pasajes y/o entregar el paquete encomienda.");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

      

    }
}
