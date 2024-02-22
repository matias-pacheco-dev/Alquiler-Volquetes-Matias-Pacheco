namespace Dominio
{

    public abstract class Usuario
    {
        public int idDB { get; set; }
        public int TipoUsuario { get; set; }
        public string id { get; set; }
        public string contraseña { get; set; }
        public Usuario(int iddb, string id, string contraseña, int tipoUsuario)
        {
            this.idDB = iddb;
            this.id = id;
            this.contraseña = contraseña;
            this.TipoUsuario = tipoUsuario;
        }

        public abstract string ObtenerTipo();



    }
}
