using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class Serializadora
    {
        public static void EscribirJson(string ruta, List<Usuario> lista)
        {
            try
            {
                string json = JsonConvert.SerializeObject(lista, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(ruta, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static List<Usuario> LeerJson(string path)
        {
            List<Usuario> lista = null;
            try
            {
                string json = File.ReadAllText(path);
                lista = JsonConvert.DeserializeObject<List<Usuario>>(json);

            }
            catch (Exception e)
            {

            }
            return lista;


        }

        public static void ActualizarJson(string ruta, List<Usuario> lista) 
        {
            try
            {
                string json = JsonConvert.SerializeObject(lista, Newtonsoft.Json.Formatting.Indented);

                using (StreamWriter file = new StreamWriter(ruta, true))
                {
                    file.WriteLine(json);
                }
            }
            catch
            {

            }
        
        }

    }
}
