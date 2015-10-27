using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Dominio
{
    class Usuario
    {
        int id;
        private string nombre;
        private string password;
        private string nombreRol;
        int rolId;

        public Usuario(string name,string pass ,string nRol,int rid)
        {
            nombre=name;
            password=pass;
            nombreRol=nRol;
            rolId=rid;
        }
    }
}
