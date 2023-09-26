CREATE DATABASE Filmes_Manha_API
USE Filmes_Manha_API

CREATE TABLE Genero
(
	IdGenero INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50)
)

CREATE TABLE Filme
(
	IdFilme INT PRIMARY KEY IDENTITY,
	IdGenero INT FOREIGN KEY REFERENCES Genero(IdGenero),
	Titulo VARCHAR(50)
)

INSERT INTO Genero (Nome)
VALUES
('Fantasia'),
('Comedia'),
('Romance')

INSERT INTO Filme (IdGenero,Titulo)
VALUES
(1,'Merlim'),
(2,'Dois Doidoes em Havard'),
(3,'Festa no ceu')


SELECT * FROM Filme
SELECT * FROM genero

CREATE TABLE Usuario
(
	IdUsuario INT PRIMARY KEY IDENTITY,
	Email VARCHAR(50)NOT NULL UNIQUE,
	Senha VARCHAR(50)NOT NULL,
	Permissao varchar(20)NOT NULL
)

INSERT INTO Usuario 
VALUES  ('Barnabass@tor.xyz','1234zxcv','Administrador'),
		('Comum@cmm.com','cmm@134','Comum')

SELECT * FROM Usuario