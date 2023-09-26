using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
	public interface IEstudioRepository
	{
		/// <summary>
		/// Cadastrar um novo estudio
		/// </summary>
		/// <param name="novoEstudio">estudio que será cadastrado</param>
		public EstudioDomain Cadastrar(EstudioDomain novoEstudio);

		/// <summary>
		/// Listar todos os estudios cadastrados
		/// </summary>
		/// <returns>Lista com os estudios</returns>
		List<EstudioDomain> ListarTodos();
	}
}
