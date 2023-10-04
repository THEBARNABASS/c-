using webapi.healthclinic.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
	public class StatusconsultumRepository : IStatusconsultumReporistory
	{
		private readonly HealthClinicContext _healthClinicContext;

		public StatusconsultumRepository()
		{
			_healthClinicContext = new HealthClinicContext();
		}
		public void Atualizar(Guid id, StatusconsultumDomain statusconsultum)
		{
			StatusconsultumDomain StatusconsultumBuscado = _healthClinicContext.Statusconsulta.Find(id)!;

			if (StatusconsultumBuscado != null)
			{
				StatusconsultumBuscado.TituloConsulta = StatusconsultumBuscado.TituloConsulta;
			}

			_healthClinicContext.Statusconsulta.Update(StatusconsultumBuscado!);

			_healthClinicContext.SaveChanges();
		}

		public void Cadastrar(StatusconsultumDomain statusconsultum)
		{
			_healthClinicContext.Statusconsulta.Add(statusconsultum);

			_healthClinicContext.SaveChanges();
		}

		public void Deletar(Guid id)
		{
			StatusconsultumDomain StatusconsultumBuscado = _healthClinicContext.Statusconsulta.Find(id)!;
			

			_healthClinicContext.Statusconsulta.Remove(StatusconsultumBuscado);

			_healthClinicContext.SaveChanges();
		}

		public List<StatusconsultumDomain> Listar()
		{
			return _healthClinicContext.Statusconsulta.ToList();
		}
	}
}
