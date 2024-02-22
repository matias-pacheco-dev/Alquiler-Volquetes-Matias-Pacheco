using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestLibrary
{
    
    [TestClass]
    public class SerializadorTest
    {
        private readonly string PathPrueba = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        [TestMethod]
        public void SerializadorJson_SerializarYDeserializar_DatosCorrectos()
        {
            // Arrange
            string filePath = Path.Combine(PathPrueba, "test.json");
            var serializadorJson = new SerializadorJson<string>(filePath);
            var datosOriginales = "Datos de prueba";

            // Act
            serializadorJson.Serializar(datosOriginales);
            var datosDeserializados = serializadorJson.Deserializar();

            // Assert
            Assert.AreEqual(datosOriginales, datosDeserializados);

            // Limpiar el archivo después de la prueba
            File.Delete(filePath);
        }

        [TestMethod]
        public void SerializadorXML_SerializarYDeserializar_DatosCorrectos()
        {
            // Arrange
            string filePath = Path.Combine(PathPrueba, "test.xml");
            var serializadorXML = new SerializadorXML<string>(filePath);
            var datosOriginales = "Datos de prueba";

            // Act
            serializadorXML.Serializar(datosOriginales);
            var datosDeserializados = serializadorXML.Deserializar();

            // Assert
            Assert.AreEqual(datosOriginales, datosDeserializados);

            // Limpiar el archivo después de la prueba
            File.Delete(filePath);
        }
    }
}
