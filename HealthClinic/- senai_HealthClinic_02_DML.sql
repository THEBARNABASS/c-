Use Health_Clinic;
--
INSERT INTO TipoUsuario ( NomeTipoUsuario)
VALUES ('Paciente'),
       ('Médico'),
	   ('Administrador');

INSERT INTO Clinica (IdEndereco, Nome, CNPJ, HoraAbertura,HoraFechamento,RazaoSocial)
VALUES (3,'HealthClinic A', '16477238474982', '6:00','20:00','HealthClinic'),
       (2,'HealthClinic B', '35463748953763', '6:00','20:00','HealthClinic');

INSERT INTO consulta (IdConsulta, IdPaciente, IdMedico,IdStatusConsulta, DataAgendamento, Descricao)
VALUES (1, 1, 5 ,1, '20230820', 'Consulta de rotina'),
       (2, 2, 6 ,2, '20230821', 'Acompanhamento pós-operatório');
--
INSERT INTO Endereco (CEP, Logradouro, Nº, Bairro, Cidade, Estado)
VALUES ('09278478', 'Rua das Flores', '123', 'Centro', 'São Paulo', 'SP'),
       ('93748390', 'Avenida das Palmeiras', '456', 'Jardins', 'Rio de Janeiro', 'RJ');
--
INSERT INTO MedEspecialidade (NomeEspecialidae)
VALUES ('Cardiologia'),
       ('Dermatologia');

INSERT INTO Medico (CRM,nome,IdUsuario,IdClinica,IdEspecialidade)
VALUES ('doqmed','Dr. João Silva', 6,6,2),
       ('joert','Dra. Maria Santos', 5,7,1);

INSERT INTO pacientes (Idpaciente, IdUsuario,DataNascimento, Telefone, RG, CPF)
VALUES (1,6,'1990-05-15', '1198765432', '1234567', '12345678901'),
       (2,5,'1985-10-20', '2299998888', '9876543', '98765432109');

INSERT INTO UsuarioHealthClinic (IdTipoUsuario,IdEndereco,Email,Senha)
VALUES (1,2,'paciente@email.com','123'),
       (2,3,'medico@email.com','123'),
	   (3,2,'adm@adm.com','adm134');

INSERT INTO Statusconsulta (TItuloConsulta)
VALUES ('em andamento'),('finalizada');

