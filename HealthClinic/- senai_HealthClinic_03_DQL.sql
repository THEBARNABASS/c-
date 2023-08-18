	   --select * from UsuarioHealthClinic
	   --select * from Endereco
	   --select * from clinica
	   --select * from Pacientes
	   --select * from Medico
	   --select * from Statusconsulta
	   --select * from TipoUsuario
	   --select * from Consulta

	   SELECT *
FROM Consulta AS C
INNER JOIN Pacientes AS P ON C.idPaciente = P.IdPaciente
INNER JOIN Medico AS M ON C.idMedico = M.IdMedico
INNER JOIN Statusconsulta AS SC ON C.idStatusConsulta = SC.IdStatusConsulta
INNER JOIN UsuarioHealthClinic AS UHC ON P.idUsuario = UHC.IdUsuario
INNER JOIN Endereco AS E ON UHC.idEndereco = E.IdEndereco
INNER JOIN clinica AS CL ON CL.IdClinica = CL.IdClinica
INNER JOIN TipoUsuario AS TU ON UHC.idTipoUsuario = TU.IdTipoDeUsuario;
