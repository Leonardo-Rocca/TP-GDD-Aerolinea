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

        public Tarjeta(string p1, string p2, DateTime dateTime, string p3, string p4, string p5)
        {
            this.numeroTarjeta = p1;
            this.codigo = p2;
            this.dateTime = dateTime;
            this.tipoTarjetaId = p3;
            this.cuotasElegidas = p4;
            this.tipo = p5;
        }
    }
}
