create database cinema
use cinema
 
create Table [Description](
	[Id] int not null identity(1, 1) primary key,
	[AboutShow] nvarchar(512) not null,
	[Actors] nvarchar(512),
	[Produsers] nvarchar(512),
	[DurationInMinutes] int,
	[Scenery] nvarchar(512)
)

create Table [DescriptionGenres](
	[DescriptionId] int not null identity(1, 1),
	[GenresNama] nvarchar(512) not null,
	
	constraint fk_descriptionGenres_descriptionId_description_id
	foreign key ([DescriptionId]) references [Description]([Id]),
)

create Table [Shows](
	[Id] int not null identity(1, 1) primary key,
	[Title] nvarchar(512) not null,
	[DescriptionId] int,
	[CinemaHollHome] nvarchar(512),
	
	constraint fk_show_descriptionId_description_id
	foreign key ([DescriptionId]) references [Description]([Id]),
)


create Table [PerformanceDays](
	[Id] int not null identity(1, 1) primary key,
	[DateTime] DateTime,
	[ShowId] int,

	constraint fk_performanceDays_showId_show_id
	foreign key ([ShowId]) references [Shows]([Id]),
)



