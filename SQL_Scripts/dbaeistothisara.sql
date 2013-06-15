-- --------------------------------------------------------
-- Host:                         .\SQLExpress
-- Server version:               Microsoft SQL Server 2008 (SP1) - 10.0.2531.0 (X64) 
-- Server OS:                    Windows NT 6.1 <X64> (Build 7601: Service Pack 1)
-- HeidiSQL version:             7.0.0.4053
-- Date/time:                    2013-06-08 13:07:48
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES  */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;

-- Dumping database structure for AEIS
CREATE DATABASE IF NOT EXISTS "AEIS";
USE "AEIS";


-- Dumping structure for table AEIS.alert_tab
CREATE TABLE IF NOT EXISTS "alert_tab" (
	"alert_id" INT NOT NULL,
	"exam_id" INT NOT NULL,
	"position_id" INT NOT NULL,
	"alert_type" CHAR(1) NOT NULL,
	"alert_time" DATETIME NOT NULL);

-- Data exporting was unselected.


-- Dumping structure for table AEIS.candidate_exam
CREATE TABLE IF NOT EXISTS "candidate_exam" (
	"candidate_exam_id" INT NULL,
	"exam_id" INT NULL,
	"candidate_id" INT NULL);

-- Data exporting was unselected.


-- Dumping structure for table AEIS.candidate_position
CREATE TABLE IF NOT EXISTS "candidate_position" (
	"can_pos_id" INT NOT NULL,
	"exam_id" INT NOT NULL,
	"position_id" INT NOT NULL,
	"candidate_id" INT NOT NULL);

-- Data exporting was unselected.


-- Dumping structure for table AEIS.candidate_tab
CREATE TABLE IF NOT EXISTS "candidate_tab" (
	"candidate_id" INT NOT NULL,
	"candidate_full_name" VARCHAR(500) NULL,
	"candidate_name_initials" VARCHAR(500) NULL,
	"candidate_title" VARCHAR(10) NULL,
	"candidate_nationality_id" VARCHAR(100) NULL,
	"candidate_nic" VARCHAR(10) NULL,
	"candidate_dob" DATE NULL,
	"candidate_gender" CHAR(1) NULL,
	"candidate_address" VARCHAR(500) NULL,
	"candidate_telno" VARCHAR(14) NULL,
	"candidate_email" VARCHAR(100) NULL,
	"candidate_img" VARCHAR(200) NULL);

-- Data exporting was unselected.


-- Dumping structure for table AEIS.examination_tab
CREATE TABLE IF NOT EXISTS "examination_tab" (
	"exam_id" INT NOT NULL,
	"exam_date" DATE NOT NULL,
	"exam_start_time" TIME NOT NULL,
	"exam_end_time" TIME NOT NULL,
	"exam_hall_id" INT NOT NULL,
	"exam_subject_id" INT NOT NULL);

-- Data exporting was unselected.


-- Dumping structure for table AEIS.hall_position
CREATE TABLE IF NOT EXISTS "hall_position" (
	"hall_pos_id" INT NOT NULL,
	"hall_id" INT NOT NULL,
	"position_id" INT NOT NULL,
	"pos_x" INT NOT NULL,
	"pos_y" INT NOT NULL);

-- Data exporting was unselected.


-- Dumping structure for table AEIS.invigilator_exam
CREATE TABLE IF NOT EXISTS "invigilator_exam" (
	"invigilator_exam_id" INT NULL,
	"exam_id" INT NULL,
	"invigilator_id" INT NULL);

-- Data exporting was unselected.


-- Dumping structure for table AEIS.invigilator_tab
CREATE TABLE IF NOT EXISTS "invigilator_tab" (
	"invigilator_id" INT NOT NULL,
	"invigilator_full_name" VARCHAR(500) NULL,
	"invigilator_name_initials" VARCHAR(500) NULL,
	"invigilator_title" VARCHAR(10) NULL,
	"invigilator_nationality_id" INT NULL,
	"invigilator_nic" VARCHAR(10) NULL,
	"invigilator_dob" VARCHAR(1) NULL,
	"invigilator_address" VARCHAR(500) NULL,
	"invigilator_telno" VARCHAR(14) NULL,
	"invigilator_email" VARCHAR(100) NULL,
	"invigilator_date_joined" VARCHAR(1) NULL,
	"invigilator_qualifications" VARCHAR(1000) NULL,
	"invigilator_designation_id" INT NULL,
	"invigilator_img" VARCHAR(200) NULL,
	"invigilator_gender" CHAR(1) NULL);

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
	"total_mark" INT NOT NULL);

-- Data exporting was unselected.


-- Dumping structure for table AEIS.mcq_marking_scheme_tab
CREATE TABLE IF NOT EXISTS "mcq_marking_scheme_tab" (
	"marking_scheme_id" INT NOT NULL,
	"exam_id" INT NOT NULL,
	"a1" INT NULL,
	"a2" INT NULL,
	"a3" INT NULL,
	"a4" INT NULL,
	"a5" INT NULL,
	"a6" INT NULL,
	"a7" INT NULL,
	"a8" INT NULL,
	"a9" INT NULL,
	"a10" INT NULL,
	"a11" INT NULL,
	"a12" INT NULL,
	"a13" INT NULL,
	"a14" INT NULL,
	"a15" INT NULL,
	"a16" INT NULL,
	"a17" INT NULL,
	"a18" INT NULL,
	"a19" INT NULL,
	"a20" INT NULL,
	"a21" INT NULL,
	"a22" INT NULL,
	"a23" INT NULL,
	"a24" INT NULL,
	"a25" INT NULL,
	"a26" INT NULL,
	"a27" INT NULL,
	"a28" INT NULL,
	"a29" INT NULL,
	"a30" INT NULL,
	"a31" INT NULL,
	"a32" INT NULL,
	"a33" INT NULL,
	"a34" INT NULL,
	"a35" INT NULL,
	"a36" INT NULL,
	"a37" INT NULL,
	"a38" INT NULL,
	"a39" INT NULL,
	"a40" INT NULL);

-- Data exporting was unselected.


-- Dumping structure for table AEIS.nationality_tab
CREATE TABLE IF NOT EXISTS "nationality_tab" (
	"nationality_id" INT NOT NULL,
	"nationality_name" VARCHAR(50) NOT NULL);

-- Data exporting was unselected.


-- Dumping database structure for master
CREATE DATABASE IF NOT EXISTS "master";
USE "master";


-- Dumping structure for table master.MSreplication_options
CREATE TABLE IF NOT EXISTS "MSreplication_options" );

-- Data exporting was unselected.


-- Dumping structure for table master.spt_fallback_db
CREATE TABLE IF NOT EXISTS "spt_fallback_db" );

-- Data exporting was unselected.


-- Dumping structure for table master.spt_fallback_dev
CREATE TABLE IF NOT EXISTS "spt_fallback_dev" );

-- Data exporting was unselected.


-- Dumping structure for table master.spt_fallback_usg
CREATE TABLE IF NOT EXISTS "spt_fallback_usg" );

-- Data exporting was unselected.


-- Dumping structure for table master.spt_monitor
CREATE TABLE IF NOT EXISTS "spt_monitor" );

-- Data exporting was unselected.


-- Dumping structure for table master.spt_values
CREATE TABLE IF NOT EXISTS "spt_values" );

-- Data exporting was unselected.


-- Dumping structure for procedure master.sp_MScleanupmergepublisher
DELIMITER //
CREATE TABLE "sp_MScleanupmergepublisher" )//
DELIMITER ;


-- Dumping structure for procedure master.sp_MSrepl_startup
DELIMITER //
CREATE TABLE "sp_MSrepl_startup" )//
DELIMITER ;


-- Dumping database structure for msdb
CREATE DATABASE IF NOT EXISTS "msdb";
USE "msdb";


-- Dumping structure for function msdb.agent_datetime
DELIMITER //
CREATE TABLE "agent_datetime" )//
DELIMITER ;


-- Dumping structure for table msdb.backupfile
CREATE TABLE IF NOT EXISTS "backupfile" );

-- Data exporting was unselected.


-- Dumping structure for table msdb.backupfilegroup
CREATE TABLE IF NOT EXISTS "backupfilegroup" );

-- Data exporting was unselected.


-- Dumping structure for table msdb.backupmediafamily
CREATE TABLE IF NOT EXISTS "backupmediafamily" );

-- Data exporting was unselected.


-- Dumping structure for table msdb.backupmediaset
CREATE TABLE IF NOT EXISTS "backupmediaset" );

-- Data exporting was unselected.


-- Dumping structure for table msdb.backupset
CREATE TABLE IF NOT EXISTS "backupset" );

-- Data exporting was unselected.


-- Dumping structure for function msdb.ConvertToInt
DELIMITER //
CREATE TABLE "ConvertToInt" )//
DELIMITER ;


-- Dumping structure for function msdb.fn_syscollector_find_collection_set_root
DELIMITER //
CREATE TABLE "fn_syscollector_find_collection_set_root" )//
DELIMITER ;


-- Dumping structure for function msdb.fn_syscollector_get_package_path
DELIMITER //
CREATE TABLE "fn_syscollector_get_package_path" )//
DELIMITER ;


-- Dumping structure for function msdb.fn_syscollector_highest_incompatible_mdw_version
DELIMITER //
CREATE TABLE "fn_syscollector_highest_incompatible_mdw_version" )//
DELIMITER ;


-- Dumping structure for function msdb.fn_syspolicy_get_ps_command
DELIMITER //
CREATE TABLE "fn_syspolicy_get_ps_command" )//
DELIMITER ;


-- Dumping structure for function msdb.fn_syspolicy_is_automation_enabled
DELIMITER //
CREATE TABLE "fn_syspolicy_is_automation_enabled" )//
DELIMITER ;


-- Dumping structure for function msdb.get_principal_id
DELIMITER //
CREATE TABLE "get_principal_id" )//
DELIMITER ;


-- Dumping structure for function msdb.get_principal_sid
DELIMITER //
CREATE TABLE "get_principal_sid" )//
DELIMITER ;


-- Dumping structure for table msdb.logmarkhistory
CREATE TABLE IF NOT EXISTS "logmarkhistory" );

-- Data exporting was unselected.


-- Dumping structure for table msdb.log_shipping_monitor_alert
CREATE TABLE IF NOT EXISTS "log_shipping_monitor_alert" );

-- Data exporting was unselected.


-- Dumping structure for table msdb.log_shipping_monitor_error_detail
CREATE TABLE IF NOT EXISTS "log_shipping_monitor_error_detail" );

-- Data exporting was unselected.


-- Dumping structure for table msdb.log_shipping_monitor_history_detail
CREATE TABLE IF NOT EXISTS "log_shipping_monitor_history_detail" );

-- Data exporting was unselected.


-- Dumping structure for table msdb.log_shipping_monitor_primary
CREATE TABLE IF NOT EXISTS "log_shipping_monitor_primary" );

-- Data exporting was unselected.


-- Dumping structure for table msdb.log_shipping_monitor_secondary
CREATE TABLE IF NOT EXISTS "log_shipping_monitor_secondary" );

-- Data exporting was unselected.


-- Dumping structure for table msdb.log_shipping_primaries
CREATE TABLE IF NOT EXISTS "log_shipping_primaries" );

-- Data exporting was unselected.


-- Dumping structure for table msdb.log_shipping_primary_databases
CREATE TABLE IF NOT EXISTS "log_shipping_primary_databases" );

-- Data exporting was unselected.


-- Dumping structure for table msdb.log_shipping_primary_secondaries
CREATE TABLE IF NOT EXISTS "log_shipping_primary_secondaries" );

-- Data exporting was unselected.


-- Dumping structure for table msdb.log_shipping_secondaries
CREATE TABLE IF NOT EXISTS "log_shipping_secondaries" );

-- Data exporting was unselected.


-- Dumping structure for table msdb.log_shipping_secondary
CREATE TABLE IF NOT EXISTS "log_shipping_secondary" );

-- Data exporting was unselected.


-- Dumping structure for table msdb.log_shipping_secondary_databases
CREATE TABLE IF NOT EXISTS "log_shipping_secondary_databases" );

-- Data exporting was unselected.


-- Dumping structure for view msdb.MSdatatype_mappings