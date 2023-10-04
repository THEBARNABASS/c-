using webapi.healthclinic.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
	public class ConsultumRepository : IConsultumRepository
	{
		private readonly HealthClinicContext _healthClinicContext;

		public ConsultumRepository()
		{
			_healthClinicContext = new HealthClinicContext();
		}

		public void Atualizar(Guid id, ConsultumDomain consultum)
		{
			ConsultumDomain ConsultaBuscado = _healthClinicContext.Consulta.Find(id)!;

			if (ConsultaBuscado != null)
			{
				ConsultaBuscado.IdConsulta = ConsultaBuscado.IdConsulta;
			}

			_healthClinicContext.Consulta.Update(ConsultaBuscado!);

			_healthClinicContext.SaveChanges();
		}

		public ConsultumDomain BuscarPorId(Guid id)
		{
			return _healthClinicContext.Consulta.FirstOrDefault(e => e.IdConsulta == id)!;
		}

		public void Cadastrar(ConsultumDomain consultum)
		{
			_healthClinicContext.Consulta.Add(consultum);

			_healthClinicContext.SaveChanges();
		}

		public void Deletar(Guid id)
		{
			ConsultumDomain ConsultaBuscado = _healthClinicContext.Consulta.Find(id)!;

			_healthClinicContext.Consulta.Remove(ConsultaBuscado);

			_healthClinicContext.SaveChanges();
		}

		public List<ConsultumDomain> Listar()
		{
			return _healthClinicContext.Consulta.ToList();
		}
	}
}
