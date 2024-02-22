using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using AccesoDatos;
using Dominio;


namespace TestLibrary
{
    [TestClass]
    public class AlquilerTest
    {
        [TestMethod]
        public void ObtenerAlquileres_DeberiaRetornarListaDeAlquileres()
        {
            // Arrange
            AlquilerDao alquilerDao = new AlquilerDao();

            // Act
            List<Alquiler> alquileres = alquilerDao.ObtenerAlquileres();

            // Assert
            Assert.IsNotNull(alquileres);
            Assert.IsTrue(alquileres.Count > 0);
        }

        [TestMethod]
        public void ContabilizarAlquileresEnBD_DeberiaRetornarNumeroPositivo()
        {
            // Arrange
            AlquilerDao alquilerDao = new AlquilerDao();

            // Act
            int count = alquilerDao.ContabilizarAlquileresEnBD();

            // Assert
            Assert.IsTrue(count >= 0);
        }

    }
}



