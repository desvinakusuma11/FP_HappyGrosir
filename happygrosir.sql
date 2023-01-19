-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 19, 2023 at 01:19 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `happygrosir`
--

-- --------------------------------------------------------

--
-- Table structure for table `data_barang`
--

CREATE TABLE `data_barang` (
  `id` int(11) NOT NULL,
  `kd_barang` int(11) NOT NULL,
  `nama_barang` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `jumlah` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `data_barang`
--

INSERT INTO `data_barang` (`id`, `kd_barang`, `nama_barang`, `jumlah`) VALUES
(1, 121, 'Ayam', 150),
(2, 122, 'Gula', 234),
(3, 123, 'Garam', 120),
(4, 124, 'Micin', 200),
(5, 125, 'Tissue', 240),
(6, 126, 'Saos Sambal', 237),
(7, 127, 'Kecap', 140),
(8, 128, 'Masker', 340),
(9, 129, 'Saos tomat', 350),
(10, 130, 'Ladaku', 460),
(11, 131, 'Beras', 250),
(12, 132, 'Susu', 360),
(13, 133, 'Minyak', 540),
(14, 134, 'Bumbu Racik Ayam Goreng', 350),
(15, 135, 'Masako', 260),
(16, 136, 'Rinso', 127),
(17, 137, 'Molto', 345),
(18, 138, 'Pepsodent', 256),
(19, 139, 'Lifebuoy', 345),
(20, 140, 'Close Up', 200),
(21, 141, 'Sunlight', 156),
(22, 142, 'Indomie', 270),
(23, 143, 'Teh Sari Wangi', 370),
(24, 144, 'Tepung Segitiga Biru', 260),
(25, 145, 'Kopi ABC', 520);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `kd_user` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `nama`, `kd_user`) VALUES
(1, 'S', 'S'),
(2, 'Desvina', '21114193'),
(3, 'Chindy', '21114234'),
(4, 'Agil', '21114220'),
(5, 'Wisnu', '21114221'),
(6, 'Azmi', '21114226'),
(7, 'Falah', '21114258');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `data_barang`
--
ALTER TABLE `data_barang`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `data_barang`
--
ALTER TABLE `data_barang`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
