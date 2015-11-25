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
       public string idPersona;

        public string nombre;
        public string apellido;
        public string dni;
        public string tel;
        public string mail;
        public string fecha;
        public string butacaKg="";
        public string direccion;

        public string idCliente="";
        private string idPersona1;
        private string p1;
        private string p2;
        private string dni1;
        private string tel1;
        private string p3;
        private string p4;
        private string butacaKg1;
        private int p5;
       private int tipo = 1;

       public PasajeEncomienda(string id,string name, string lname, string dni, string tel, string email, string p4, string butacaKg)
       {
           this.idPersona = id;
           this.nombre = name;
           this.apellido = lname;
           this.dni = dni;
           this.tel = tel;
           this.mail = email;
           this.fecha = p4;
           this.butacaKg = butacaKg;
           darDeAltaClienteSiNoExiste();
           idCliente = obtenerIdCliente();

       }

       public PasajeEncomienda(string id, string name, string lname, string dni, string tel, string email, string p4, string butacaKg,int code)
       {
           this.idPersona = id;
           this.nombre = name;
           this.apellido = lname;
           this.dni = dni;
           this.tel = tel;
           this.mail = email;
           this.fecha = p4;
           this.butacaKg = butacaKg;
           this.tipo = code;
           darDeAltaClienteSiNoExiste();
           idCliente = obtenerIdCliente();

       }

       
        public void darDeAltaClienteSiNoExiste()
       {
              string comando="";
           if (idPersona == ""/*||existeAlguienConMismoDNI()*/)
           {
               comando = "execute dbas.altaCliente " + dni + " , '" + nombre + "', '" + apellido + "', '" + direccion + "', '"+tel+"','"+mail+"','"+fecha+"'";
           //   (new ConexionSQL()).ejecutarComandoSQL(comando);

               idCliente = obtenerUltimoIdCliente();
               idPersona = obtenerUltimoIdPersona();
           }else{
        //        comando= "UPDATE DBAS.personas SET nombre_persona = '"+nombre+"',apellido_persona = '"+apellido +"',direccion_persona = '"+direccion+"',telefono_persona = '"+tel+"',mail_persona = '"+mail+"',fecha_nacimiento = '"+fecha+
        //            "' WHERE id_persona = "+idPersona;
             if(tipo==1)  comando = "execute DBAS.actualizarCliente " + dni + " , '" + nombre + "', '" + apellido + "', '" + direccion + "', '" + tel + "','" + mail + "','" + fecha + "'";
             if (tipo == 0) comando = "execute DBAS.actualizarClienteEncomienda " + dni + " , '" + nombre + "', '" + apellido + "', '" + direccion + "', '" + tel + "','" + mail + "','" + fecha + "'";

               // DataTable dt = (new ConexionSQL()).cargarTablaSQL(comando);
            
           }
           (new ConexionSQL()).ejecutarComandoSQL(comando);

       }

        private string obtenerUltimoIdPersona()
        {
            string query = "select top 1 id_persona from dbas.personas order by 1 desc";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            return dt.Rows[0][0].ToString();
        }

        private bool existeAlguienConMismoDNI()
        {
            string query = "select id_persona from dbas.personas WHERE dni_persona = "+dni;
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            return dt.Rows.Count>1;
        }

        private string obtenerUltimoIdCliente()
        {
            string query = "select top 1 id_cliente from dbas.clientes order by 1 desc";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            return dt.Rows[0][0].ToString();
        }

        private string obtenerIdCliente()
        {
            string query = "select  id_cliente from dbas.clientes c,dbas.personas p where  p.id_persona=c.id_persona AND dni_persona = " + dni;
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            return dt.Rows[0][0].ToString();
        }
    }
}
