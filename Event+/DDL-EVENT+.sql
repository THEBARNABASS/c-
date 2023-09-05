--DDL database definition language

--criar banco de dados

CREATE DATABASE [Event+ Manha];

USE [Event+ Manha];

--criar tabelas

--Criado
CREATE TABLE TipoUsuario
(
	IdTipoUsuario INT PRIMARY KEY IDENTITY,
	TipoUsuario VARCHAR(20) NOT NULL UNIQUE
);
--Criado
CREATE TABLE Instituicao
(
	IdInstituicao INT PRIMARY KEY IDENTITY,
	CNPJ CHAR(14) NOT NULL UNIQUE,
	NomeFantasia VARCHAR(20) NOT NULL,
	Endereco VARCHAR(30) NOT NULL UNIQUE
);
--Criado
CREATE TABLE TiposDeEvento
(
	IdTipoDeEvento INT PRIMARY KEY IDENTITY,
	TituloTipoEvento VARCHAR(50) NOT NULL UNIQUE
);
--Criado
CREATE TABLE Usuario
(
	IdUsuario INT PRIMARY KEY IDENTITY,
	IdTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario(IdTipoUsuario),
	Nome VARCHAR(50) NOT NULL,
	Email VARCHAR(256) NOT NULL UNIQUE,
	Senha VARCHAR(100) NOT NULL
);

--Criado
 CREATE TABLE Evento
(
	IdEvento INT PRIMARY KEY IDENTITY,
	IdInstituicao INT FOREIGN KEY REFERENCES Instituicao(IdInstituicao)NOT NULL,
	IdTipoDeEvento INT FOREIGN KEY REFERENCES TiposDeEvento(IdTipoDeEvento)NOT NULL,
	NomeEvento VARCHAR(50) NOT NULL UNIQUE,
	Descricao VARCHAR(1500) NOT NULL UNIQUE,
	DataEvento DATE NOT NULL ,
	HoraEvento TIME NOT NULL 
);
--Criado
 CREATE TABLE PresencaEvento
(
	IdPresencaEvento INT PRIMARY KEY IDENTITY,
	IdEvento INT FOREIGN KEY REFERENCES Evento(IdEvento)  NOT NULL,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario)NOT NULL,
	Situacao BIT DEFAULT(0),
	
);
--Criado
CREATE TABLE ComentarioEvento
(
	IdComentario INT PRIMARY KEY IDENTITY,
	IdEvento INT FOREIGN KEY REFERENCES Evento(IdEvento)  NOT NULL,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario)NOT NULL,
	Descricao VARCHAR(256) NOT NULL,
	Exibe BIT DEFAULT(0)

)