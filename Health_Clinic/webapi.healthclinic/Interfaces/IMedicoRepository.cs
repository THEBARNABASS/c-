using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
	public interface IMedicoRepository
	{
		void Cadastrar(MedicoDomain medico);

		void Deletar(Guid id);

		List<MedicoDomain> Litar();

		MedicoDomain BuscarPorId(Guid id);

		void Atualizar(Guid id, MedicoDomain medico);
	}
}
