using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
 
    public abstract class Usuario
    {
        public string id { get; set; }
        public string contraseña { get; set; }

        public Usuario(string id, string contraseña)
        {
            this.id = id;
            this.contraseña = contraseña;
        }



    }
}
 