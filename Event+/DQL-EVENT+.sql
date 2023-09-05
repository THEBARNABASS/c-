
--DQL - Criar script para consulta exibindo os seguintes dados 

--Usar JOIN

--Nome do usuário
--Tipo do usuário
--Data do evento
--Local do evento (Instituição)
--Titulo do evento
--Nome do evento
--Descrição do evento
--Situação do evento
--Comentário do evento
--qoz3d2z

--

SELECT [Event+ Manha].dbo.Usuario.Nome AS 'Nome do Usuario',

[Event+ Manha].dbo.TipoUsuario.TipoUsuario AS 'Tipo do Usuario',

[Event+ Manha].dbo.Evento.DataEvento AS 'Data do Evento',

CONCAT( [Event+ Manha].dbo.Instituicao.NomeFantasia,[Event+ Manha].dbo.Instituicao.Endereco) as 'local',

[Event+ Manha].dbo.TiposDeEvento.TituloTipoEvento AS 'Tipo de Evento',

[Event+ Manha].dbo.Evento.NomeEvento AS 'Nome do Evento',

[Event+ Manha].dbo.Evento.Descricao	AS 'Descricao do Evento',

CASE WHEN [Event+ Manha].dbo.PresencaEvento.Situacao = 1 
THEN 'CONFIRMADA' ELSE 'NAO CONFIRMADA' END	 AS 'Situacao',

[Event+ Manha].dbo.ComentarioEvento.Descricao AS 'Comentario'

FROM Evento

JOIN TiposDeEvento		ON	 Evento.IdTipoDeEvento = TiposDeEvento.IdTipoDeEvento

JOIN Instituicao		ON	Evento.IdEvento = Instituicao.IdInstituicao

JOIN PresencaEvento		ON	 Evento.IdEvento = PresencaEvento.IdEvento

JOIN Usuario			ON	PresencaEvento.IdUsuario = Usuario.IdUsuario

JOIN TipoUsuario		ON	TipoUsuario.IdTipoUsuario = Usuario.IdTipoUsuario

JOIN ComentarioEvento	ON	 ComentarioEvento.IdUsuario = Usuario.IdUsuario
