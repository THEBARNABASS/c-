using webapi.healthclinic.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
	public class EnderecoRepository : IEnderecoRepository
	{
		private readonly HealthClinicContext _healthClinicContext;

		public EnderecoRepository()
		{
			_healthClinicContext = new HealthClinicContext();
		}
		public void Atualizar(Guid id, EnderecoDomain endereco)
		{
			EnderecoDomain EnderecoBuscado = _healthClinicContext.Enderecos.Find(id)!;

			if (EnderecoBuscado != null)
			{
				EnderecoBuscado.Cep = EnderecoBuscado.Cep;
			}

			_healthClinicContext.Enderecos.Update(EnderecoBuscado!);

			_healthClinicContext.SaveChanges();
		}

		public EnderecoDomain BuscarPorId(Guid id)
		{
			return _healthClinicContext.Enderecos.FirstOrDefault(e => e.IdEndereco == id)!;
		}

		public void Cadastrar(EnderecoDomain consultum)
		{
			_healthClinicContext.Enderecos.Add(consultum);

			_healthClinicContext.SaveChanges();
		}

		public void Deletar(Guid id)
		{
			EnderecoDomain EnderecoBuscado = _healthClinicContext.Enderecos.Find(id)!;

			_healthClinicContext.Enderecos.Remove(EnderecoBuscado);

			_healthClinicContext.SaveChanges();
		}

		public List<EnderecoDomain> Listar()
		{
			return _healthClinicContext.Enderecos.ToList();
		}
	}
}
