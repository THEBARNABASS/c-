using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
	public interface IEnderecoRepository
	{
		void Cadastrar(EnderecoDomain consultum);

		void Deletar(Guid id);

		List<EnderecoDomain> Listar();

		EnderecoDomain BuscarPorId(Guid id);

		void Atualizar(Guid id, EnderecoDomain endereco);
	}
}
