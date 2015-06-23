create database cinema
use cinema
 
create Table [Description](
	[Id] int not null identity(1, 1) primary key,
	[AboutShow] nvarchar(512) not null,
	[Actors] nvarchar(512) not null,
	[Produsers] nvarchar(512) not null,
	[DurationInMinutes] int not null,
	[Scenery] nvarchar(512) not null
)

create Table [Shows](
	[Id] int not null identity(1, 1) primary key,
	[Title] nvarchar(512) not null,
	[DescriptionId] int not null,
	[CinemaHallName] nvarchar(512) not null,
	
	constraint fk_show_descriptionId_description_id
	foreign key ([DescriptionId]) references [Description]([Id]),
)


create Table [PerformanceDays](
	[Id] int not null identity(1, 1) primary key,
	[Date] DateTime not null,
	[ShowId] int not null,

	constraint fk_performanceDays_showId_show_id
	foreign key ([ShowId]) references [Shows]([Id]),
)