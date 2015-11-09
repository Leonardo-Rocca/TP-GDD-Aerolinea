using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

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
              string comando;
           if (id == "")
           {
               comando = "execute dbas.altaPersona " + dni + " , '" + nombre + "', '" + apellido + "', '" + direccion + "', '"+tel+"','"+mail+"','"+fecha+"',99";
               DataTable dt = (new ConexionSQL()).cargarTablaSQL(comando);
               MessageBox.Show(comando);
               id = obtenerUltimoId();
           }else{
                comando= "UPDATE DBAS.personas SET nombre_persona = '"+nombre+"',apellido_persona = '"+apellido +"',direccion_persona = '"+direccion+"',telefono_persona = '"+tel+"',mail_persona = '"+mail+"',fecha_nacimiento = '"+fecha+
                    "' WHERE id_persona = "+id;
                DataTable dt = (new ConexionSQL()).cargarTablaSQL(comando);
                MessageBox.Show(comando);
           }
            //to do... actualizar datos -- falta probar
       }

        private string obtenerUltimoId()
        {
            string query = "select top 1 id_persona from dbas.personas order by 1 desc";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            return dt.Rows[0][0].ToString();
        }

    }
}
