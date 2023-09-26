using webapi.inlock.db.First.manha.Domains;

namespace webapi.inlock.db.First.manha.Interfaces
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
