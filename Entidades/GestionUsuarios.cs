using AccesoDatos;
using Dominio;
namespace Entidades
{

    public static class GestionUsuarios
    {
        public static List<Cliente> Usuarios = new List<Cliente>();
        public static Cliente UsuarioActual { get; set; }

        public static List<Administrador> Admins = new List<Administrador>();
        public static Administrador AdminActual { get; set; }



        public static void CrearUsuario(Cliente nuevoUsuario)
        {
            Usuarios.Add(nuevoUsuario);
        }

        public static void IniciarSesion(Cliente usuario)
        {
            UsuarioActual = usuario;
        }

        public static void IniciarSesionAdmin(Administrador Admin)
        {
            AdminActual = Admin;
        }

        public static void CerrarSesion()
        {
            Usuarios.Clear();
            Admins.Clear();

            UsuarioActual = null;
            AdminActual = null;
        }


        

      








    }

}