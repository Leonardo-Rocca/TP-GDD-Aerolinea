using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using AerolineaFrba.Abm_Ciudad;
namespace AerolineaFrba.Dominio
{
    public static class navegacion
    {
        public static modificarEliminarCityForm modificarCiudad;
        private static modificarEliminarCityForm eliminarCiudad;
        public static Form modifRol;
        public static Form eliminarRol;
        public static Abm_Ruta.ModificarEliminarRuta modificarRuta;
        public static Abm_Ruta.ModificarEliminarRuta eliminarRuta;

        public static  modificarEliminarCityForm ModificarCiudad
        {
            get
            {
                return modificarCiudad;
            }
            set
            {
                modificarCiudad = value;
            }
        }
        public static new modificarEliminarCityForm EliminarCiudad
        {
            get
            {
                return eliminarCiudad;
            }
            set
            {
                eliminarCiudad = value;
            }
        }



        public static FormsPrincipales.Redireccionador redireccionador { get; set; }
    }
}
