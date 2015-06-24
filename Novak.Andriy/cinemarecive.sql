create database cinemadb 
 use cinemadb
CREATE TABLE [Descriptions](
	[Id] INT PRIMARY KEY NOT NULL identity(1,1)
	,[AboutShow] NVARCHAR(MAX) NOT NULL
	,[Actors] NVARCHAR(MAX) NOT NULL
	,[Produsers] NVARCHAR(256) NOT NULL
	,[DurationInMinutes] INT not null
	,[Scenary] NVARCHAR(256) NOT NULL
	,[Genres] NVARCHAR(MAX) NOT NULL
)
CREATE TABLE [Movies](
	[Id] INT PRIMARY KEY NOT NULL identity(1,1)
	,[Title] NVARCHAR(MAX) NOT NULL
	,[DescriptionId] INT NOT NULL
	,[CinemaHallName] NVARCHAR(128) NOT NULL
	
	CONSTRAINT fk_Shows_DescriptionId_Descriptions_id 
	FOREIGN KEY ([DescriptionId]) REFERENCES [Descriptions](Id)
)
CREATE TABLE [PerformanceDays](
	[Id] INT PRIMARY KEY NOT NULL identity(1,1)
	,[Date] DATETIME NOT NULL
	,[MovieId] INT NOT NULL
	
	CONSTRAINT fk_PerformanceDays_ShowId_Movies_id 
	FOREIGN KEY ([MovieId]) REFERENCES [Movies](Id)
)


-- drop database cinemadb


