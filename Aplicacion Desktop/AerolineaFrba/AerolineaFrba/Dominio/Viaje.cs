using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Dominio
{
    public class Viaje
    {
        public string kgsDisponibles;
        public string butacas_disponibles;

        public string idViaje;
        public string fechaSalida;
        public string precioPasaje;
        public string precioKg;
        public string matriculaAeronave1;
        public string kgs_disponibles;


        public Viaje(string idViaje, string fechaSalida, string precioPasaje, string precioKg, string matriculaAeronave1)
        {
            this.idViaje = idViaje;
            this.fechaSalida = fechaSalida;
            this.precioPasaje = precioPasaje;
            this.precioKg = precioKg;
            this.matriculaAeronave1 = matriculaAeronave1;
        }
    }
}
