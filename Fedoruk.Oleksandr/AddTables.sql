create database CinemaF
use CinemaF
 
create Table Descriptions(
	Id int not null identity(1, 1) primary key,
	AboutShow nvarchar(512),
	Actors nvarchar(512),
	Produsers nvarchar(512),
	DurationInMinutes int,
	Scenery nvarchar(512)
)

create Table Shows(
	Id int not null identity(1, 1) primary key,
	Title nvarchar(512),
	DescriptionId int,
	CinemaHallName nvarchar(512),
	
	foreign key (DescriptionId) references Description(Id)
)

create Table PerformanceDays(
	Id int not null identity(1, 1) primary key,
	[Date] DateTime,
	ShowId int,

	foreign key (ShowId) references Shows(Id)
)