CREATE DATABASE Health_Clinic_Manha

USE Health_Clinic_Manha;

CREATE TABLE tb_TipoDeUsuario(
	IdTipoDeUsuario INT PRIMARY KEY IDENTITY,
	TituloTidoDeUsuario VARCHAR (100) NOT NULL UNIQUE
);

CREATE TABLE tb_Especialidade(
	IdEspecialidade INT PRIMARY KEY IDENTITY,
	NomeEspecialidade VARCHAR (100) NOT NULL UNIQUE
);

CREATE TABLE tb_Usuario(
	IdUsuario INT PRIMARY KEY IDENTITY,
	IdTipoDeUsuario INT FOREIGN KEY REFERENCES tb_TipoDeUsuario (IdTipoDeUsuario) NOT NULL,
	Email VARCHAR (256) NOT NULL UNIQUE,
	Senha VARCHAR (100) NOT NULL
);

CREATE TABLE tb_Paciente(
	IdPaciente INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES tb_Usuario (IdUsuario) NOT NULL,
	NomePaciente VARCHAR (256) NOT NULL,
	CPF VARCHAR (11) NOT NULL UNIQUE,
	DataNascimento DATE NOT NULL,
	Telefone VARCHAR (20) NOT NULL UNIQUE,
	Endereco VARCHAR (500) NOT NULL
);

CREATE TABLE tb_Clinica(
	IdClinica INT PRIMARY KEY IDENTITY,
	CNPJ VARCHAR (14) NOT NULL UNIQUE,
	RazaoSocial VARCHAR (200) NOT NULL UNIQUE,
	NomeFantasia VARCHAR (200) NOT NULL,
	Endereco VARCHAR (300) NOT NULL,
	HorarioAbertura TIME NOT NULL,
	HoraroFechamento TIME NOT NULL
);

CREATE TABLE tb_Medico (
	IdMedico INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES tb_Usuario (IdUsuario) NOT NULL,
	IdClinica INT FOREIGN KEY REFERENCES tb_Clinica (IdClinica) NOT NULL,
	IdEspecialidade INT FOREIGN KEY REFERENCES tb_Especialidade (IdEspecialidade) NOT NULL,
	NomeMedico VARCHAR (200) NOT NULL,
	CRM VARCHAR (20) NOT NULL UNIQUE
);

CREATE TABLE tb_Consulta(
	IdConsulta INT PRIMARY KEY IDENTITY,
	IdPaciente INT FOREIGN KEY REFERENCES tb_Paciente (IdPaciente) NOT NULL,
	IdMedico INT FOREIGN KEY REFERENCES tb_Medico (IdMedico) NOT NULL,
	DataConsulta DATE NOT NULL,
	HoraConsulta TIME NOT NULL,
	Prontuario TEXT NOT NULL,
	Situacao BIT DEFAULT (1)
);

CREATE TABLE tb_Comentarios(
	IdComentarios INT PRIMARY KEY IDENTITY,
	IdPaciente INT FOREIGN KEY REFERENCES tb_Paciente (IdPaciente) NOT NULL,
	IdConsulta INT FOREIGN KEY REFERENCES tb_Consulta (IdConsulta) NOT NULL,
	Descricao TEXT NOT NULL,
	Situacao BIT DEFAULT (0)
);
