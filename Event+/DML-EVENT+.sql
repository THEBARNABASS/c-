--DML DATA MANIPULATION LANGUAGE

USE [Event+ Manha];

--Inserir dados nas tabelas

INSERT INTO TipoUsuario(TipoUsuario) VALUES
('Administrador'),('Comum');

INSERT INTO TiposDeEvento(TituloTipoEvento) VALUES
('SQL-Server');

INSERT INTO Instituicao(CNPJ,NomeFantasia,Endereco) VALUES
('12312334534509','Rua Niteroi 180','DevSchool');

INSERT INTO Usuario(IdTipoUsuario,Nome,Email,Senha) VALUES
(1,'Bjor','Admin@admin.com','amd@134');

INSERT INTO Evento(IdTipoDeEvento,IdInstituicao,NomeEvento,Descricao,DataEvento,HoraEvento) VALUES
(1,1,'Introducao ao Banco de Dados SQL Server','Aprenda conceitos basicos do SQL Server','23-08-10','10:00:00');

INSERT INTO PresencaEvento(IdUsuario,IdEvento) VALUES
(1,1);

INSERT INTO ComentarioEvento(IdEvento,IdUsuario,Descricao,Exibe) VALUES
(1,1,'Execelente Evento,professores tchops!',1);
 
