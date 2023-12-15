using Newtonsoft.Json;
using Dominio;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Entidades
{
    public static class Serializadora
    {
        #region JSON

        public static void GenerarLogDeError(LogEntry logEntry)
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string logFilePath = Path.Combine(desktopPath, "error_log.json");

                string logJson = JsonConvert.SerializeObject(logEntry);

                using (StreamWriter sw = File.AppendText(logFilePath))
                {
                    sw.WriteLine(logJson);
                }
            }
            catch (Exception)
            {
                
            }
        }

        public class LogEntry
        {
            public DateTime Timestamp { get; set; }
            public string Message { get; set; }
        }

        #endregion

        #region XML
        public static void GuardarAlquileresEnXML(List<Alquiler> alquileres, string fileName)
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fullPath = Path.Combine(desktopPath, fileName);

                XmlSerializer serializer = new XmlSerializer(typeof(List<Alquiler>));

                using (StreamWriter writer = new StreamWriter(fullPath))
                {
                    serializer.Serialize(writer, alquileres);
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        #endregion

    }
}


    







