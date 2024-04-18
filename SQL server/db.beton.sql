/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50525
Source Host           : localhost:3306
Source Database       : db.beton

Target Server Type    : MYSQL
Target Server Version : 50525
File Encoding         : 65001

Date: 2024-04-12 00:56:41
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for application
-- ----------------------------
DROP TABLE IF EXISTS `application`;
CREATE TABLE `application` (
  `Application` int(11) NOT NULL,
  `Customer` varchar(255) DEFAULT NULL,
  `Manager` varchar(255) DEFAULT NULL,
  `Subdivision` varchar(255) DEFAULT NULL,
  `Auto` varchar(255) DEFAULT NULL,
  `DateTime` varchar(50) DEFAULT NULL,
  `PointOfDeparture` varchar(255) DEFAULT NULL,
  `Destination` varchar(255) DEFAULT NULL,
  `Distance` double(255,0) DEFAULT NULL,
  PRIMARY KEY (`Application`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of application
-- ----------------------------
INSERT INTO `application` VALUES ('1', 'ООО Автостройка', 'Петров Алексей Иванович', 'Цех 2', 'Volvo32', '08.04.2024 12:18:16', 'Ул. Пермякова 41', 'Ул. Новая 1', '200');
INSERT INTO `application` VALUES ('2', 'ООО Автостройка', 'Петров Алексей Иванович', 'Цех 2', 'Bmv92', '08.04.2024 12:18:16', 'Ул. Пермякова 41', 'Ул. Новая 1', '200');
INSERT INTO `application` VALUES ('3', 'ООО Автостройка', 'Волков Анатолий Евгеньевич', 'Цех 1', 'Volvo32', '08.04.2024 12:18:16', 'Ул. Пермякова 41', 'Ул. Новая 1', '250');
INSERT INTO `application` VALUES ('4', 'ООО Автостройка', 'Волков Анатолий Евгеньевич', 'Цех 1', 'Bmv92', '08.04.2024 12:18:16', 'Ул. Пермякова 41', 'Ул. Новая 2', '400');
INSERT INTO `application` VALUES ('5', 'ООО Автостройка', 'Старобубцев Евгений Николаевич', 'Цех 1', 'Bmv92', '08.04.2024 13:17:28', 'Ул. Пермякова 41', 'ул.Емельянова 28', '300');
INSERT INTO `application` VALUES ('6', 'ООО Автостройка', 'алексей', 'Цех 2', 'Volvo32', '09.04.2024 9:48:38', 'Ул. Пермякова 41', 'ул говна', '280');
INSERT INTO `application` VALUES ('7', 'ООО Автостройка', 'Волков Анатолий Евгеньевич', 'Цех 1', 'Volvo32', '09.04.2024 14:23:34', 'Ул. Пермякова 41', 'Ул. Мельникайте 92', '290');
INSERT INTO `application` VALUES ('8', 'ООО Покупка', 'Волков Анатолий Евгеньевич', 'Цех 2', 'Volvo32', '09.04.2024 14:25:48', 'Ул. Пермякова 41', 'Ул. Мельникайте 92', '340');

-- ----------------------------
-- Table structure for autopark
-- ----------------------------
DROP TABLE IF EXISTS `autopark`;
CREATE TABLE `autopark` (
  `ID` int(11) NOT NULL,
  `Name_Parking` varchar(255) DEFAULT NULL,
  `INN` varchar(255) DEFAULT NULL,
  `KPP` varchar(255) DEFAULT NULL,
  `Bank` varchar(255) DEFAULT NULL,
  `BIK` varchar(255) DEFAULT NULL,
  `KS` varchar(255) DEFAULT NULL,
  `RS` varchar(255) DEFAULT NULL,
  `Supervisor` varchar(255) DEFAULT NULL,
  `ChiefAccountant` varchar(255) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of autopark
-- ----------------------------
INSERT INTO `autopark` VALUES ('1', 'ООО Автопарк', '34324', '324324', 'Сбербанк', '454355', '435564', '455456', 'Даванков Алексей Михайлович', 'Калугина Анастасия Витальевна', 'Ул, Орджоникидзе 21');
INSERT INTO `autopark` VALUES ('2', 'ООО Славка', '34324', '324324', 'Сбербанк', '454355', '435564', '455456', 'Даванков Алексей Михайлович', 'Калугина Анастасия Витальевна', 'Ул, Орджоникидзе 21');
INSERT INTO `autopark` VALUES ('3', 'ООО Автопром', '34324', '324324', 'Сбербанк', '454355', '435564', '455456', 'Даванков Алексей Михайлович', 'Калугина Анастасия Витальевна', 'Ул, Орджоникидзе 21');
INSERT INTO `autopark` VALUES ('4', 'ООО Мишлен', '34324', '324234', 'Сбербанк', '234324', '234324234234', '234234234324', 'кто то там', ' кто то там', 'как то там');

-- ----------------------------
-- Table structure for autos
-- ----------------------------
DROP TABLE IF EXISTS `autos`;
CREATE TABLE `autos` (
  `ID` int(11) NOT NULL,
  `AutoParking` varchar(255) DEFAULT NULL,
  `Auto` varchar(255) DEFAULT NULL,
  `RegNumber` varchar(255) DEFAULT NULL,
  `ResponsiblePerson` varchar(255) DEFAULT NULL,
  `Mileage` varchar(255) DEFAULT NULL,
  `Note` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of autos
-- ----------------------------
INSERT INTO `autos` VALUES ('0', 'ООО Автопарк', 'Volvo32', '23456', 'Михайлов Алек Михайлович', '290', '25 Уcпешных поездок');
INSERT INTO `autos` VALUES ('1', 'ООО Мишлен', 'Bmv92', '23467', 'Багрудинов Аслан Тимуров', '100', '10 успешных поездок');

-- ----------------------------
-- Table structure for content
-- ----------------------------
DROP TABLE IF EXISTS `content`;
CREATE TABLE `content` (
  `ID` int(11) DEFAULT NULL,
  `Application` varchar(255) DEFAULT NULL,
  `Products` varchar(255) DEFAULT NULL,
  `Quantity` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of content
-- ----------------------------
INSERT INTO `content` VALUES ('6', '6', 'Цемент m95', '23');
INSERT INTO `content` VALUES ('6', '6', 'Цемент m95', '434');
INSERT INTO `content` VALUES ('6', '6', 'Цемент m45', '455');
INSERT INTO `content` VALUES ('7', '7', 'Цемент m95', '234');
INSERT INTO `content` VALUES ('7', '7', 'Цемент m45', '237');
INSERT INTO `content` VALUES ('7', '7', 'Цемент m50', '');
INSERT INTO `content` VALUES ('8', '8', 'Цемент m50', '543');
INSERT INTO `content` VALUES ('8', '8', 'Цемент m95', '456');
INSERT INTO `content` VALUES ('8', '8', 'Цемент m50', '');

-- ----------------------------
-- Table structure for customers
-- ----------------------------
DROP TABLE IF EXISTS `customers`;
CREATE TABLE `customers` (
  `ID` int(11) NOT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `INN` varchar(255) DEFAULT NULL,
  `KPP` varchar(255) DEFAULT NULL,
  `Bank` varchar(255) DEFAULT NULL,
  `BIK` varchar(255) DEFAULT NULL,
  `KS` varchar(255) DEFAULT NULL,
  `RS` varchar(255) DEFAULT NULL,
  `Supervisor` varchar(255) DEFAULT NULL,
  `ChiefAccountant` varchar(255) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of customers
-- ----------------------------
INSERT INTO `customers` VALUES ('1', 'ООО Автостройка', '234562', '432421', 'Сбербанк', '231345', '432345', '432313', 'Волков Сергей Иванович', 'Салянова Антонина Евегеньевна', 'Ул. Пермякова 31');
INSERT INTO `customers` VALUES ('2', 'ООО Покупка', '343476', '454767', 'Втб', '234213', '432345', '543456', 'Иванов Игорь Асланович', 'Буханова Екатерина Васильева', 'Ул. Мельникайте 92');
INSERT INTO `customers` VALUES ('3', '434', '', '', '', '', '', '', '', '', '');

-- ----------------------------
-- Table structure for edval
-- ----------------------------
DROP TABLE IF EXISTS `edval`;
CREATE TABLE `edval` (
  `ID` int(11) NOT NULL,
  `KOD` varchar(255) DEFAULT NULL,
  `EdVal` varchar(255) DEFAULT NULL,
  `FullName` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of edval
-- ----------------------------
INSERT INTO `edval` VALUES ('1', '123456', 'шт', 'Штука');
INSERT INTO `edval` VALUES ('2', '234567', 'кг', 'Килограмм');

-- ----------------------------
-- Table structure for manager
-- ----------------------------
DROP TABLE IF EXISTS `manager`;
CREATE TABLE `manager` (
  `ID` int(11) NOT NULL,
  `FIOManager` varchar(255) DEFAULT NULL,
  `Note` varchar(255) DEFAULT NULL,
  `Login` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of manager
-- ----------------------------
INSERT INTO `manager` VALUES ('0', 'Волков Анатолий Евгеньевич', 'Работник года', '1', '1');
INSERT INTO `manager` VALUES ('1', 'Петров Алексей Иванович', 'Стажер', '2', '2');
INSERT INTO `manager` VALUES ('2', 'Старобубцев Евгений Николаевич', 'Работник со стажем 3 года', '3', '3');
INSERT INTO `manager` VALUES ('4', 'авп вапавп вапвап', null, '4', '4');

-- ----------------------------
-- Table structure for products
-- ----------------------------
DROP TABLE IF EXISTS `products`;
CREATE TABLE `products` (
  `ID` int(11) NOT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `EdVal` varchar(2) DEFAULT NULL,
  `Pay` varchar(255) DEFAULT NULL,
  `NoteInfo` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of products
-- ----------------------------
INSERT INTO `products` VALUES ('1', 'Цемент m50', 'кг', '350', 'Средний класс');
INSERT INTO `products` VALUES ('2', 'Цемент m95', 'кг', '450', 'Высокий класс прочности');
INSERT INTO `products` VALUES ('3', 'Цемент m45', 'кг', '250', 'Низкий класс');

-- ----------------------------
-- Table structure for releasee
-- ----------------------------
DROP TABLE IF EXISTS `releasee`;
CREATE TABLE `releasee` (
  `ID` int(11) NOT NULL,
  `Subdivision` varchar(255) DEFAULT NULL,
  `Products` varchar(255) DEFAULT NULL,
  `DateRelase` varchar(255) DEFAULT NULL,
  `Quantity` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of releasee
-- ----------------------------
INSERT INTO `releasee` VALUES ('1', 'Цех 1', 'Цемент m50', '20.07.2009', '1600');
INSERT INTO `releasee` VALUES ('2', 'Цех 2', 'Цемент m95', '20.07.2009', '2000');
INSERT INTO `releasee` VALUES ('3', 'Цех 3', 'Цемент m45', '20.07.2009', '1000');

-- ----------------------------
-- Table structure for requisites
-- ----------------------------
DROP TABLE IF EXISTS `requisites`;
CREATE TABLE `requisites` (
  `ID` int(11) NOT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `INN` varchar(255) DEFAULT NULL,
  `KPP` varchar(255) DEFAULT NULL,
  `Bank` varchar(255) DEFAULT NULL,
  `BIK` varchar(255) DEFAULT NULL,
  `K/S` varchar(255) DEFAULT NULL,
  `R/S` varchar(255) DEFAULT NULL,
  `Adress` varchar(255) DEFAULT NULL,
  `Supervisor` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of requisites
-- ----------------------------
INSERT INTO `requisites` VALUES ('0', 'ООО Бетон', '234567', '2345678', 'Сбербанк', '345353', '353455', '343435', 'Ул. Пермякова 41', 'Суровикин Евгений Васильевич');

-- ----------------------------
-- Table structure for subdivision
-- ----------------------------
DROP TABLE IF EXISTS `subdivision`;
CREATE TABLE `subdivision` (
  `ID` int(11) NOT NULL,
  `Subdivision` varchar(255) DEFAULT NULL,
  `NoteInfo` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of subdivision
-- ----------------------------
INSERT INTO `subdivision` VALUES ('1', 'Цех 1', 'Основное Производство');
INSERT INTO `subdivision` VALUES ('2', 'Цех 2', 'Вспомогательное Производство');
INSERT INTO `subdivision` VALUES ('3', 'Цех 3', 'Экстренное Производство');

-- ----------------------------
-- Table structure for test
-- ----------------------------
DROP TABLE IF EXISTS `test`;
CREATE TABLE `test` (
  `Login` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of test
-- ----------------------------
INSERT INTO `test` VALUES ('1', '2');
INSERT INTO `test` VALUES ('23', '434');
INSERT INTO `test` VALUES ('1', '2');
INSERT INTO `test` VALUES ('1', '2');
INSERT INTO `test` VALUES ('1', '2');
INSERT INTO `test` VALUES ('1', '2');
INSERT INTO `test` VALUES ('1', '2');
INSERT INTO `test` VALUES ('1', '2');
SET FOREIGN_KEY_CHECKS=1;
