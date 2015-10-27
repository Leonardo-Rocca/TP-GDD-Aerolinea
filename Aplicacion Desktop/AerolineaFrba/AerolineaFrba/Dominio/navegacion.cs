using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dominio
{
    public static class navegacion
    {
        private static Form owner;
        private static Form auxiliarForm;

        public static  Form Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }
        public static new Form AuxiliarForm
        {
            get
            {
                return auxiliarForm;
            }
            set
            {
                auxiliarForm = value;
            }
        }


    }
}
