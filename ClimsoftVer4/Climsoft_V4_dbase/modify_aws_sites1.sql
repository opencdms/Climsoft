ALTER TABLE `aws_sites`
	ADD COLUMN `FilePrefix` VARCHAR(50) NULL DEFAULT NULL AFTER `InputFile`,
	ADD COLUMN `chkPrefix` TINYINT(1) NULL DEFAULT '0' AFTER `FilePrefix`;