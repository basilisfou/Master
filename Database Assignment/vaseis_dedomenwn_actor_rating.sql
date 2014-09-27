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
-- Table structure for table `actor_rating`
--

DROP TABLE IF EXISTS `actor_rating`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `actor_rating` (
  `e-mail` varchar(20) DEFAULT NULL,
  `actor_id` int(11) DEFAULT NULL,
  `rating` double DEFAULT NULL,
  KEY `e-mail_act_idx` (`e-mail`),
  KEY `actor_code_idx` (`actor_id`),
  CONSTRAINT `e-mail_act` FOREIGN KEY (`e-mail`) REFERENCES `users` (`email`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `actor_id` FOREIGN KEY (`actor_id`) REFERENCES `actors` (`idactors`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `actor_rating`
--

LOCK TABLES `actor_rating` WRITE;
/*!40000 ALTER TABLE `actor_rating` DISABLE KEYS */;
INSERT INTO `actor_rating` VALUES ('basilisfou@gmail.com',1,9),('basilisfou@gmail.com',2,7),('panageo@gmail.com',1,8),('panageo@gmail.com',2,6),('basilisfou@gmail.com',3,8),('basilisfou@gmail.com',4,9),('basilisfou@gmail.com',5,6.5),('basilisfou@gmail.com',7,7.1),('basilisfou@gmail.com',6,7.5),('basilisfou@gmail.com',8,6),('panageo@gmail.com',8,5),('basilisfou@gmail.com',9,8),('panageo@gmail.com',9,7),('basilisfou@gmail.com',10,5.6),('panageo@gmail.com',11,6),('basilisfou@gmail.com',12,5.9),('panageo@gmail.com',13,6.7),('basilisfou@gmail.com',14,6.4),('panageo@gmail.com',14,6.1),('basilisfou@gmail.com',15,6.5),('panageo@gmail.com',16,6.8),('basilisfou@gmail.com',17,7.6),('panageo@gmail.com',17,7.4),('basilisfou@gmail.com',18,7),('panageo@gmail.com',18,6.8),('basilisfou@gmail.com',19,9),('panageo@gmail.com',19,9.2),('basilisfou@gmail.com',20,6.9),('panageo@gmail.com',20,7.1);
/*!40000 ALTER TABLE `actor_rating` ENABLE KEYS */;
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
