-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.5.20-log - MySQL Community Server (GPL)
-- Server OS:                    Win32
-- HeidiSQL version:             7.0.0.4053
-- Date/time:                    2013-06-01 15:48:16
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;

-- Dumping database structure for aeis
CREATE DATABASE IF NOT EXISTS `aeis` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `aeis`;


-- Dumping structure for table aeis.candidate_exam
CREATE TABLE IF NOT EXISTS `candidate_exam` (
  `candidate_exam_id` int(10) DEFAULT NULL,
  `exam_id` int(10) DEFAULT NULL,
  `candidate_id` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.


-- Dumping structure for table aeis.candidate_tab
CREATE TABLE IF NOT EXISTS `candidate_tab` (
  `candidate_id` int(10) NOT NULL AUTO_INCREMENT,
  `candidate_full_name` varchar(500) NOT NULL,
  `candidate_name_initials` varchar(500) NOT NULL,
  `candidate_title` varchar(10) NOT NULL,
  `candidate_nationality_id` varchar(100) NOT NULL,
  `candidate_nic` varchar(10) NOT NULL,
  `candidate_dob` date NOT NULL,
  `candidate_gender` char(1) NOT NULL,
  `candidate_address` varchar(500) NOT NULL,
  `candidate_telno` varchar(14) NOT NULL,
  `candidate_email` varchar(100) NOT NULL,
  `candidate_img` varchar(200) NOT NULL,
  PRIMARY KEY (`candidate_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.


-- Dumping structure for table aeis.examination_tab
CREATE TABLE IF NOT EXISTS `examination_tab` (
  `exam_id` int(10) NOT NULL AUTO_INCREMENT,
  `exam_date` date NOT NULL,
  `exam_start_time` time NOT NULL,
  `exam_end_time` time NOT NULL,
  `exam_hall_id` int(11) NOT NULL,
  `exam_subject_id` int(11) NOT NULL,
  PRIMARY KEY (`exam_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.


-- Dumping structure for table aeis.invigilator_exam
CREATE TABLE IF NOT EXISTS `invigilator_exam` (
  `invigilator_exam_id` int(10) DEFAULT NULL,
  `exam_id` int(10) DEFAULT NULL,
  `invigilator_id` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.


-- Dumping structure for table aeis.invigilator_tab
CREATE TABLE IF NOT EXISTS `invigilator_tab` (
  `invigilator_id` int(10) NOT NULL AUTO_INCREMENT,
  `invigilator_full_name` varchar(500) NOT NULL,
  `invigilator_name_initials` varchar(500) NOT NULL,
  `invigilator_title` varchar(10) NOT NULL,
  `invigilator_nationality_id` int(11) NOT NULL,
  `invigilator_nic` varchar(10) NOT NULL,
  `invigilator_dob` date NOT NULL,
  `invigilator_address` varchar(500) NOT NULL,
  `invigilator_telno` varchar(14) NOT NULL,
  `invigilator_email` varchar(100) NOT NULL,
  `invigilator_date_joined` date NOT NULL,
  `invigilator_qualifications` varchar(1000) NOT NULL,
  `invigilator_designation_id` int(11) NOT NULL,
  `invigilator_img` varchar(200) NOT NULL,
  `invigilator_gender` char(1) NOT NULL,
  PRIMARY KEY (`invigilator_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.


-- Dumping structure for table aeis.mcq_answers_tab
CREATE TABLE IF NOT EXISTS `mcq_answers_tab` (
  `answer_id` int(11) NOT NULL AUTO_INCREMENT,
  `candidate_id` int(11) NOT NULL,
  `exam_id` int(11) NOT NULL,
  `answersheet_path` varchar(200) NOT NULL,
  `a1` int(1) NOT NULL DEFAULT '0',
  `a2` int(1) NOT NULL DEFAULT '0',
  `a3` int(1) NOT NULL DEFAULT '0',
  `a4` int(1) NOT NULL DEFAULT '0',
  `a5` int(1) NOT NULL DEFAULT '0',
  `a6` int(1) NOT NULL DEFAULT '0',
  `a7` int(1) NOT NULL DEFAULT '0',
  `a8` int(1) NOT NULL DEFAULT '0',
  `a9` int(1) NOT NULL DEFAULT '0',
  `a10` int(1) NOT NULL DEFAULT '0',
  `a11` int(1) NOT NULL DEFAULT '0',
  `a12` int(1) NOT NULL DEFAULT '0',
  `a13` int(1) NOT NULL DEFAULT '0',
  `a14` int(1) NOT NULL DEFAULT '0',
  `a15` int(1) NOT NULL DEFAULT '0',
  `a16` int(1) NOT NULL DEFAULT '0',
  `a17` int(1) NOT NULL DEFAULT '0',
  `a18` int(1) NOT NULL DEFAULT '0',
  `a19` int(1) NOT NULL DEFAULT '0',
  `a20` int(1) NOT NULL DEFAULT '0',
  `a21` int(1) NOT NULL DEFAULT '0',
  `a22` int(1) NOT NULL DEFAULT '0',
  `a23` int(1) NOT NULL DEFAULT '0',
  `a24` int(1) NOT NULL DEFAULT '0',
  `a25` int(1) NOT NULL DEFAULT '0',
  `a26` int(1) NOT NULL DEFAULT '0',
  `a27` int(1) NOT NULL DEFAULT '0',
  `a28` int(1) NOT NULL DEFAULT '0',
  `a29` int(1) NOT NULL DEFAULT '0',
  `a30` int(1) NOT NULL DEFAULT '0',
  `a31` int(1) NOT NULL DEFAULT '0',
  `a32` int(1) NOT NULL DEFAULT '0',
  `a33` int(1) NOT NULL DEFAULT '0',
  `a34` int(1) NOT NULL DEFAULT '0',
  `a35` int(1) NOT NULL DEFAULT '0',
  `a36` int(1) NOT NULL DEFAULT '0',
  `a37` int(1) NOT NULL DEFAULT '0',
  `a38` int(1) NOT NULL DEFAULT '0',
  `a39` int(1) NOT NULL DEFAULT '0',
  `a40` int(1) NOT NULL DEFAULT '0',
  `total_mark` int(3) NOT NULL DEFAULT '0',
  PRIMARY KEY (`answer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.


-- Dumping structure for table aeis.mcq_marking_scheme_tab
CREATE TABLE IF NOT EXISTS `mcq_marking_scheme_tab` (
  `marking_scheme_id` int(11) NOT NULL AUTO_INCREMENT,
  `exam_id` int(11) NOT NULL,
  `a1` int(1) NOT NULL DEFAULT '0',
  `a2` int(1) NOT NULL DEFAULT '0',
  `a3` int(1) NOT NULL DEFAULT '0',
  `a4` int(1) NOT NULL DEFAULT '0',
  `a5` int(1) NOT NULL DEFAULT '0',
  `a6` int(1) NOT NULL DEFAULT '0',
  `a7` int(1) NOT NULL DEFAULT '0',
  `a8` int(1) NOT NULL DEFAULT '0',
  `a9` int(1) NOT NULL DEFAULT '0',
  `a10` int(1) NOT NULL DEFAULT '0',
  `a11` int(1) NOT NULL DEFAULT '0',
  `a12` int(1) NOT NULL DEFAULT '0',
  `a13` int(1) NOT NULL DEFAULT '0',
  `a14` int(1) NOT NULL DEFAULT '0',
  `a15` int(1) NOT NULL DEFAULT '0',
  `a16` int(1) NOT NULL DEFAULT '0',
  `a17` int(1) NOT NULL DEFAULT '0',
  `a18` int(1) NOT NULL DEFAULT '0',
  `a19` int(1) NOT NULL DEFAULT '0',
  `a20` int(1) NOT NULL DEFAULT '0',
  `a21` int(1) NOT NULL DEFAULT '0',
  `a22` int(1) NOT NULL DEFAULT '0',
  `a23` int(1) NOT NULL DEFAULT '0',
  `a24` int(1) NOT NULL DEFAULT '0',
  `a25` int(1) NOT NULL DEFAULT '0',
  `a26` int(1) NOT NULL DEFAULT '0',
  `a27` int(1) NOT NULL DEFAULT '0',
  `a28` int(1) NOT NULL DEFAULT '0',
  `a29` int(1) NOT NULL DEFAULT '0',
  `a30` int(1) NOT NULL DEFAULT '0',
  `a31` int(1) NOT NULL DEFAULT '0',
  `a32` int(1) NOT NULL DEFAULT '0',
  `a33` int(1) NOT NULL DEFAULT '0',
  `a34` int(1) NOT NULL DEFAULT '0',
  `a35` int(1) NOT NULL DEFAULT '0',
  `a36` int(1) NOT NULL DEFAULT '0',
  `a37` int(1) NOT NULL DEFAULT '0',
  `a38` int(1) NOT NULL DEFAULT '0',
  `a39` int(1) NOT NULL DEFAULT '0',
  `a40` int(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`marking_scheme_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.


-- Dumping structure for table aeis.nationality_tab
CREATE TABLE IF NOT EXISTS `nationality_tab` (
  `nationality_id` int(10) NOT NULL AUTO_INCREMENT,
  `nationality_name` varchar(50) NOT NULL,
  PRIMARY KEY (`nationality_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
