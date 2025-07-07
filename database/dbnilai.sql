CREATE DATABASE IF NOT EXISTS `dbnilai`;
USE `dbnilai`;

CREATE TABLE `tblmahasiswa` (
  `nim` varchar(10) NOT NULL,
  `nama` varchar(30) DEFAULT NULL,
  `tlhr` varchar(20) DEFAULT NULL,
  `tgllhr` date DEFAULT NULL,
  `usia` int(3) DEFAULT NULL,
  `jenkel` varchar(10) DEFAULT NULL,
  `agama` varchar(15) DEFAULT NULL,
  `almt` varchar(20) DEFAULT NULL,
  `telp` varchar(13) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `tbldosen` (
  `nidn` varchar(10) NOT NULL,
  `nmdosen` varchar(30) DEFAULT NULL,
  `email` varchar(30) DEFAULT NULL,
  `telp` varchar(13) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `tblmatakuliah` (
  `kdmtk` varchar(10) NOT NULL,
  `nmmtk` varchar(30) DEFAULT NULL,
  `sks` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `tblnilai` (
  `id_nilai` int(11) NOT NULL,
  `ta` varchar(20) DEFAULT NULL,
  `sem` varchar(10) DEFAULT NULL,
  `nim` varchar(10) DEFAULT NULL,
  `nidn` varchar(10) DEFAULT NULL,
  `kdmtk` varchar(10) DEFAULT NULL,
  `na` double DEFAULT NULL,
  `nh` varchar(2) DEFAULT NULL,
  `bbt` varchar(2) DEFAULT NULL,
  `jml` int(2) DEFAULT NULL,
  `ket` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

ALTER TABLE `tblmahasiswa`
  ADD PRIMARY KEY (`nim`);

ALTER TABLE `tbldosen`
  ADD PRIMARY KEY (`nidn`);

ALTER TABLE `tblmatakuliah`
  ADD PRIMARY KEY (`kdmtk`);

ALTER TABLE `tblnilai`
  ADD PRIMARY KEY (`id_nilai`);

ALTER TABLE `tblnilai`
  MODIFY `id_nilai` int(11) NOT NULL AUTO_INCREMENT;

CREATE VIEW `querynilai` AS 
SELECT 
`tblnilai`.`id_nilai`, 
`tblnilai`.`ta`, 
`tblnilai`.`sem`, 
`tblnilai`.`nim`, 
`tblmahasiswa`.`nama`, 
`tblmahasiswa`.`tlhr`, 
`tblmahasiswa`.`tgllhr`, 
`tblmahasiswa`.`usia`, 
`tblmahasiswa`.`jenkel`, 
`tblmahasiswa`.`agama`, 
`tblmahasiswa`.`almt`, 
`tblnilai`.`nidn`, 
`tbldosen`.`nmdosen`, 
`tbldosen`.`email`, 
`tbldosen`.`telp`, 
`tblnilai`.`kdmtk`, 
`tblmatakuliah`.`nmmtk`, 
`tblmatakuliah`.`sks`, 
`tblnilai`.`na`, 
`tblnilai`.`nh`, 
`tblnilai`.`bbt`, 
`tblnilai`.`jml`, 
`tblnilai`.`ket` 
FROM `tblnilai`, `tblmatakuliah`, `tblmahasiswa`, `tbldosen` 
WHERE `tblnilai`.`nim` = `tblmahasiswa`.`nim` AND `tblnilai`.`nidn` = `tbldosen`.`nidn` AND `tblnilai`.`kdmtk` = `tblmatakuliah`.`kdmtk`;
