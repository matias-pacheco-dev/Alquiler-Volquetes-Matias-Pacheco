using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Moq;
using System.Data;
using Dominio;

namespace TestLibrary
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void Login_WhenValidClientUserAndPassword_ReturnsClientUser()
        {
            // Arrange
            var mockDao = new Mock<UserDao>();
            string clientUsername = "validClientUser";
            string clientPassword = "validClientPassword";
            mockDao.Setup(dao => dao.Login(clientUsername, clientPassword))
                   .Returns(new Cliente(1, clientUsername, clientPassword, 1));

            // Act
            Usuario result = mockDao.Object.Login(clientUsername, clientPassword);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Cliente", result.ObtenerTipo());
        }

        [TestMethod]
        public void Login_WhenValidAdminUserAndPassword_ReturnsAdminUser()
        {
            // Arrange
            var mockDao = new Mock<UserDao>();
            string adminUsername = "validAdminUser";
            string adminPassword = "validAdminPassword";
            mockDao.Setup(dao => dao.Login(adminUsername, adminPassword))
                   .Returns(new Administrador(2, adminUsername, adminPassword, 2));

            // Act
            Usuario result = mockDao.Object.Login(adminUsername, adminPassword);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Administrador", result.ObtenerTipo());
        }

        [TestMethod]
        public void Login_WhenUserIsNull_ReturnsNull()
        {
            // Arrange
            string username = null;
            string password = "validPassword";
            var mockDao = new Mock<UserDao>();

            // Act
            Usuario result = mockDao.Object.Login(username, password);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Login_WhenPasswordIsNull_ReturnsNull()
        {
            // Arrange
            string username = "validUsername";
            string password = null;
            var mockDao = new Mock<UserDao>();

            // Act
            Usuario result = mockDao.Object.Login(username, password);

            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void ObtenerTodosLosUsuarios_ReturnsListOfUsers()
        {
            // Arrange
            var mockDao = new Mock<UserDao>();
            mockDao.Setup(dao => dao.ObtenerTodosLosUsuarios())
                   .Returns(new List<Usuario>
                   {
                       new Cliente(1, "user1", "pass1", 1),
                       new Administrador(2, "admin1", "adminpass1", 2)
                   });

            // Act
            List<Usuario> result = mockDao.Object.ObtenerTodosLosUsuarios();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void ObtenerAdministradores_ReturnsListOfAdmins()
        {
            // Arrange
            var mockDao = new Mock<UserDao>();
            mockDao.Setup(dao => dao.ObtenerAdministradores())
                   .Returns(new List<Usuario>
                   {
                       new Administrador(2, "admin1", "adminpass1", 2),
                       new Administrador(3, "admin2", "adminpass2", 2)
                   });

            // Act
            List<Usuario> result = mockDao.Object.ObtenerAdministradores();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            foreach (var usuario in result)
            {
                Assert.IsInstanceOfType(usuario, typeof(Administrador));
            }


        }
    }
}
