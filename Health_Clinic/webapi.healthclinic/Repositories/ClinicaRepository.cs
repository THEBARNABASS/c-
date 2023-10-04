using webapi.healthclinic.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
	public class ClinicaRepository : IClinicaRepository
	{
		private readonly HealthClinicContext _healthClinicContext;

		public ClinicaRepository()
		{
			_healthClinicContext = new HealthClinicContext();
		}
		public void Atualizar(Guid id, ClinicaDomain clinica)
		{
			ClinicaDomain ClinicaBuscado = _healthClinicContext.Clinicas.Find(id)!;

			if (ClinicaBuscado != null)
			{
				ClinicaBuscado.RazaoSocial = ClinicaBuscado.RazaoSocial;
			}

			_healthClinicContext.Clinicas.Update(ClinicaBuscado!);

			_healthClinicContext.SaveChanges();
		}

		public ClinicaDomain BuscarPorId(Guid id)
		{
			return _healthClinicContext.Clinicas.FirstOrDefault(e => e.IdClinica == id)!;
		}

		public void Cadastrar(ClinicaDomain clinica)
		{
			_healthClinicContext.Clinicas.Add(clinica);

			_healthClinicContext.SaveChanges();
		}

		public void Deletar(Guid id)
		{
			ClinicaDomain ClinicaBuscado = _healthClinicContext.Clinicas.Find(id)!;

			_healthClinicContext.Clinicas.Remove(ClinicaBuscado);

			_healthClinicContext.SaveChanges();
		}

		public List<ClinicaDomain> Listar()
		{
			return _healthClinicContext.Clinicas.ToList();
		}
	}
}
