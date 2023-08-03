USE EXERCICIO_1_1;


INSERT INTO Pessoa(Nome,CNH)
VALUES 
	('CARLAO','12345678909'),
	('DUDU',  '98712360909'),
	('JEFF',  '35264839118')

INSERT INTO Email(IdPessoa,Endereco)
VALUES 
	(1,'CARLAO69@YAHOO.COM'),
	(4,'NCDNCUIC@YAHOO.COM'),
	(5,'NQONGOTWANE@YAHOO.COM')

INSERT INTO Telefone(IdPessoa,Numero)
VALUES 
	(1,'11764530213'),
	(4,'09484303482'),
	(5,'14839580213')

SELECT

	Pessoa.Nome AS Cliente,
	Pessoa.CNH ,
	Telefone.Numero as Telefone,
	Email.Endereco as Email
FROM
	Pessoa
LEFT JOIN
	Telefone ON Pessoa.IdPessoa = Telefone.IdPessoa
LEFT JOIN
	Email ON Pessoa.IdPessoa = Email.IdPessoa

--DELETE FROM
--	Pessoa
--WHERE 
--	Pessoa.IdPessoa IN(8,9)

	--select * from Pessoa