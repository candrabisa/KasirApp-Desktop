-- MySQL dump 10.13  Distrib 5.7.24, for Win64 (x86_64)
--
-- Host: localhost    Database: db_sotobabaelon
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.21-MariaDB

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
-- Table structure for table `tbl_data_menu`
--

DROP TABLE IF EXISTS `tbl_data_menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_data_menu` (
  `kode_menu` varchar(100) NOT NULL,
  `nama_menu` varchar(100) DEFAULT NULL,
  `harga` double DEFAULT NULL,
  PRIMARY KEY (`kode_menu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='data menu';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_data_menu`
--

LOCK TABLES `tbl_data_menu` WRITE;
/*!40000 ALTER TABLE `tbl_data_menu` DISABLE KEYS */;
INSERT INTO `tbl_data_menu` VALUES ('baba001','soto babat',12000),('baba002','soto madara',13000),('baba003','AQUA',4000),('baba004','Es Teh',4000);
/*!40000 ALTER TABLE `tbl_data_menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_data_pegawai`
--

DROP TABLE IF EXISTS `tbl_data_pegawai`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_data_pegawai` (
  `nip` int(11) NOT NULL,
  `nama_pegawai` varchar(100) NOT NULL,
  `tgl_lahir` varchar(100) DEFAULT NULL,
  `jenis_kelamin` varchar(100) DEFAULT NULL,
  `alamat` varchar(100) DEFAULT NULL,
  `status` varchar(100) DEFAULT NULL,
  `no_hp` varchar(100) DEFAULT NULL,
  `tgl_join` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`nip`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='data pegawai';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_data_pegawai`
--

LOCK TABLES `tbl_data_pegawai` WRITE;
/*!40000 ALTER TABLE `tbl_data_pegawai` DISABLE KEYS */;
INSERT INTO `tbl_data_pegawai` VALUES (1,'nam do san','17 February 1994','Laki-laki','kebumen','Tetap','08123456789','19 October 2020'),(2,'seo dal mi','08 September 1995','Perempuan','cikarang','Kontrak','08927499999','19 March 2021'),(3,'park saero yi','17 May 1999','Laki-laki','jakarta','Kontrak','09887867888','19 May 2021'),(4,'son o kong','13 April 1999','Laki-laki','korea utara','Kontrak','08123456787','02 February 2022'),(5,'kim jong unch','12 October 1959','Laki-laki','korea tenggara','Tetap','09120921212','29 June 2022');
/*!40000 ALTER TABLE `tbl_data_pegawai` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_transaksi`
--

DROP TABLE IF EXISTS `tbl_transaksi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_transaksi` (
  `data_entry` int(11) NOT NULL AUTO_INCREMENT,
  `id_transaksi` varchar(100) NOT NULL,
  `tgl_transaksi` varchar(100) DEFAULT NULL,
  `kode_menu` varchar(100) DEFAULT NULL,
  `nama_menu` varchar(100) DEFAULT NULL,
  `harga` double DEFAULT NULL,
  `jumlah` int(12) DEFAULT NULL,
  `total_harga` double DEFAULT NULL,
  `nip` int(11) DEFAULT NULL,
  `nama_pegawai` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`data_entry`),
  KEY `tbl_data_master_FK` (`kode_menu`),
  KEY `tbl_transaksi_FK` (`nip`),
  CONSTRAINT `tbl_data_master_FK` FOREIGN KEY (`kode_menu`) REFERENCES `tbl_data_menu` (`kode_menu`),
  CONSTRAINT `tbl_transaksi_FK` FOREIGN KEY (`nip`) REFERENCES `tbl_data_pegawai` (`nip`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COMMENT='data master';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_transaksi`
--

LOCK TABLES `tbl_transaksi` WRITE;
/*!40000 ALTER TABLE `tbl_transaksi` DISABLE KEYS */;
INSERT INTO `tbl_transaksi` VALUES (1,'TRX12121212','01/07/2022 14:22:54','baba001','soto babat',12000,2,24000,1,'nam'),(2,'TRX32928173','02/07/2022 14:43:20','baba002','soto madara',13000,1,13000,1,'nam'),(3,'TRX1622508045','04/07/2022 15:33:54','baba001','soto babat',12000,3,36000,1,'nam do san'),(4,'TRX259864686','04/07/2022 19:01:16','baba001','soto babat',12000,2,24000,1,'nam do san'),(5,'TRX259864686','04/07/2022 19:01:16','baba002','soto madara',13000,3,39000,1,'nam do san'),(6,'TRX1345645977','04/07/2022 19:03:21','baba001','soto babat',12,2,24000,1,'nam do san'),(7,'TRX1345645977','04/07/2022 19:03:21','baba002','soto madara',13,3,39000,1,'nam do san'),(8,'TRX1918407972','04/07/2022 19:05:17','baba001','soto babat',12000,3,36000,1,'nam do san'),(9,'TRX1918407972','04/07/2022 19:05:17','baba002','soto madara',13000,2,26000,1,'nam do san'),(10,'TRX383767585','05/07/2022 22:24:29','baba002','soto madara',13000,2,26000,1,'nam do san'),(11,'TRX383767585','06/07/2022 22:24:29','baba001','soto babat',12000,3,36000,1,'nam do san'),(12,'TRX1180172781','06/07/2022 16:21:38','baba002','soto madara',13,1,13000,2,'seo dal mi'),(13,'TRX1180172781','06/07/2022 16:21:38','baba001','soto babat',12,3,36000,2,'seo dal mi'),(14,'TRX1703970446','06/07/2022 16:40:18','baba001','soto babat',12000,3,36000,1,'nam do san'),(15,'TRX1703970446','06/07/2022 16:40:18','baba002','soto madara',13000,2,26000,1,'nam do san'),(16,'TRX390602427','06/07/2022 16:45:33','baba001','soto babat',12000,3,36000,2,'seo dal mi'),(17,'TRX700282415','12/07/2022 12:45:55','baba002','soto madara',13,1,13000,1,'nam do san'),(18,'TRX700282415','12/07/2022 12:45:55','baba001','soto babat',12,2,24000,1,'nam do san'),(19,'TRX1723047098','12/07/2022 12:46:51','baba001','soto babat',12000,2,24000,1,'nam do san'),(20,'TRX1723047098','12/07/2022 12:46:51','baba002','soto madara',13000,3,39000,1,'nam do san'),(21,'TRX187172558','12/07/2022 12:48:19','baba001','soto babat',12000,2,24000,1,'nam do san'),(22,'TRX2073873664','12/07/2022 12:49:08','baba001','soto babat',12000,2,24000,1,'nam do san'),(23,'TRX2073873664','12/07/2022 12:49:08','baba002','soto madara',13000,3,39000,1,'nam do san'),(24,'TRX10343198','12/07/2022 12:50:13','baba002','soto madara',13000,3,39000,1,'nam do san'),(25,'TRX10343198','12/07/2022 12:50:13','baba001','soto babat',12000,1,12000,1,'nam do san'),(26,'TRX385132371','12/07/2022 12:52:47','baba001','soto babat',12,2,24000,1,'nam do san'),(27,'TRX385132371','12/07/2022 12:52:47','baba003','AQUA',4,2,8000,1,'nam do san'),(28,'TRX385132371','12/07/2022 12:52:47','baba004','Es Teh',4,2,8000,1,'nam do san'),(29,'TRX1853209756','12/07/2022 12:56:26','baba002','soto madara',13,3,39000,1,'nam do san'),(30,'TRX1853209756','12/07/2022 12:56:26','baba003','AQUA',4,1,4000,1,'nam do san'),(31,'TRX1853209756','12/07/2022 12:56:26','baba004','Es Teh',4,2,8000,1,'nam do san');
/*!40000 ALTER TABLE `tbl_transaksi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_user`
--

DROP TABLE IF EXISTS `tbl_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_user` (
  `nip` int(11) NOT NULL,
  `nama_pegawai` varchar(100) NOT NULL,
  `username` varchar(100) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `roles` varchar(100) DEFAULT NULL,
  KEY `tbl_user_FK` (`nip`),
  CONSTRAINT `tbl_user_FK` FOREIGN KEY (`nip`) REFERENCES `tbl_data_pegawai` (`nip`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='user';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_user`
--

LOCK TABLES `tbl_user` WRITE;
/*!40000 ALTER TABLE `tbl_user` DISABLE KEYS */;
INSERT INTO `tbl_user` VALUES (1,'nam do san','nam','zbzO/5npcmtuEZJ0cShwfQ==','ADMIN'),(2,'seo dal mi','seo','zbzO/5npcmtuEZJ0cShwfQ==','KASIR'),(3,'park saero yi','park','Is+4xblzUu0rY+3Rph2mkA==','ADMIN');
/*!40000 ALTER TABLE `tbl_user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'db_sotobabaelon'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-07-12 13:32:27
