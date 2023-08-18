--DDL DATABASE DEFINITION LANGUAGE
Create Database Health_Clinic;

Use Health_Clinic;

Create table TipoUsuario
(
IdTipoDeUsuario Int Primary Key Identity,
NomeTipoUsuario Varchar(20)
)

Create table Statusconsulta
(
IdStatusConsulta Int Primary Key Identity,
TItuloConsulta Varchar(20)
)

Create table MedEspecialidade
(
IdEspecialidade Int Primary Key Identity,
NomeEspecialidae Varchar(20)
)
Create table Endereco
(
IdEndereco Int Primary Key Identity,
CEP char(8),
Estado varchar(50),
Cidade varchar(50),
Bairro varchar(50),
Logradouro varchar(50),
N char(10)
)

Create table UsuarioHealthClinic
(
IdUsuario Int Primary Key Identity,
IdTipoUsuario Int Foreign Key References TipoUsuario,
IdEndereco Int Foreign Key References Endereco,
Email Varchar(20),
Senha varchar(256)
)
Create table Clinica
(
IdClinica Int Primary Key Identity,
IdEndereco Int Foreign Key References Endereco,
Nome varchar(50),
CNPJ char(14),
HoraAbertura time,
HoraFechamento time,
RazaoSocial varchar(50)
)
Create table Medico
(
IdMedico Int Primary Key Identity,
IdUsuario Int Foreign Key References  UsuarioHealthClinic,
IdEndereco Int Foreign Key References Endereco,
IdClinica Int Foreign Key References Clinica,
IdEspecialidade Int Foreign Key References MedEspecialidade,
nome Varchar(50),
CRM varchar(10)
)

CREATE TABLE Pacientes (
    IdPaciente INT PRIMARY KEY Identity,
    IdUsuario INT FOREIGN KEY REFERENCES UsuarioHealthClinic(IdUsuario),
    Nome VARCHAR(100),
    DataNascimento DATE,
    Telefone VARCHAR(20),
    RG VARCHAR(20),
    CPF VARCHAR(14),
   
);
CREATE TABLE Consulta (
    IdConsulta INT PRIMARY KEY,
    IdPaciente INT FOREIGN KEY REFERENCES Pacientes(IdPaciente),
    IdMedico INT FOREIGN KEY REFERENCES Medico(IdMedico),
    IdStatusConsulta INT FOREIGN KEY REFERENCES Statusconsulta(IdStatusConsulta),
    DataAgendamento DATETIME,
    Descricao Varchar(200)
);


