-- --------------------------------------------------------
-- Host:                         .\SQLExpress
-- Server version:               Microsoft SQL Server 2008 (SP1) - 10.0.2531.0 (X64) 
-- Server OS:                    Windows NT 6.1 <X64> (Build 7601: Service Pack 1)
-- HeidiSQL Version:             8.0.0.4396
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES  */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping database structure for AEIS
CREATE DATABASE IF NOT EXISTS "AEIS";
USE "AEIS";


-- Dumping structure for table AEIS.candidate_exam
CREATE TABLE IF NOT EXISTS "candidate_exam" (
	"candidate_exam_id" INT NULL,
	"exam_id" INT NULL,
	"candidate_id" INT NULL
);

-- Data exporting was unselected.


-- Dumping structure for table AEIS.candidate_tab
CREATE TABLE IF NOT EXISTS "candidate_tab" (
	"candidate_id" INT NOT NULL,
	"candidate_full_name" VARCHAR(500) NOT NULL,
	"candidate_name_initials" VARCHAR(500) NOT NULL,
	"candidate_title" VARCHAR(10) NOT NULL,
	"candidate_nationality_id" VARCHAR(100) NOT NULL,
	"candidate_nic" VARCHAR(10) NOT NULL,
	"candidate_dob" DATE NOT NULL,
	"candidate_gender" CHAR(1) NOT NULL,
	"candidate_address" VARCHAR(500) NOT NULL,
	"candidate_telno" VARCHAR(14) NOT NULL,
	"candidate_email" VARCHAR(100) NOT NULL,
	"candidate_img" VARCHAR(200) NOT NULL,
	PRIMARY KEY ("candidate_id")
);

-- Data exporting was unselected.


-- Dumping structure for table AEIS.examination_tab
CREATE TABLE IF NOT EXISTS "examination_tab" (
	"exam_id" INT NOT NULL,
	"exam_date" DATE NOT NULL,
	"exam_start_time" TIME NOT NULL,
	"exam_end_time" TIME NOT NULL,
	"exam_hall_id" INT NOT NULL,
	"exam_subject_id" INT NOT NULL,
	PRIMARY KEY ("exam_id")
);

-- Data exporting was unselected.


-- Dumping structure for table AEIS.invigilator_exam
CREATE TABLE IF NOT EXISTS "invigilator_exam" (
	"invigilator_exam_id" INT NULL,
	"exam_id" INT NULL,
	"invigilator_id" INT NULL
);

-- Data exporting was unselected.


-- Dumping structure for table AEIS.invigilator_tab
CREATE TABLE IF NOT EXISTS "invigilator_tab" (
	"invigilator_id" INT NOT NULL,
	"invigilator_full_name" VARCHAR(500) NOT NULL,
	"invigilator_name_initials" VARCHAR(500) NOT NULL,
	"invigilator_title" VARCHAR(10) NOT NULL,
	"invigilator_nationality_id" INT NOT NULL,
	"invigilator_nic" VARCHAR(10) NOT NULL,
	"invigilator_dob" DATE NOT NULL,
	"invigilator_address" VARCHAR(500) NOT NULL,
	"invigilator_telno" VARCHAR(14) NOT NULL,
	"invigilator_email" VARCHAR(100) NOT NULL,
	"invigilator_date_joined" DATE NOT NULL,
	"invigilator_qualifications" VARCHAR(1000) NOT NULL,
	"invigilator_designation_id" INT NOT NULL,
	"invigilator_img" VARCHAR(200) NOT NULL,
	"invigilator_gender" CHAR(1) NOT NULL,
	PRIMARY KEY ("invigilator_id")
);

-- Data exporting was unselected.


-- Dumping structure for table AEIS.mcq_answers_tab
CREATE TABLE IF NOT EXISTS "mcq_answers_tab" (
	"answer_id" INT NOT NULL,
	"candidate_id" INT NOT NULL,
	"exam_id" INT NOT NULL,
	"answersheet_path" VARCHAR(200) NOT NULL,
	"a1" INT NOT NULL,
	"a2" INT NOT NULL,
	"a3" INT NOT NULL,
	"a4" INT NOT NULL,
	"a5" INT NOT NULL,
	"a6" INT NOT NULL,
	"a7" INT NOT NULL,
	"a8" INT NOT NULL,
	"a9" INT NOT NULL,
	"a10" INT NOT NULL,
	"a11" INT NOT NULL,
	"a12" INT NOT NULL,
	"a13" INT NOT NULL,
	"a14" INT NOT NULL,
	"a15" INT NOT NULL,
	"a16" INT NOT NULL,
	"a17" INT NOT NULL,
	"a18" INT NOT NULL,
	"a19" INT NOT NULL,
	"a20" INT NOT NULL,
	"a21" INT NOT NULL,
	"a22" INT NOT NULL,
	"a23" INT NOT NULL,
	"a24" INT NOT NULL,
	"a25" INT NOT NULL,
	"a26" INT NOT NULL,
	"a27" INT NOT NULL,
	"a28" INT NOT NULL,
	"a29" INT NOT NULL,
	"a30" INT NOT NULL,
	"a31" INT NOT NULL,
	"a32" INT NOT NULL,
	"a33" INT NOT NULL,
	"a34" INT NOT NULL,
	"a35" INT NOT NULL,
	"a36" INT NOT NULL,
	"a37" INT NOT NULL,
	"a38" INT NOT NULL,
	"a39" INT NOT NULL,
	"a40" INT NOT NULL,
	"total_mark" INT NOT NULL,
	PRIMARY KEY ("answer_id")
);

-- Data exporting was unselected.


-- Dumping structure for table AEIS.mcq_marking_scheme_tab
CREATE TABLE IF NOT EXISTS "mcq_marking_scheme_tab" (
	"marking_scheme_id" INT NOT NULL,
	"exam_id" INT NOT NULL,
	"a1" INT NOT NULL,
	"a2" INT NOT NULL,
	"a3" INT NOT NULL,
	"a4" INT NOT NULL,
	"a5" INT NOT NULL,
	"a6" INT NOT NULL,
	"a7" INT NOT NULL,
	"a8" INT NOT NULL,
	"a9" INT NOT NULL,
	"a10" INT NOT NULL,
	"a11" INT NOT NULL,
	"a12" INT NOT NULL,
	"a13" INT NOT NULL,
	"a14" INT NOT NULL,
	"a15" INT NOT NULL,
	"a16" INT NOT NULL,
	"a17" INT NOT NULL,
	"a18" INT NOT NULL,
	"a19" INT NOT NULL,
	"a20" INT NOT NULL,
	"a21" INT NOT NULL,
	"a22" INT NOT NULL,
	"a23" INT NOT NULL,
	"a24" INT NOT NULL,
	"a25" INT NOT NULL,
	"a26" INT NOT NULL,
	"a27" INT NOT NULL,
	"a28" INT NOT NULL,
	"a29" INT NOT NULL,
	"a30" INT NOT NULL,
	"a31" INT NOT NULL,
	"a32" INT NOT NULL,
	"a33" INT NOT NULL,
	"a34" INT NOT NULL,
	"a35" INT NOT NULL,
	"a36" INT NOT NULL,
	"a37" INT NOT NULL,
	"a38" INT NOT NULL,
	"a39" INT NOT NULL,
	"a40" INT NOT NULL,
	PRIMARY KEY ("marking_scheme_id")
);

-- Data exporting was unselected.


-- Dumping structure for table AEIS.nationality_tab
CREATE TABLE IF NOT EXISTS "nationality_tab" (
	"nationality_id" INT NOT NULL,
	"nationality_name" VARCHAR(50) NOT NULL,
	PRIMARY KEY ("nationality_id")
);

-- Data exporting was unselected.
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
