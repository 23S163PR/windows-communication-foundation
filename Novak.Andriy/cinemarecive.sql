 --create database cinemadb 
 use cinemadb
CREATE TABLE [Descriptions](
	[Id] INT PRIMARY KEY NOT NULL identity(1,1)
	,[AboutShow] NVARCHAR(MAX)
	,[Actors] NVARCHAR(MAX)
	,[Produsers] NVARCHAR(256)
	,[DurationInMinutes] INT not null
	,[Scenary] NVARCHAR(256)
	,[Genres] NVARCHAR(MAX)
)
CREATE TABLE [Shows](
	[Id] INT PRIMARY KEY NOT NULL identity(1,1)
	,[Title] NVARCHAR(MAX)
	,[DescriptionId] INT 
	,[CinemaHall name] NVARCHAR(128) 
	
	CONSTRAINT fk_Shows_DescriptionId_Descriptions_id 
	FOREIGN KEY ([DescriptionId]) REFERENCES [Descriptions](Id)
)
CREATE TABLE [PerformanceDays](
	[Id] INT PRIMARY KEY NOT NULL identity(1,1)
	,[ DATETIME] DATETIME
	,[ShowId] INT 
	
	CONSTRAINT fk_PerformanceDays_ShowId_Shows_id 
	FOREIGN KEY ([ShowId]) REFERENCES [Shows](Id)
)

--drop database cinemadb


