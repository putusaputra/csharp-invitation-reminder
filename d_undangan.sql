-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Waktu pembuatan: 03. Nopember 2013 jam 12:09
-- Versi Server: 5.5.8
-- Versi PHP: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `d_undangan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_detail_undangan`
--

CREATE TABLE IF NOT EXISTS `t_detail_undangan` (
  `id_undangan` varchar(20) DEFAULT NULL,
  `tanggal_undangan` date DEFAULT NULL,
  `jam_undangan` time DEFAULT NULL,
  `lokasi_undangan` varchar(500) DEFAULT NULL,
  `materi` varchar(1000) DEFAULT NULL,
  `pakaian` varchar(500) DEFAULT NULL,
  `perlengkapan` varchar(1000) DEFAULT NULL,
  `nama_pengirim` varchar(200) DEFAULT NULL,
  `no_surat` varchar(200) DEFAULT NULL,
  `contact_person` varchar(100) DEFAULT NULL,
  KEY `fk_idundangan` (`id_undangan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `t_detail_undangan`
--

INSERT INTO `t_detail_undangan` (`id_undangan`, `tanggal_undangan`, `jam_undangan`, `lokasi_undangan`, `materi`, `pakaian`, `perlengkapan`, `nama_pengirim`, `no_surat`, `contact_person`) VALUES
('102620130002', '2013-10-30', '20:00:00', 'sjdnsjndjsdnj', 'nsjndjsdn', 'nsjnjdnsnd', 'ksijdsd', 'nsndjsnd', '2832723/232673', '23827362'),
('102620130003', '2013-10-31', '22:00:00', 'nsnnbdsjbdbsd', 'jkskjsdj', 'skdjsndjn', 'mskndjnsj', 'nsnjdnsnd', '28382737', '73827387'),
('102620130004', '2013-11-01', '14:00:00', 'msnjdjnsd', 'jsjdjshdhsd', 'nsjndjsdhsdh', 'skdslkdksd', 'mjsndjsnjdnsd', '1323/2323/2323/2323', '8273273723'),
('102720130001', '2013-10-30', '15:00:00', 'mskdnksn', 'njsdjn', 'nsjndj', 'sjsjdn', 'nsjndj', '283237', '372837'),
('102920130001', '2013-11-01', '14:00:00', 'nnsjnjsbdhb', 'nsbdhsb', 'msnjndjsnd', 'njsndjnsdjn', 'ksjdsijd', '2732732', '62337623'),
('102920130002', '2013-11-01', '15:30:00', 'nsnsndsnbh', 'snjdnsjdn', 'nsjndjsnd', 'sjdjsdij', 'nsbdhsdb', '28387233', '73263236'),
('110120130001', '2013-11-20', '14:00:00', 'mkdmnsdjn', 'nsjnjdnsjdn', 'njsnjndsjn', 'nsjndjsnd', 'nsjndjnsd', '2832837', '2738273'),
('110120130002', '2013-11-20', '15:00:00', 'mnsdjnsdn', 'nsjndnsd', 'nsjndnsj', 'ksjdjsd', 'skndjndjn', '28387237', '37287383');

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_pejabat`
--

CREATE TABLE IF NOT EXISTS `t_pejabat` (
  `id_pejabat` varchar(100) NOT NULL,
  `nama_pejabat` varchar(500) DEFAULT NULL,
  `jabatan` varchar(500) DEFAULT NULL,
  `no_telp` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_pejabat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `t_pejabat`
--

INSERT INTO `t_pejabat` (`id_pejabat`, `nama_pejabat`, `jabatan`, `no_telp`) VALUES
('23456', 'nsjdsbdbshdb', 'Sekretaris Dinas', '283727362'),
('34567', 'snjndsjdnjdsb', 'Pembina Muda', '23827323'),
('45678', 'msndjbashdbs', 'Pembina Muda', '2736273623');

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_undangan`
--

CREATE TABLE IF NOT EXISTS `t_undangan` (
  `tanggal_terima` date DEFAULT NULL,
  `jam_terima` time DEFAULT NULL,
  `id_undangan` varchar(20) NOT NULL,
  `id_disposisi` varchar(100) DEFAULT NULL,
  `disposisi_kalimat` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`id_undangan`),
  KEY `fk_iddisposisi` (`id_disposisi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `t_undangan`
--

INSERT INTO `t_undangan` (`tanggal_terima`, `jam_terima`, `id_undangan`, `id_disposisi`, `disposisi_kalimat`) VALUES
('2013-10-26', '17:36:20', '102620130002', '23456', 'smjdnjsndjnsd sdsjnds dnjsndjs'),
('2013-10-26', '17:36:54', '102620130003', '34567', 'n dssjdjsdsdh sndjsndsjdn'),
('2013-10-26', '17:37:49', '102620130004', '45678', 'jnsndjsndjnsd'),
('2013-10-27', '18:40:20', '102720130001', '23456', 'ananananan'),
('2013-10-29', '08:31:46', '102920130001', '23456', 'mknsjndsjdn'),
('2013-10-29', '08:32:20', '102920130002', '23456', 'sndjnsdjnsdnjdn'),
('2013-11-01', '17:09:15', '110120130001', '23456', 'mskndjnsdn'),
('2013-11-01', '17:09:40', '110120130002', '23456', 'mdnjndjsnnsd');

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `t_detail_undangan`
--
ALTER TABLE `t_detail_undangan`
  ADD CONSTRAINT `fk_idundangan` FOREIGN KEY (`id_undangan`) REFERENCES `t_undangan` (`id_undangan`) ON DELETE CASCADE;

--
-- Ketidakleluasaan untuk tabel `t_undangan`
--
ALTER TABLE `t_undangan`
  ADD CONSTRAINT `fk_iddisposisi` FOREIGN KEY (`id_disposisi`) REFERENCES `t_pejabat` (`id_pejabat`) ON DELETE CASCADE;
