-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 11, 2024 at 04:34 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `veterinarydb`
--

-- --------------------------------------------------------

--
-- Table structure for table `pet`
--

CREATE TABLE `pet` (
  `Pet_Id` int(11) NOT NULL,
  `Pet_Name` varchar(50) NOT NULL,
  `Pet_Type` varchar(50) NOT NULL,
  `Pet_Colour` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pet`
--

INSERT INTO `pet` (`Pet_Id`, `Pet_Name`, `Pet_Type`, `Pet_Colour`) VALUES
(2, 'Coda', 'Cat', 'Multicolor'),
(3, 'Merlin', 'Parrot', 'Green-Yellow'),
(4, 'Nina', 'Turtle', 'Dark Gray'),
(5, 'Domino', 'Rabbit', 'White'),
(6, 'Luna', 'Hamster', 'Orange'),
(7, 'Lucy', 'Monkey', 'Brown'),
(8, 'Daysi', 'Horse', 'White'),
(9, 'Zoe', 'Snake', 'Yellow white'),
(10, 'Max', 'Budgie', 'Yellow'),
(11, 'Charlie', 'Mouse', 'White'),
(12, 'Rocky', 'Squirrel', 'Brown-Orange'),
(13, 'Leo', 'Dog', 'White-Black'),
(14, 'Loki', 'Cat', 'Black'),
(15, 'Jasper', 'Dog', 'Silver'),
(16, 'Buttons', 'Dog', 'White'),
(17, 'Coda', 'Cat', 'Multicolor'),
(18, 'Merlin', 'Parrot', 'Green-Yellow'),
(19, 'Nina', 'Turtle', 'Dark Gray'),
(20, 'Domino', 'Rabbit', 'White'),
(21, 'Luna', 'Hamster', 'Orange'),
(22, 'Lucy', 'Monkey', 'Brown'),
(23, 'Daysi', 'Horse', 'White'),
(24, 'Zoe', 'Snake', 'Yellow white'),
(25, 'Max', 'Budgie', 'Yellow'),
(26, 'Charlie', 'Mouse', 'Red'),
(28, 'Leo', 'Dog', 'White'),
(29, 'Loki', 'Cat', 'Black'),
(31, 'John', 'Dog', 'Gray'),
(33, 'Hike', 'Snake', 'silver');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pet`
--
ALTER TABLE `pet`
  ADD PRIMARY KEY (`Pet_Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pet`
--
ALTER TABLE `pet`
  MODIFY `Pet_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
