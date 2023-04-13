-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Apr 13, 2023 at 02:45 PM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `music`
--

-- --------------------------------------------------------

--
-- Table structure for table `artist`
--

CREATE TABLE `artist` (
  `artist_ID` int(11) NOT NULL,
  `artist_name` varchar(255) NOT NULL,
  `artist_info` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `artist`
--

INSERT INTO `artist` (`artist_ID`, `artist_name`, `artist_info`) VALUES
(11, 'artiste 4', ''),
(12, 'ARTIST ', 'INFOS'),
(13, 'ARTIST 2', 'infos'),
(15, 'THEO', 'INFOS');

-- --------------------------------------------------------

--
-- Table structure for table `concert`
--

CREATE TABLE `concert` (
  `concert_ID` int(11) NOT NULL,
  `concert_name` varchar(255) NOT NULL,
  `concert_hour` varchar(255) NOT NULL,
  `concert_artist` varchar(255) NOT NULL,
  `concert_date` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `concert`
--

INSERT INTO `concert` (`concert_ID`, `concert_name`, `concert_hour`, `concert_artist`, `concert_date`) VALUES
(17, 'NAME', '22:30', 'THEO', '22/05/2023'),
(18, 'NAME 2 ', '22:00', 'THEO', '05/08/2023');

-- --------------------------------------------------------

--
-- Table structure for table `music_titles`
--

CREATE TABLE `music_titles` (
  `title_ID` int(11) NOT NULL,
  `title_name` varchar(255) NOT NULL,
  `title_author` varchar(255) NOT NULL,
  `title_img` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `music_titles`
--

INSERT INTO `music_titles` (`title_ID`, `title_name`, `title_author`, `title_img`) VALUES
(1, '1', '2', '3'),
(2, '4', '5', '6'),
(3, '7', '8', '9'),
(4, '10', '11', '12'),
(5, '13', '14', '15'),
(6, '16', '17', '18'),
(7, '19', '20', '21');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_ID` int(11) NOT NULL,
  `user_email` varchar(255) DEFAULT NULL,
  `user_pw` varchar(255) DEFAULT NULL,
  `user_bd` varchar(255) NOT NULL,
  `user_gender` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_ID`, `user_email`, `user_pw`, `user_bd`, `user_gender`) VALUES
(7, 'reinca@reinca.com', '$2a$11$QlyMv.6wpFcUzJC.QKAQneGqncYBtPlqLclPklz8QmcqMJ21XflDq', '03/06/1996', 'man'),
(8, 'reinca@reinca.com', '$2a$11$g7o1GhlVwZM9sBPRzFF00OKi4HRsgmzSAhnjwakYEliK10fUa8Axq', '03/06/1996', 'man'),
(9, 'abcd@abcd.com', '$2a$11$wov..mOfGhBx2atVRMH35eaahfx5NUxzi2pBFUVLiW.AoDbuEImKO', '03/06/1996', 'man'),
(10, 'a.a@com', '$2a$11$3MjSJ5e.Ko.D2MKlUS9MEOHvS0gHsCT2YNzPQkjAnrkkFtFB0.Rre', '03/06/1996', 'man'),
(11, 'a.a@com', '$2a$11$RuK6rU0ocE0is9TG0GOdr.c52RrlmmJBwVcQa8EjN0P4hSybk0EIW', '03/06/1996', 'man'),
(12, 'a.a@com', '$2a$11$THdNBZPFKLLGMQAu9qHHS.IF4.eejPg.uKveHktNGnpL4T3DkA9Oi', '03/06/1996', 'man'),
(13, 'a.a@com', '$2a$11$f4S515buhCZL0BY.nbZl1.SE4wjNuVlaoqrMgeNREtWFoWILTHp7G', '03/06/1996', 'man'),
(14, 'a.a@com', '$2a$11$5ri6MbQaqdkH0ZRJimrdK.pxMI7DQ/Jhb6V/7KSb2qySR033ydHzS', '03/06/1996', 'man'),
(15, 'a@a.com', '$2a$11$dKYytcraV3lBS7Qn6c/2Y.n74J8SBZH7xtjMAFRWagTN1lFBBt1gq', '03/06/1996', 'man'),
(16, 'a@a.com', '$2a$11$JJU6VrT8bPr5lhxV7tHqSebUpm1ZDK1Ozp7G1q86itcgZzeZsQZCW', '03/06/1996', 'man'),
(17, 'a@a.com', '$2a$11$Vir7Z2KzBbvf.Twjhg3HXO3ZAHl.suBlx.9VkK0chFlUUFBDYlsmi', '03/06/1996', 'man'),
(18, 'a@a.com', '$2a$11$6I2NmMj5ciCw8jy9/UBi2eedJjXGq9gdy00xHJ6iPI.Kfd7BVkM8O', '03/06/1996', 'man'),
(19, 'a@a.com', '$2a$11$sGZuoubuoZcLjmAArLDtGe9FCT3GWFcwKJ.3EDNb5ygobI8Nr5d7S', '03/06/1996', 'man'),
(20, 'a@a.com', '$2a$11$cKrmLQnjk2nscsnEG64RCOipUIj6MTnQlxaDJVYEtBM9viaZB.VWG', '03/06/1996', 'man'),
(21, 'a@a.com', '$2a$11$Kk9HXMTIru827P5BR70nROlSSXAE1FfH7o6CbTKg/kRYSF73UGjRy', '03/06/1996', 'man'),
(22, 'a@a.com', '$2a$11$3guTu0TTdlIYbUMWAU.zi.Knh9jqeItHKBEm.nzbVN6yo/I7UXz3K', '03/06/1996', 'man'),
(23, 'a@a.com', '$2a$11$T0xQrkktXIdmC1Mu19/8AOjst2AkRPFeQi/B15e9e0UP8gxjy2.xW', '03/06/1996', 'man'),
(24, 'a@a.com', '$2a$11$1yV8.7Kcc8u04gqKPGAfbeBRu10W11mMQxptPO6wtb1mDrn4W9tFC', '03/06/1996', 'man'),
(25, 'a@a.com', '$2a$11$qr6Fk1HJ7nF1osneZ22dGeZQm1dXWFw.1kklbxR0MDxeYGm45JYs6', '03/06/1996', 'man'),
(26, 'a@a.com', '$2a$11$9IO7P.1M9Ps0LwobRX9he.gNyAA6TVn/st214LqmzbEM5xlyV.HOa', '03/06/1996', 'man'),
(27, 'a@a.com', '$2a$11$yHs89n0CacEu.pB5YqyPDOv9873x5Is3s2ZYHrxAlygDrGe51vW6y', '03/06/1996', 'man'),
(28, 'Your e-mail @', '$2a$11$8TOLPQSUdcmnlttoYiNj6OX51WEbFGbgQXZM/qF0cwnd/ZZvVnici', ' 0/36/066', 'man'),
(29, 'a@a.com', '$2a$11$tpN6TDJCclg/4TLvKGguFOn2Yq51b9El7sxZYAdOBgOM4fSZ9AIH6', '03/06/1996', 'man'),
(30, 'a@a.com', '$2a$11$P7gik37nPR0bGiH5j31oOOzpeEDRTIojNoFJD0/eAt7.xTQx0OrBq', '03/06/1996', 'man');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `artist`
--
ALTER TABLE `artist`
  ADD PRIMARY KEY (`artist_ID`),
  ADD UNIQUE KEY `artist_name` (`artist_name`);

--
-- Indexes for table `concert`
--
ALTER TABLE `concert`
  ADD PRIMARY KEY (`concert_ID`),
  ADD KEY `concert_artist` (`concert_artist`);

--
-- Indexes for table `music_titles`
--
ALTER TABLE `music_titles`
  ADD PRIMARY KEY (`title_ID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `artist`
--
ALTER TABLE `artist`
  MODIFY `artist_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `concert`
--
ALTER TABLE `concert`
  MODIFY `concert_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `music_titles`
--
ALTER TABLE `music_titles`
  MODIFY `title_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `user_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `concert`
--
ALTER TABLE `concert`
  ADD CONSTRAINT `concert_ibfk_1` FOREIGN KEY (`concert_artist`) REFERENCES `artist` (`artist_name`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
