using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
	public interface IJogoRepository
	{
		/// <summary>
		/// Cadastrar um novo jogo
		/// </summary>
		/// <param name="novoJogo">Jogo que será cadastrado</param>
		public JogoDomain Cadastrar(JogoDomain novoJogo);

		/// <summary>
		/// Listar todos os jogos cadastrados
		/// </summary>
		/// <returns>Lista com os jogos</returns>
		List<JogoDomain> ListarTodos();
	}
}
