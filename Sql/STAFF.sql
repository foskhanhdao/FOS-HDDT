CREATE TABLE Staff
(
staffcode varchar(20) DEFAULT '' NOT NULL,
staffname varchar(50) DEFAULT '' NOT NULL,
staffsex  varchar(1) DEFAULT '' NOT NULL,
customerbirthday datetime NOT NULL,
staffphone  varchar(20) DEFAULT '' NOT NULL,
staffdeparmentcode varchar(20) DEFAULT '' NOT NULL,
staffpositioncode varchar(20) DEFAULT '' NOT NULL,
staffsalarycode varchar(20) DEFAULT '' NOT NULL,




PRIMARY KEY (staffcode)
)