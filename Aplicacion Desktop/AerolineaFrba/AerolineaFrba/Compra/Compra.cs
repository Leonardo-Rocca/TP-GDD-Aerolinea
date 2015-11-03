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
            throw new NotImplementedException();
        }


    }
}
