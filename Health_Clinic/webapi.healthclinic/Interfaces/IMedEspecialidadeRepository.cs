using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
	public interface IMedEspecialidadeRepository
	{
		void Cadastrar(MedEspecialidadeDomain medE);

		void Deletar(Guid id);

		List<MedEspecialidadeDomain> Listar();

		MedEspecialidadeDomain BuscarPorId(Guid id);

		void Atualizar(Guid id, MedEspecialidadeDomain medE);
	}
}
