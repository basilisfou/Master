CREATE DATABASE  IF NOT EXISTS `vaseis_dedomenwn` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `vaseis_dedomenwn`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: localhost    Database: vaseis_dedomenwn
-- ------------------------------------------------------
-- Server version	5.6.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `series_rating`
--

DROP TABLE IF EXISTS `series_rating`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `series_rating` (
  `e-mail` varchar(45) DEFAULT NULL,
  `series_id` int(11) DEFAULT NULL,
  `rating` double DEFAULT NULL,
  KEY `e-mail_ser_idx` (`e-mail`),
  KEY `series_id_idx` (`series_id`),
  CONSTRAINT `e-mail_ser` FOREIGN KEY (`e-mail`) REFERENCES `users` (`email`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `series_id` FOREIGN KEY (`series_id`) REFERENCES `series` (`idseries`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `series_rating`
--

LOCK TABLES `series_rating` WRITE;
/*!40000 ALTER TABLE `series_rating` DISABLE KEYS */;
INSERT INTO `series_rating` VALUES ('basilisfou@gmail.com',1,8.6),('panageo@gmail.com',1,7.5),('basilisfou@gmail.com',2,9),('panageo@gmail.com',2,9.5),('basilisfou@gmail.com',3,8.9),('panageo@gmail.com',3,8.8),('basilisfou@gmail.com',4,9.5),('panageo@gmail.com',4,9.6);
/*!40000 ALTER TABLE `series_rating` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-09-22 14:22:54
