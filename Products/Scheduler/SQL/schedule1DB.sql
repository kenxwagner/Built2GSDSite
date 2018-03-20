CREATE DATABASE schedule1DB;


CREATE TABLE Persons (
    PersonID int,
    LastName varchar(255),
    FirstName varchar(255),
    Address varchar(255),
    City varchar(255), 
	theirState varchar(255)
);

CREATE INDEX idx_lastname
ON Persons (LastName);

CREATE TABLE schedule_calendar (
	DayofWeek varchar(12),
	theMonth varchar(12),
	theYear int
	
	

);