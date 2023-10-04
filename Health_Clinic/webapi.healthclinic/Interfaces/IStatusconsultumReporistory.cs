using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
	public interface IStatusconsultumReporistory
	{
		void Cadastrar(StatusconsultumDomain statusconsultum);

		void Deletar(Guid id);

		List<StatusconsultumDomain> Listar();

		void Atualizar(Guid id, StatusconsultumDomain statusconsultum);
	}
}
