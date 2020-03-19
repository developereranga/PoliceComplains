-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Mar 19, 2020 at 05:53 PM
-- Server version: 5.7.29-0ubuntu0.16.04.1
-- PHP Version: 7.0.33-0ubuntu0.16.04.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `police_complain`
--

-- --------------------------------------------------------

--
-- Table structure for table `complains`
--

CREATE TABLE `complains` (
  `id` int(11) NOT NULL,
  `title` varchar(255) NOT NULL,
  `description` text NOT NULL,
  `user_id` int(11) NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `complains`
--

INSERT INTO `complains` (`id`, `title`, `description`, `user_id`, `status`) VALUES
(9, 'test', 'test desc', 1, 'Case closed');

-- --------------------------------------------------------

--
-- Table structure for table `complain_docs`
--

CREATE TABLE `complain_docs` (
  `id` int(11) NOT NULL,
  `complain_id` int(11) NOT NULL,
  `file_name` varchar(255) NOT NULL,
  `real_name` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `complain_docs`
--

INSERT INTO `complain_docs` (`id`, `complain_id`, `file_name`, `real_name`) VALUES
(3, 9, '72a314c7420749aead539ea6475ae195.jpeg', 'transcript.jpeg');

-- --------------------------------------------------------

--
-- Table structure for table `complain_feedback`
--

CREATE TABLE `complain_feedback` (
  `id` int(11) NOT NULL,
  `complain_id` int(11) NOT NULL,
  `message` text NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `complain_feedback`
--

INSERT INTO `complain_feedback` (`id`, `complain_id`, `message`, `user_id`) VALUES
(3, 9, 'asd', 1),
(4, 9, 'asdfrdsa', 1),
(5, 9, 'sdf', 1),
(6, 9, 'sdfsdf', 1),
(7, 9, 'sdfsdf', 1),
(8, 9, 'assssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss', 1),
(9, 9, 'assssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss', 1),
(10, 9, 'hi', 2),
(11, 9, 'yo', 2);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `first_name` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `nic_number` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `telephone_number` varchar(255) DEFAULT NULL,
  `ip` varchar(255) NOT NULL,
  `city` varchar(255) NOT NULL,
  `region` varchar(255) NOT NULL,
  `country` varchar(255) NOT NULL,
  `role` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `first_name`, `last_name`, `nic_number`, `address`, `password`, `email`, `telephone_number`, `ip`, `city`, `region`, `country`, `role`) VALUES
(1, 'test first', 'test last', '945785421v', 'test', '84A3C0A525EEFF7C2B0C488C49951A1E', 'developer.eranga@gmail.com', '0754584200', '112.134.160.167', 'Kandy', 'Central Province', 'LK', 'client'),
(2, '888', 'admin last', '945785421v', 'admin ', 'CAF1A3DFB505FFED0D024130F58C5CFA', 'admin@admin.com', '0754584200', '112.134.160.167', 'Kandy', 'Central Province', 'LK', 'admin'),
(3, 'rr', 'rr', '932541853v', 'sdfdsf', '202CB962AC59075B964B07152D234B70', 'jaja@jaja.com', '0754854100', '112.134.160.68', 'Kandy', 'Central Province', 'LK', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `complains`
--
ALTER TABLE `complains`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `complain_docs`
--
ALTER TABLE `complain_docs`
  ADD PRIMARY KEY (`id`),
  ADD KEY `complain_id` (`complain_id`);

--
-- Indexes for table `complain_feedback`
--
ALTER TABLE `complain_feedback`
  ADD PRIMARY KEY (`id`),
  ADD KEY `complain_id` (`complain_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `complains`
--
ALTER TABLE `complains`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `complain_docs`
--
ALTER TABLE `complain_docs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `complain_feedback`
--
ALTER TABLE `complain_feedback`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `complains`
--
ALTER TABLE `complains`
  ADD CONSTRAINT `complains_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user` (`id`);

--
-- Constraints for table `complain_docs`
--
ALTER TABLE `complain_docs`
  ADD CONSTRAINT `complain_docs_ibfk_1` FOREIGN KEY (`complain_id`) REFERENCES `complains` (`id`);

--
-- Constraints for table `complain_feedback`
--
ALTER TABLE `complain_feedback`
  ADD CONSTRAINT `complain_feedback_ibfk_1` FOREIGN KEY (`complain_id`) REFERENCES `complains` (`id`),
  ADD CONSTRAINT `complain_feedback_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `user` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
