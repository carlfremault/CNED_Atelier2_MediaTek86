-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : sam. 03 avr. 2021 à 10:14
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : mediatek86
--
CREATE DATABASE IF NOT EXISTS mediatek86 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE mediatek86;

-- --------------------------------------------------------

--
-- Structure de la table absence
--

DROP TABLE IF EXISTS absence;
CREATE TABLE absence (
  idpersonnel int(11) NOT NULL,
  datedebut datetime NOT NULL,
  idmotif int(11) NOT NULL,
  datefin datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table absence
--

INSERT INTO absence (idpersonnel, datedebut, idmotif, datefin) VALUES
(1, '2021-01-01 00:00:00', 1, '2021-01-08 00:00:00'),
(1, '2021-04-01 00:00:00', 3, '2021-04-06 00:00:00'),
(1, '2021-08-02 00:00:00', 2, '2021-10-10 00:00:00'),
(1, '2021-10-20 00:00:00', 1, '2021-11-13 00:00:00'),
(2, '2020-10-25 21:05:50', 4, '2021-01-27 08:58:46'),
(2, '2021-05-25 11:19:25', 3, '2021-05-26 18:42:06'),
(2, '2022-02-14 00:00:00', 2, '2022-02-26 00:00:00'),
(3, '2020-05-20 00:00:00', 2, '2020-05-27 00:00:00'),
(3, '2021-06-01 00:00:00', 1, '2021-06-21 00:00:00'),
(3, '2022-01-18 02:26:52', 3, '2022-01-25 01:51:13'),
(4, '2020-09-08 00:00:00', 3, '2020-09-24 00:00:00'),
(4, '2020-10-09 12:02:54', 4, '2021-10-10 13:38:11'),
(4, '2020-12-01 00:00:00', 4, '2020-12-19 00:00:00'),
(4, '2021-01-12 00:00:00', 2, '2021-02-02 00:00:00'),
(4, '2021-03-07 02:45:47', 4, '2021-03-27 09:50:28'),
(4, '2021-05-12 00:00:00', 1, '2021-05-28 00:00:00'),
(4, '2021-07-28 00:00:00', 4, '2021-08-07 00:00:00'),
(4, '2021-08-09 00:00:00', 1, '2020-09-19 00:00:00'),
(5, '2020-05-01 00:00:00', 1, '2020-06-01 00:00:00'),
(5, '2020-07-26 00:00:00', 3, '2020-08-04 00:00:00'),
(5, '2020-10-19 13:21:11', 2, '2020-11-07 04:23:42'),
(5, '2022-01-01 00:00:00', 1, '2022-01-05 00:00:00'),
(6, '2020-06-03 00:00:00', 3, '2020-06-05 00:00:00'),
(6, '2020-10-14 10:50:21', 1, '2022-02-22 02:30:57'),
(6, '2021-04-01 00:00:00', 4, '2021-04-30 00:00:00'),
(7, '2020-06-05 00:00:00', 3, '2020-06-10 00:00:00'),
(7, '2020-09-24 00:00:00', 3, '2020-09-30 00:00:00'),
(7, '2021-03-04 10:42:27', 2, '2021-06-30 17:51:20'),
(7, '2021-06-09 00:00:00', 3, '2021-06-10 00:00:00'),
(7, '2021-07-10 00:00:00', 4, '2021-07-21 00:00:00'),
(7, '2021-09-01 00:00:00', 1, '2021-09-15 00:00:00'),
(7, '2021-10-01 05:01:55', 4, '2022-02-15 19:59:21'),
(7, '2022-02-25 00:00:00', 1, '2022-03-10 00:00:00'),
(8, '2020-05-14 00:00:00', 1, '2020-05-16 00:00:00'),
(8, '2021-03-09 00:00:00', 1, '2021-03-11 00:00:00'),
(8, '2021-04-01 00:00:00', 2, '2021-04-08 00:00:00'),
(8, '2021-10-12 00:00:00', 1, '2021-10-24 00:00:00'),
(9, '2020-03-21 00:00:00', 4, '2020-03-29 00:00:00'),
(9, '2020-03-29 01:44:13', 4, '2020-06-17 12:18:16'),
(9, '2021-01-21 00:00:00', 2, '2021-07-05 00:00:00'),
(9, '2021-08-15 00:00:00', 4, '2021-08-16 00:00:00'),
(9, '2021-08-16 00:00:00', 3, '2021-09-18 00:00:00'),
(9, '2021-12-23 00:00:00', 4, '2021-12-25 00:00:00'),
(9, '2021-12-26 00:00:00', 4, '2021-12-31 00:00:00'),
(9, '2022-03-15 00:00:00', 1, '2022-03-27 00:00:00'),
(10, '2020-05-10 00:00:00', 2, '2020-05-28 00:00:00'),
(10, '2020-07-31 00:00:00', 1, '2020-08-23 00:00:00'),
(10, '2021-03-18 00:00:00', 3, '2021-03-24 00:00:00'),
(10, '2021-04-03 00:00:00', 1, '2021-04-10 00:00:00'),
(10, '2021-07-01 00:00:00', 4, '2021-09-25 00:00:00');

-- --------------------------------------------------------

--
-- Structure de la table motif
--

DROP TABLE IF EXISTS motif;
CREATE TABLE motif (
  idmotif int(11) NOT NULL,
  libelle varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table motif
--

INSERT INTO motif (idmotif, libelle) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table personnel
--

DROP TABLE IF EXISTS personnel;
CREATE TABLE personnel (
  idpersonnel int(11) NOT NULL,
  idservice int(11) NOT NULL,
  nom varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  prenom varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  tel varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  mail varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table personnel
--

INSERT INTO personnel (idpersonnel, idservice, nom, prenom, tel, mail) VALUES
(1, 1, 'Picard', 'Amine', '04 75 57 12 72', 'tempus@nec.co.uk'),
(2, 2, 'Guillot', 'Catherine', '09 72 81 95 17', 'dictum.placerat@malesuada.org'),
(3, 3, 'Masson', 'Romain', '09 45 91 26 54', 'ante.iaculis@habitant.com'),
(4, 2, 'Marechal', 'Capucine', '06 32 96 80 98', 'Etiam@tempor.ca'),
(5, 2, 'Rey', 'Marine', '02 48 11 21 30', 'ipsum.cursus.vestibulum@molestie.edu'),
(6, 3, 'Julien', 'Alice', '04 23 27 46 21', 'sit.amet@rede.net'),
(7, 2, 'Meunier', 'Anaëlle', '07 65 36 82 52', 'et.commodo.at@acturpisegestas.ca'),
(8, 1, 'Boyer', 'Louis', '09 96 92 78 57', 'a.dui@eget.co.uk'),
(9, 3, 'Baron', 'Mattéo', '01 36 39 03 59', 'Donec.non@Sed.com'),
(10, 3, 'Aubry', 'Maëlle', '09 20 68 39 23', 'ut.quam@pedeblandit.org');

-- --------------------------------------------------------

--
-- Structure de la table responsable
--

DROP TABLE IF EXISTS responsable;
CREATE TABLE responsable (
  login varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL,
  pwd varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table responsable
--

INSERT INTO responsable (login, pwd) VALUES
('mediatek86', '967520ae23e8ee14888bae72809031b98398ae4a636773e18fff917d77679334');

-- --------------------------------------------------------

--
-- Structure de la table service
--

DROP TABLE IF EXISTS service;
CREATE TABLE service (
  idservice int(11) NOT NULL,
  nom varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table service
--

INSERT INTO service (idservice, nom) VALUES
(1, 'Administratif'),
(2, 'Médiation culturelle'),
(3, 'Prêt');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table absence
--
ALTER TABLE absence
  ADD PRIMARY KEY (idpersonnel,datedebut),
  ADD KEY FK_absence_motif (idmotif);

--
-- Index pour la table motif
--
ALTER TABLE motif
  ADD PRIMARY KEY (idmotif);

--
-- Index pour la table personnel
--
ALTER TABLE personnel
  ADD PRIMARY KEY (idpersonnel),
  ADD KEY FK_personnel_service (idservice);

--
-- Index pour la table service
--
ALTER TABLE service
  ADD PRIMARY KEY (idservice);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table motif
--
ALTER TABLE motif
  MODIFY idmotif int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table personnel
--
ALTER TABLE personnel
  MODIFY idpersonnel int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT pour la table service
--
ALTER TABLE service
  MODIFY idservice int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table absence
--
ALTER TABLE absence
  ADD CONSTRAINT absence_ibfk_1 FOREIGN KEY (idmotif) REFERENCES motif (idmotif),
  ADD CONSTRAINT absence_ibfk_2 FOREIGN KEY (idpersonnel) REFERENCES personnel (idpersonnel);

--
-- Contraintes pour la table personnel
--
ALTER TABLE personnel
  ADD CONSTRAINT personnel_ibfk_1 FOREIGN KEY (idservice) REFERENCES service (idservice);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;



CREATE USER 'mediatek86'@'%' IDENTIFIED BY 'motdepasse';

GRANT ALL PRIVILEGES ON `mediatek86`.* TO 'mediatek86'@'%';
