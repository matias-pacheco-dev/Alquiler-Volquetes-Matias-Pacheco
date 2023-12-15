using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Dominio;

namespace Dominio
{
    public class Transferencia : IMetodoPago
    {
        public string ProcesarPago(decimal monto)
        {
            // Lógica específica para transferencia
            return $"Procesando pago de {monto:C} mediante transferencia.";
        }

        public void GenerarFactura(Alquiler alquiler)
        {
            // Crear un documento XML
            XmlDocument xmlDoc = new XmlDocument();

            // Crear el elemento principal (Factura)
            XmlElement facturaElement = xmlDoc.CreateElement("Factura");

            // Agregar información del alquiler al XML
            XmlElement alquilerElement = xmlDoc.CreateElement("Alquiler");
            alquilerElement.SetAttribute("ID", alquiler.IdAlquiler.ToString());
            alquilerElement.SetAttribute("Monto", alquiler.Precio.ToString("C"));
            // Agregar más atributos e información según sea necesario

            // Agregar la información del banco falso
            XmlElement bancoElement = xmlDoc.CreateElement("BancoFalso");
            bancoElement.SetAttribute("Nombre", "Banco Falso");
            bancoElement.SetAttribute("NumeroCuenta", "XXXX-XXXX-XXXX-XXXX");
            bancoElement.SetAttribute("NombreTitular", "Nombre Falso");

            // Agregar las instrucciones
            XmlElement instruccionesElement = xmlDoc.CreateElement("Instrucciones");
            instruccionesElement.InnerText = "Realice una transferencia por el monto indicado a la cuenta bancaria mencionada.";

            // Adjuntar elementos al documento XML
            alquilerElement.AppendChild(bancoElement);
            alquilerElement.AppendChild(instruccionesElement);
            facturaElement.AppendChild(alquilerElement);
            xmlDoc.AppendChild(facturaElement);

            // Obtener la ruta del escritorio del usuario
            string escritorioUsuario = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Construir la ruta completa del archivo XML en el escritorio
            string rutaArchivo = Path.Combine(escritorioUsuario, $"Factura_{alquiler.IdAlquiler}.xml");

            // Guardar el documento XML en el archivo en el escritorio
            xmlDoc.Save(rutaArchivo);

        }



    }
}


