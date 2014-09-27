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
-- Table structure for table `actors`
--

DROP TABLE IF EXISTS `actors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `actors` (
  `idactors` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(20) NOT NULL,
  `surname` varchar(20) NOT NULL,
  `nationality` varchar(20) DEFAULT NULL,
  `birth_year` year(4) DEFAULT NULL,
  PRIMARY KEY (`idactors`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `actors`
--

LOCK TABLES `actors` WRITE;
/*!40000 ALTER TABLE `actors` DISABLE KEYS */;
INSERT INTO `actors` VALUES (1,'Tom','Hanks','American',1959),(2,'John','Travolta','American',1954),(3,'Brad','Pitt','American',1963),(4,'Edward','Norton','American',1969),(5,'Helena Bonham','Carter','English',1966),(6,'Cate','Blanchett','Australian',1969),(7,'Chiwetel','Ejiofor','English',1977),(8,'Halle','Berry','American',1966),(9,'Clive','Owen','English',1964),(10,'Josh','Holloway ','American',1969),(11,'Evangeline','Lilly ','Canadian',1979),(12,'Terry','O Quinn ','American',1952),(13,'Michael','Emerson ','American',1954),(14,'Matthew ','Fox ','American',1966),(15,'Anna','Torv ','Austrelian',1979),(16,'Joshua','Jackson  ','Canadian',1978),(17,'John','Noble ','Austrelian',1948),(18,'Lena','Headey ','AMerican',1973),(19,'Peter ','Dinklage  ','American',1969),(20,'Kit','Harington ','English',1986);
/*!40000 ALTER TABLE `actors` ENABLE KEYS */;
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
