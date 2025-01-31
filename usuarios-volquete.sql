CREATE DATABASE IF NOT EXISTS `usuarios-volquete`;
USE `usuarios-volquete`;
-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 22-02-2024 a las 07:49:06
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `usuarios-volquete`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alquiler`
--

CREATE TABLE `alquiler` (
  `Id` int(11) NOT NULL,
  `Id_Usuario` int(11) DEFAULT NULL,
  `FechaEscogida` datetime DEFAULT NULL,
  `Medio De Pago` varchar(255) NOT NULL,
  `Estado` varchar(255) NOT NULL,
  `UbicacionDeEntrega` varchar(255) DEFAULT NULL,
  `Nombre` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `NumeroDeTelefono` varchar(20) DEFAULT NULL,
  `Plazo` varchar(255) NOT NULL,
  `Precio` decimal(18,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `alquiler`
--

INSERT INTO `alquiler` (`Id`, `Id_Usuario`, `FechaEscogida`, `Medio De Pago`, `Estado`, `UbicacionDeEntrega`, `Nombre`, `Email`, `NumeroDeTelefono`, `Plazo`, `Precio`) VALUES
(1, 1, '2023-11-30 00:00:00', 'Transferencia', 'Pendiente', 'Diario la Nacion', 'Matias Pacheco', 'seulkyon@gmail.com', '+54 11 6473-8537', '72hs', 288.00),
(2, 7, '2023-12-01 08:00:00', 'TarjetaDeCredito', 'Pendiente', 'Dirección 123', 'Alquiler 1', 'usuario1@example.com', '123-456-7890', '72hs', 150.00),
(3, 1, '2023-12-15 13:42:26', '0', '0', 'dasdasd', 'Matias', 'dasdasd', 'dsad', '72hs', 2400.00),
(7, 7, '2023-12-01 08:00:00', 'TarjetaDeCredito', 'Pendiente', 'Dirección 123', 'Alquiler 1', 'usuario1@example.com', '123-456-7890', '72hs', 150.00),
(9, NULL, '2023-12-05 00:00:00', 'TarjetaDeCredito', 'Pendiente', 'Calle 123', 'Alquiler 5', 'usuario5@example.com', '+33 1 23 45 67 89', '72hs', 250.75),
(10, NULL, '2023-12-15 14:45:57', '1', '0', 'dasdkask', 'Matias', 'sakdasdk', '24242', '72hs', 2400.00),
(11, 1, '2024-02-21 23:47:27', '0', '0', 'dsad', 'dsad', 'dsad', 'sadasd', '48hs', 1600.00);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mensajes`
--

CREATE TABLE `mensajes` (
  `ID` int(11) NOT NULL,
  `ID_usuario` int(11) NOT NULL,
  `Remitente` varchar(255) NOT NULL,
  `Mensaje` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `mensajes`
--

INSERT INTO `mensajes` (`ID`, `ID_usuario`, `Remitente`, `Mensaje`) VALUES
(1, 2, 'Pablo', 'Hola'),
(2, 2, 'Carlos', 'Chau'),
(3, 2, 'User', 'Buenas tardes me gustaria modificar la fecha de mi reserva'),
(4, 3, 'User', 'Me gustaria modificar la ubicacion de entrega'),
(5, 2, 'User', 'Quiero modificar el volquete');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `ID` int(11) NOT NULL,
  `Nombre` varchar(255) DEFAULT NULL,
  `Contraseña` varchar(255) DEFAULT NULL,
  `TipoUsuario` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`ID`, `Nombre`, `Contraseña`, `TipoUsuario`) VALUES
(0, 'Prueba', 'Prueba', 1),
(1, 'User', 'Pass', 1),
(2, 'admin', 'pass', 2),
(3, 'Manager', 'Manager', 2),
(4, 'Alo', 'Chau', 2),
(5, 'sasa', 'sasa', 1),
(6, 'soso', 'soso', 1),
(7, 'Prueba3', 'Prueba', 1),
(8, 'Prueba4', 'Prueba', 1),
(9, 'prueba6', 'prueba', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `volquetes`
--

CREATE TABLE `volquetes` (
  `ID` int(11) NOT NULL,
  `id_alquiler` int(11) DEFAULT NULL,
  `Tamaño` double NOT NULL,
  `Tipo` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `volquetes`
--

INSERT INTO `volquetes` (`ID`, `id_alquiler`, `Tamaño`, `Tipo`) VALUES
(1, 1, 1.75, 'Pequeño'),
(2, NULL, 1.75, 'Pequeño'),
(3, NULL, 1.75, 'Pequeño'),
(4, NULL, 1.75, 'Pequeño'),
(5, NULL, 1.75, 'Pequeño'),
(6, NULL, 1.75, 'Pequeño'),
(7, NULL, 1.75, 'Pequeño'),
(8, NULL, 1.75, 'Pequeño'),
(9, NULL, 1.75, 'Pequeño'),
(10, NULL, 1.75, 'Pequeño'),
(11, 1, 2.5, 'Mediano'),
(12, 3, 2.5, 'Mediano'),
(13, 10, 2.5, 'Mediano'),
(14, 11, 2.5, 'Mediano'),
(15, NULL, 2.5, 'Mediano'),
(16, NULL, 2.5, 'Mediano'),
(17, NULL, 2.5, 'Mediano'),
(31, 11, 5, 'Grande');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `alquiler`
--
ALTER TABLE `alquiler`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `fk_alquiler_usuario` (`Id_Usuario`);

--
-- Indices de la tabla `mensajes`
--
ALTER TABLE `mensajes`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_usuario` (`ID_usuario`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `volquetes`
--
ALTER TABLE `volquetes`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_volquetes_alquiler` (`id_alquiler`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `alquiler`
--
ALTER TABLE `alquiler`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `mensajes`
--
ALTER TABLE `mensajes`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `volquetes`
--
ALTER TABLE `volquetes`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `alquiler`
--
ALTER TABLE `alquiler`
  ADD CONSTRAINT `fk_alquiler_usuario` FOREIGN KEY (`Id_Usuario`) REFERENCES `usuarios` (`ID`) ON DELETE SET NULL;

--
-- Filtros para la tabla `mensajes`
--
ALTER TABLE `mensajes`
  ADD CONSTRAINT `fk_usuario` FOREIGN KEY (`ID_usuario`) REFERENCES `usuarios` (`ID`);

--
-- Filtros para la tabla `volquetes`
--
ALTER TABLE `volquetes`
  ADD CONSTRAINT `fk_volquetes_alquiler` FOREIGN KEY (`id_alquiler`) REFERENCES `alquiler` (`Id`) ON DELETE SET NULL;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
