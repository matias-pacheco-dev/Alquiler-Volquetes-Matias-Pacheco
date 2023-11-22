using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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



        #region
        public static void CargarUsuariosDesdeJSON()
        {
            string rutaArchivo = Path.Combine(@"C:\Users\Matìas\source\repos\Parcial-Volquete\Data-Base", "usuarios.json");
            Usuarios = Serializadora.LeerJson(rutaArchivo);

        }
        public static void GuardarUsuariosEnJSON()
        {
            foreach (Cliente usuario in Usuarios)
            {
                if (usuario.id == UsuarioActual.id)
                {
                    usuario.alquileres = UsuarioActual.alquileres;
                }
            }
            string rutaArchivo = Path.Combine(@"C:\Users\Matìas\source\repos\Parcial-Volquete\Data-Base", "usuarios.json");
            Serializadora.EscribirJson(rutaArchivo, Usuarios);
        }

        public static void CargarAdminDesdeJSON()
        {
            string rutaArchivo = Path.Combine(@"C:\Users\Matìas\source\repos\Parcial-Volquete\Data-Base", "admins.json");
            Admins = Serializadora.LeerJsonAdmin(rutaArchivo);

        }
        #endregion


       

        




    }

}