using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Dominio
{
   public class PasajeEncomienda
    {
        public string nombre;
        public string apellido;
        public string dni;
        public string tel;
        public string mail;
        public string fecha;
        public string butacaKg="";

       public PasajeEncomienda(string p1, string p2, string dni, string tel, string p3, string p4, string butacaKg)
       {
           this.nombre = p1;
           this.apellido = p2;
           this.dni = dni;
           this.tel = tel;
           this.mail = p3;
           this.fecha = p4;
           this.butacaKg = butacaKg;
       }
    }
}
