using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba;


namespace AerolineaFrba
{

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // MessageBox.Show(Program.nuevaFechaSistema().ToString(),"Fecha",MessageBoxButtons.OK);
        
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

             Application.Run(new PantallaBienvenidaForm());
             
          
        }


        public static  String nuevaFechaSistema(){
            return ConfigurationManager.AppSettings["FechaGlobal"];
        }
    }
}
