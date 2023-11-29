using Newtonsoft.Json;
using Dominio;
namespace Entidades
{
    public static class Serializadora
    {
        public static void EscribirJson(string ruta, List<Cliente> lista)
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




        public static List<Cliente> LeerJson(string path)
        {
            List<Cliente> lista = null;
            try
            {
                string json = File.ReadAllText(path);
                lista = JsonConvert.DeserializeObject<List<Cliente>>(json);

            }
            catch (Exception e)
            {

            }
            return lista;
        }




        public static void ActualizarJson(string ruta, List<Cliente> lista)
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

        public static List<Administrador> LeerJsonAdmin(string path)
        {
            List<Administrador> lista = null;
            try
            {
                string json = File.ReadAllText(path);
                lista = JsonConvert.DeserializeObject<List<Administrador>>(json);

            }
            catch (Exception e)
            {

            }
            return lista;
        }


    }
}
