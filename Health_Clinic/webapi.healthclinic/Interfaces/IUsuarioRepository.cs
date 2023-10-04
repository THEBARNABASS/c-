using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
	public interface IUsuarioRepository
	{
		void Cadastrar(UsuarioDomain usuario);

		UsuarioDomain BuscaPorId(Guid id);

		UsuarioDomain BuscaPorEmailESenha(string email,string senha);

		void Deletar(Guid id);

		List<UsuarioDomain> Listar();

		void Atualizar(Guid id, UsuarioDomain usuario);

	}
}
