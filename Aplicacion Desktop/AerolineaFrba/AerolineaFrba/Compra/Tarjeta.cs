using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AerolineaFrba.Compra
{
    public class Tarjeta
    {
        public string numeroTarjeta;
        public string codigo;
        public DateTime dateTime;
        public string tipoTarjetaId;
        public string cuotasElegidas;
        public string tipo;//0 efectivo 1tarjeta

        public Tarjeta(string number, string code, DateTime dateTime, string idType, string cuotas, string efectivoTarjeta)
        {
            this.numeroTarjeta = number;
            this.codigo = code;
            this.dateTime = dateTime;
            this.tipoTarjetaId = idType;
            this.cuotasElegidas = cuotas;
            this.tipo = efectivoTarjeta;
        }
    }
}
