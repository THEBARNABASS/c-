using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
	public interface IPacienteRepository
	{
		void Cadastrar(PacienteDomain paciente);

		void Deletar(Guid id);

		List<PacienteDomain> Listar();

		PacienteDomain BuscarPorId(Guid id);

		void Atualizar(Guid id, PacienteDomain paciente);
	}
}
