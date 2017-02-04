/*
SQLyog Community v11.26 (64 bit)
MySQL - 5.7.15-log : Database - ores
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`ores` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `ores`;

/*Table structure for table `completed_projects` */

DROP TABLE IF EXISTS `completed_projects`;

CREATE TABLE `completed_projects` (
  `Owner_ID` varchar(100) NOT NULL,
  `Project_Name` varchar(200) NOT NULL,
  `Location` varchar(100) DEFAULT NULL,
  `Project_Type` varchar(50) NOT NULL,
  `No_Of_Units` int(50) DEFAULT NULL,
  PRIMARY KEY (`Owner_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `completed_projects` */

/*Table structure for table `developer_registraion` */

DROP TABLE IF EXISTS `developer_registraion`;

CREATE TABLE `developer_registraion` (
  `Owner_ID` varchar(100) NOT NULL,
  `Owner_Name` varchar(200) NOT NULL,
  `Website` varchar(100) DEFAULT NULL,
  `Address` varchar(200) DEFAULT NULL,
  `Contact_No` int(10) NOT NULL,
  `Builder_Name` varchar(100) DEFAULT NULL,
  `Developer_Email` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Owner_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `developer_registraion` */

insert  into `developer_registraion`(`Owner_ID`,`Owner_Name`,`Website`,`Address`,`Contact_No`,`Builder_Name`,`Developer_Email`) values ('735879838','asda','asd','Gcn Sai avenue,proertyno 69/2,flatno g04,kundanhalli',2,'sa','85rahulmishra@gmail.com'),('877304108','ddsdds','ddsd','Gcn Sai avenue,proertyno 69/2,flatno g04,kundanhalli',1,'ssdsd','dwi.tripathy@gmail.com');

/*Table structure for table `login` */

DROP TABLE IF EXISTS `login`;

CREATE TABLE `login` (
  `uid` varchar(100) DEFAULT NULL,
  `username` varchar(100) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `usertype` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `login` */

insert  into `login`(`uid`,`username`,`password`,`usertype`) values ('356571700','d.tripathy007@gmail.com','sss','M'),('1533683756','ffddfdd@fff.com','aaa','M'),('877304108','dwi.tripathy@gmail.com','aaaa','D'),('735879838','85rahulmishra@gmail.com','aaa','D');

/*Table structure for table `membership` */

DROP TABLE IF EXISTS `membership`;

CREATE TABLE `membership` (
  `Membership_ID` varchar(100) NOT NULL,
  `Enrollment_Type` varchar(100) NOT NULL,
  `Organisation_Name` varchar(100) NOT NULL,
  `Pan_No` varchar(15) NOT NULL,
  `Chairman_MD` varchar(100) DEFAULT NULL,
  `Mailing_Address` varchar(500) NOT NULL,
  `Company_Telephone_No` int(12) NOT NULL,
  `Fax` int(15) NOT NULL,
  `Mobile_No` int(12) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Website` varchar(100) DEFAULT NULL,
  `Repre_Name` varchar(100) NOT NULL,
  `Repre_Desig` varchar(50) NOT NULL,
  `Repre_Mobile` int(12) NOT NULL,
  `Repre_Email` varchar(100) NOT NULL,
  PRIMARY KEY (`Membership_ID`,`Pan_No`),
  UNIQUE KEY `Mobile_No` (`Mobile_No`),
  UNIQUE KEY `Repre_Mobile` (`Repre_Mobile`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `membership` */

insert  into `membership`(`Membership_ID`,`Enrollment_Type`,`Organisation_Name`,`Pan_No`,`Chairman_MD`,`Mailing_Address`,`Company_Telephone_No`,`Fax`,`Mobile_No`,`Email`,`Website`,`Repre_Name`,`Repre_Desig`,`Repre_Mobile`,`Repre_Email`) values ('1533683756','Patron Members','dddd','ssas','ddff','sadada',4444,3333,2222,'ffddfdd@fff.com','ddsd','sadad','asdada',1111,'sdfsdf@h.co'),('356571700','Founder Members','asdasd','asdad','asdas','dasd',123,321313,321231,'d.tripathy007@gmail.com','asda','asda','sdasd',321313,'sdfsdf@h.co');

/*Table structure for table `membership_enrollment` */

DROP TABLE IF EXISTS `membership_enrollment`;

CREATE TABLE `membership_enrollment` (
  `Enrollment_Type` varchar(10) NOT NULL,
  `Intial_Contribution` int(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `membership_enrollment` */

/*Table structure for table `ongoing_projects` */

DROP TABLE IF EXISTS `ongoing_projects`;

CREATE TABLE `ongoing_projects` (
  `Owner_ID` varchar(100) NOT NULL,
  `Project_Name` varchar(200) NOT NULL,
  `Location` varchar(100) DEFAULT NULL,
  `Project_Type` varchar(50) NOT NULL,
  `No_Of_Units` int(50) DEFAULT NULL,
  `Project_Photo` blob,
  PRIMARY KEY (`Owner_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `ongoing_projects` */

/*Table structure for table `photo_info` */

DROP TABLE IF EXISTS `photo_info`;

CREATE TABLE `photo_info` (
  `Owner_ID` varchar(100) NOT NULL,
  `Project_Type` varchar(30) NOT NULL,
  `Project_Photo` varchar(500) NOT NULL,
  PRIMARY KEY (`Owner_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `photo_info` */

/*Table structure for table `signup` */

DROP TABLE IF EXISTS `signup`;

CREATE TABLE `signup` (
  `uid` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(100) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `usertype` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `signup` */

/*Table structure for table `upcoming_projects` */

DROP TABLE IF EXISTS `upcoming_projects`;

CREATE TABLE `upcoming_projects` (
  `Owner_ID` varchar(100) NOT NULL,
  `Project_Name` varchar(200) NOT NULL,
  `Location` varchar(100) DEFAULT NULL,
  `Project_Type` varchar(50) NOT NULL,
  `No_Of_Units` int(50) DEFAULT NULL,
  `Project_Photo` blob,
  PRIMARY KEY (`Owner_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `upcoming_projects` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
