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
        public static List<Usuario> Usuarios = new List<Usuario>();
        public static Usuario UsuarioActual { get; set; }


        public static void CrearUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public static void IniciarSesion(Usuario usuario)
        {
            UsuarioActual = usuario;
        }

        public static List<Usuario> CargarUsuariosDesdeJSON()
        {
            string rutaArchivo = Path.Combine(@"C:\Users\Matìas\source\repos\Parcial-Volquete\Data-Base", "usuarios.json");
            Usuarios = Serializadora.LeerJson(rutaArchivo);
            return Usuarios;
        }
        public static void GuardarUsuariosEnJSON()
        {
            string rutaArchivo = Path.Combine(@"C:\Users\Matìas\source\repos\Parcial-Volquete\Data-Base", "usuarios.json");
            Serializadora.EscribirJson(rutaArchivo, Usuarios);
        }
       


    }
}