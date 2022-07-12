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
INSERT INTO `tbl_data_menu` VALUES ('KP1','KERUPUK KALENG',1000),('KP2','KERUPUK BANGKA',5000),('KP3','EMPING MELINJO',3000),('MD1','PRIM-A',3000),('MD2','S-TEE',5000),('MD3','ES JERUK MANIS',7000),('MD4','ES JERUK TAWAR',5000),('MD5','ES JERUK NIPIS MANIS',7000),('MD6','ES JERUK NIPIS TAWAR',5000),('MD7','ES TEH MANIS',5000),('MD8','ES TEH TAWAR',3000),('MD9','ES BATU',1000),('MH1','JERUK HANGAT MANIS',7000),('MH2','JERUK HANGAT TAWAR',5000),('MH3','JERUK NIPIS HANGAT MANIS',7000),('MH4','JERUK NIPIS HANGAT TAWAR',5000),('MH5','TEH HANGAT MANIS',3000),('MH6','TEH HANGAT TAWAR',2000),('MH7','PUTIH HANGAT',1000),('ST1','SOTOMIE KIKIL',13000),('ST10','SOTO AYAM',13000),('ST11','RISOL',2000),('ST12','NASI',5000),('ST2','SOTOMIE DAGING + KIKIL',17000),('ST3','SOTOMIE DAGING',15000),('ST4','SOTO TANGKAR',19000),('ST5','SOTO IGA',19000),('ST6','SOTO BABAT',13000),('ST7','SOTO BABAT + KIKIL',15000),('ST8','SOTO BABAT + DAGING',17000),('ST9','SOTO SPESIAL',25000);
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
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COMMENT='data master';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_transaksi`
--

LOCK TABLES `tbl_transaksi` WRITE;
/*!40000 ALTER TABLE `tbl_transaksi` DISABLE KEYS */;
INSERT INTO `tbl_transaksi` VALUES (32,'TRX1226189858','12/07/2022 18:06:56','MH4','JERUK NIPIS HANGAT TAWAR',5,2,10000,1,'nam do san'),(33,'TRX1226189858','12/07/2022 18:06:56','MD6','ES JERUK NIPIS TAWAR',5,1,5000,1,'nam do san'),(34,'TRX1226189858','12/07/2022 18:06:56','ST8','SOTO BABAT + DAGING',17,1,17000,1,'nam do san'),(35,'TRX1226189858','12/07/2022 18:06:56','ST6','SOTO BABAT',13,1,13000,1,'nam do san'),(36,'TRX1226189858','12/07/2022 18:06:56','ST3','SOTOMIE DAGING',15,1,15000,1,'nam do san'),(37,'TRX1226189858','12/07/2022 18:06:56','ST12','NASI',5,3,15000,1,'nam do san'),(38,'TRX1226189858','12/07/2022 18:06:56','MD1','PRIM-A',3,1,3000,1,'nam do san');
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

-- Dump completed on 2022-07-12 18:18:41
