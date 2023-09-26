using webapi.inlock.codeFirst.manha.Domains;

namespace webapi.inlock.codeFirst.manha.Interfaces
{
	public interface IEstudioRepository
	{
		List<Estudio> Listar();

		Estudio BuscaPorId(Guid id);

		void Cadastrar(Estudio estudio);

		void Atualizar(Guid id, Estudio estudio);

		void Deletar(Guid id);
	}
}
