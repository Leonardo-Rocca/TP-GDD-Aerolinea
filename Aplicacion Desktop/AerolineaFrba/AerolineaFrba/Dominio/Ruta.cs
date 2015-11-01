using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Dominio
{
    public class Ruta
    {
        public int idRuta { get; set; }
        public string ciudad_Origen { get; set; }
        public string ciudad_Destino;
        public string precio_base_por_pasaje;
        public string precio_base_por_KG;
        public string tipo_servicio;
        public string porcentaje_arancel;
        public List<string> servicios;

        public Ruta(int p, string ciudad_Origen, string ciudad_Destino, string precio_base_por_pasaje, string precio_base_por_KG, string tipo_servicio, string porcentaje_arancel, List<string> servicio)
        {
            this.idRuta = p;
            this.ciudad_Origen = ciudad_Origen;
            this.ciudad_Destino = ciudad_Destino;
            this.precio_base_por_pasaje = precio_base_por_pasaje;
            this.precio_base_por_KG = precio_base_por_KG;
            this.tipo_servicio = tipo_servicio;
            this.porcentaje_arancel = porcentaje_arancel;
            this.servicios = servicio;
        }

    }
}
