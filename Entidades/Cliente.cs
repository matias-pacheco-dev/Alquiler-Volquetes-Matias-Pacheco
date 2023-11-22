using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Cliente : Usuario
    {
        public List<Alquiler> alquileres;

        public Cliente(string id, string contraseña):base (id, contraseña) 
        {
          
            this.alquileres = new List<Alquiler>();

        }
        

        public void AgregarAlquiler(Alquiler alquiler)
        {
            alquileres.Add(alquiler);
        }

        public override string ToString()
        {
            return $"{this.id} -- {this.contraseña} -- {this.alquileres}";
        }

        
          



    }
}
