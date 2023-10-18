using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Usuario
    {
        public string id;
        public string contraseña;
        public List<Alquiler> alquileres;

        public Usuario(string id, string contraseña)
        {
            this.Id = id;
            this.Contraseña = contraseña;
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

        #region Getters/Setters
        public string Id 
        { 
            get => id; set => id = value; 
        }
        public string Contraseña 
        { 
            get => contraseña; set => contraseña = value; 
        }
        #endregion 
         



    }
}
