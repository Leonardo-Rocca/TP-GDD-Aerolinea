using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dominio
{
    class Funcionalidades
     {
        int id;
        Form FormAsociado;

        public Funcionalidades(int identifyer, string descripcion,Form elFormCaracteristico)
        {
            this.id = identifyer;
            this.Descripcion = descripcion;
            FormAsociado = elFormCaracteristico;
        }

        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }

    }
}
