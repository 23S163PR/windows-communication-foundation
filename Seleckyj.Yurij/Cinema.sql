CREATE DATABASE CinemaBokingDB;

drop table PerfomanceDays
drop table DescriptionsGenre
drop table Shows
drop table Descriptions
DROP DATABASE CinemaBokingDB;

use CinemaBokingDB

create table Descriptions (
	Id int not null identity(1, 1)PRIMARY KEY
	,AboutShow nvarchar(MAX) not null
	,Actors nvarchar(MAX) not null
	,Producers nvarchar(MAX) not null
	,DurationInMinutes int not null
	,Scenary nvarchar(MAX) not null
	,Genre nvarchar(MAX) not null
)

create table Shows (
	Id int not null identity(1, 1)PRIMARY KEY,
	,Title DateTime not null not null
	,ShowId int not null 
	,CinemaHallName nvarchar(MAX) not null
	,DescriptionId int not null

	FOREIGN KEY (DescriptionId) REFERENCES Descriptions(Id)
)

create table PerfomanceDays (
	Id int not null identity(1, 1)PRIMARY KEY,
	[DateTime] DateTime,
	ShowsId int,

	FOREIGN KEY (ShowsId) REFERENCES Shows(Id)
)

