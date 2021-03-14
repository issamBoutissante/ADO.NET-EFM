create database GestionFilms
go
use GestionFilms

--la creation de table Acteur
create table Acteur(
CodeActeur varchar(15) primary key,
Nom varchar(30),
pays varchar(20),
Tel varchar(20)
)

--la creation de table Film
create table Film(
RefFilm varchar(10) primary key,
Titre varchar(20),
Duree int
)

--la creation de table Contrat
create table Contrat(
Num_Contrat int primary key identity,
DateContrat date,
RefFilm varchar(10),
CodeActeur varchar(15),
[Role] varchar(20),
constraint fk_Contrat_Film foreign key(RefFilm) references Film(RefFilm),
constraint fk_Contrat_Acteur foreign key(CodeActeur) references Acteur(CodeActeur)
)
-- remplir Acteur
insert into Acteur values(1,'Boutissante','Marrakech','064653774')
insert into Acteur values(2,'Mazzouz','Marrakech','047234987234')

--remplir Film
insert into Film values('1234','The time',2)
insert into Film values('2235','Avengers',3)

--remplir Contrat
insert into Contrat values('03/13/2021','1234',1,'some role')
insert into Contrat values('03/13/2021','2235',1,'some role 2')
insert into Contrat values('03/13/2021','1234',2,'role de Acteur 2')
insert into Contrat values('03/13/2021','2235',2,'role de Acteur 2')

