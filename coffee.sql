-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Apr 18, 2020 at 12:08 PM
-- Server version: 8.0.17
-- PHP Version: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `coffee`
--

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `CustomerID` int(11) NOT NULL,
  `CustomerName` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Gender` enum('M','F') CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `CustomerType` enum('Member','VIP','Other') CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `CustomerTelNo` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `ProductID` int(11) NOT NULL,
  `ProductName` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Price` float NOT NULL,
  `ProductDetail` text CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`ProductID`, `ProductName`, `Price`, `ProductDetail`) VALUES
(1, 'Espresso', 50, 'ประกอบไปด้วย กาแฟล้วน ที่ไม่มีส่วนผสมของนมใดๆ ทั้งสิ้น ถูกชงโดยใช้แรงอัดไอน้ำหรือน้ำร้อนผ่านเมล็ดกาแฟคั่วที่บดละเอียด'),
(2, 'Caffe latte', 45, 'ประกอบไปด้วย เอสเปรสโซ 1 ส่วน และนมร้อน 2-3 ส่วน อาจจะมีฟองนมด้านบนด้วยก็ได้'),
(3, 'Cappuccino', 65, 'ประกอบด้วย เอสเปรสโซ 1/3 ส่วน ผสมกับนมร้อนผ่านไอน้ำหรือนมสตรีม 1/3 ส่วน และนมตีโฟม 1/3 ส่วน ลอยอยู่ด้านบน ในสัดส่วนเท่าๆกัน'),
(4, 'Americano', 55, 'ประกอบด้วย เอสเปรสโซ 1 ส่วน และน้ำร้อน 1 ส่วน'),
(5, ' Caffè Mocha', 100, 'ประกอบไปด้วย เอสเพรสโซ่ 1/3 ส่วน นมร้อน 2/3 ส่วน และช็อคโกแลต เพิ่มกิมมิคด้วยวิปปิ้งครีมด้านบน');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `SaleID` int(11) NOT NULL,
  `SaleDateTime` datetime NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `StaffID` int(11) NOT NULL,
  `GrandTotal` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `sale_details`
--

CREATE TABLE `sale_details` (
  `SaleDetailID` int(11) NOT NULL,
  `SaleID` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `Price` float NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Amount` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `staffs`
--

CREATE TABLE `staffs` (
  `StaffID` int(11) NOT NULL,
  `StaffCode` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `StaffName` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Gender` enum('M','F') CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `StaffPassword` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `StaffLevel` enum('Staff','Manager','Admin') CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `staffs`
--

INSERT INTO `staffs` (`StaffID`, `StaffCode`, `StaffName`, `Gender`, `StaffPassword`, `StaffLevel`) VALUES
(147001, 'AF001', 'Topkung', 'M', 'a0123456789', 'Admin'),
(147002, 'AF002', 'Bacon', 'M', '1120', 'Manager'),
(147003, 'AF003', 'Coath', 'M', '123456789', 'Staff');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ProductID`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`SaleID`);

--
-- Indexes for table `sale_details`
--
ALTER TABLE `sale_details`
  ADD PRIMARY KEY (`SaleDetailID`);

--
-- Indexes for table `staffs`
--
ALTER TABLE `staffs`
  ADD PRIMARY KEY (`StaffID`),
  ADD UNIQUE KEY `StaffCode` (`StaffCode`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `CustomerID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `SaleID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `sale_details`
--
ALTER TABLE `sale_details`
  MODIFY `SaleDetailID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `staffs`
--
ALTER TABLE `staffs`
  MODIFY `StaffID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=147004;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
