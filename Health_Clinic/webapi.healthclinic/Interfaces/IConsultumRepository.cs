using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
	public interface IConsultumRepository
	{
		void Cadastrar(ConsultumDomain consultum);

		void Deletar(Guid id);

		List<ConsultumDomain> Listar();

		ConsultumDomain BuscarPorId(Guid id);

		void Atualizar(Guid id, ConsultumDomain consultum);

	}
}
