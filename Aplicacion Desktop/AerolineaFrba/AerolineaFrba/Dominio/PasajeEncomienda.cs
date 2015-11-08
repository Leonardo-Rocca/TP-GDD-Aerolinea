using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AerolineaFrba.Dominio
{
   public class PasajeEncomienda
    {
       public string id;

        public string nombre;
        public string apellido;
        public string dni;
        public string tel;
        public string mail;
        public string fecha;
        public string butacaKg="";
        public string direccion;
      

       public PasajeEncomienda(string id,string p1, string p2, string dni, string tel, string p3, string p4, string butacaKg)
       {
           this.id = id;
           this.nombre = p1;
           this.apellido = p2;
           this.dni = dni;
           this.tel = tel;
           this.mail = p3;
           this.fecha = p4;
           this.butacaKg = butacaKg;

       }
       
        public void darDeAltaClienteSiNoExiste()
       {
           if (id == "")
           {
               string comando = "execute dbas.altaPersona " + dni + " , '" + nombre + "', '" + apellido + "', '" + direccion + "', '"+tel+"','"+mail+"','"+fecha+"',999";
               DataTable dt = (new ConexionSQL()).cargarTablaSQL(comando);
           }
            //to do... actualizar datos
       }

    }
}
