USE EXERCICIO_1_2;
GO

INSERT INTO Empresa(Nome)
VALUES ('YOR')
INSERT INTO Empresa(Nome)
VALUES ('TUY')

INSERT INTO CLIENTE(Nome,CPF)
VALUES ('YORY','23465712391')

INSERT INTO CLIENTE(Nome,CPF)
VALUES ('YANKY','23673788891')

INSERT INTO VEICULO(IdCliente,IdEmpresa,Nome)
VALUES (1,1,'TIGUAN')

INSERT INTO VEICULO(IdCliente,IdEmpresa,Nome)
VALUES (2,1,'BMW')

SELECT * from Empresa;

SELECT * from CLIENTE;

SELECT * from VEICULO;