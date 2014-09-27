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
-- Table structure for table `directors_rating`
--

DROP TABLE IF EXISTS `directors_rating`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `directors_rating` (
  `email` varchar(20) NOT NULL,
  `directors_id` int(11) NOT NULL,
  `rating` double DEFAULT NULL,
  KEY `email_dirRat_idx` (`email`),
  KEY `directors_id_dirRat_idx` (`directors_id`),
  CONSTRAINT `directors_id_dirRat` FOREIGN KEY (`directors_id`) REFERENCES `directors` (`director_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `email_dirRat` FOREIGN KEY (`email`) REFERENCES `users` (`email`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directors_rating`
--

LOCK TABLES `directors_rating` WRITE;
/*!40000 ALTER TABLE `directors_rating` DISABLE KEYS */;
INSERT INTO `directors_rating` VALUES ('basilisfou@gmail.com',1,8),('basilisfou@gmail.com',2,9),('panageo@gmail.com',1,7),('panageo@gmail.com',2,8),('basilisfou@gmail.com',3,8),('basilisfou@gmail.com',4,9),('basilisfou@gmail.com',5,7),('panageo@gmail.com',5,7),('basilisfou@gmail.com',6,6),('panageo@gmail.com',6,8),('basilisfou@gmail.com',7,8),('panageo@gmail.com',7,7);
/*!40000 ALTER TABLE `directors_rating` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-09-22 14:22:53
