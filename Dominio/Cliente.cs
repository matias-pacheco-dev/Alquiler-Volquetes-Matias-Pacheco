namespace Dominio
{
    [Serializable]
    public class Cliente : Usuario
    {
        public List<Alquiler> alquileres;

        public Cliente(int iddb, string id, string contraseña, int tipoUsuario) : base(iddb, id, contraseña, tipoUsuario)
        {

            this.alquileres = new List<Alquiler>();

        }
        public Cliente(int iddb, string id, string contraseña, List<Alquiler> list, int tipoUsuario) : base(iddb, id, contraseña, tipoUsuario)
        {

            this.alquileres = list;

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
