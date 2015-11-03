using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Dominio
{
    public class Butaca
    {
        public string queryid;
        public string numero_butaca;
        public string tipo_butaca;
        public string piso_butaca;
        public string matriculaButaca;

        public Butaca(string queryid, string numero_butaca, string tipo_butaca, string piso_butaca, string p)
        {
            this.queryid = queryid;
            this.numero_butaca = numero_butaca;
            this.tipo_butaca = tipo_butaca;
            this.piso_butaca = piso_butaca;
            this.matriculaButaca = p;
        }
    }
}
