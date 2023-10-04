using webapi.healthclinic.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
	public class MedicoRepository : IMedicoRepository
	{
		private readonly HealthClinicContext _healthClinicContext;

		public MedicoRepository()
		{ 
			_healthClinicContext= new HealthClinicContext();
		}

		public void Atualizar(Guid id, MedicoDomain med)
		{
			MedicoDomain medBuscado = _healthClinicContext.Medicos.Find(id)!;

			if (medBuscado != null)
			{
					medBuscado.Nome = med.Nome;
			}

			_healthClinicContext.Medicos.Update(medBuscado!);

			_healthClinicContext.SaveChanges();
		}

		public MedicoDomain BuscarPorId(Guid id)
		{
			return _healthClinicContext.Medicos.FirstOrDefault(e => e.IdMedico == id)!;
		}

		public void Cadastrar(MedicoDomain medico)
		{

			_healthClinicContext.Medicos.Add(medico);

			_healthClinicContext.SaveChanges();
		}

		public void Deletar(Guid id)
		{
			MedicoDomain medBuscado = _healthClinicContext.Medicos.Find(id)!;

			_healthClinicContext.Medicos.Remove(medBuscado);

			_healthClinicContext.SaveChanges();
		}

		public List<MedicoDomain> Litar()
		{
			return _healthClinicContext.Medicos.ToList();
		}
	}
}
