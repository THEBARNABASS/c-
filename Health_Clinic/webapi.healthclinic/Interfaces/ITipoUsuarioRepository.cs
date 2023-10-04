using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
	public interface ITipoUsuarioRepository
	{
		void Cadastrar(TipoUsuarioDomain tipoUsuario);

		void Deletar(Guid id);

		List<TipoUsuarioDomain> Listar();

		TipoUsuarioDomain BuscarPorId(Guid id);

		void Atualizar(Guid id, TipoUsuarioDomain tiposUsuario);

	}
}
