CREATE TABLE Salary
( 

salarycode varchar(20) DEFAULT '' NOT NULL,
salarybasic decimal DEFAULT 0 NOT NULL,
salarycoefficient decimal DEFAULT 0 NOT NULL,

PRIMARY KEY (salarycode)
)