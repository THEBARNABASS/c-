using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
	public interface IClinicaRepository
	{
		void Cadastrar(ClinicaDomain consultum);

		void Deletar(Guid id);

		List<ClinicaDomain> Listar();

		ClinicaDomain BuscarPorId(Guid id);

		void Atualizar(Guid id, ClinicaDomain clinica);

	}
}
