using webapi.healthclinic.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
	public class MedEspecialidadeRepository : IMedEspecialidadeRepository
	{
		private readonly HealthClinicContext _healthClinicContext;

		public MedEspecialidadeRepository()
		{
			_healthClinicContext = new HealthClinicContext();
		}
		public void Atualizar(Guid id, MedEspecialidadeDomain medE)
		{
			MedEspecialidadeDomain medBuscado = _healthClinicContext.MedEspecialidades.Find(id)!;

			if (medBuscado != null)
			{
				medBuscado.NomeEspecialidae = medBuscado.NomeEspecialidae;
			}

			_healthClinicContext.MedEspecialidades.Update(medBuscado!);

			_healthClinicContext.SaveChanges();
		}

		public MedEspecialidadeDomain BuscarPorId(Guid id)
		{
			return _healthClinicContext.MedEspecialidades.FirstOrDefault(e => e.IdEspecialidade == id)!;
		}

		public void Cadastrar(MedEspecialidadeDomain medE)
		{
			_healthClinicContext.MedEspecialidades.Add(medE);

			_healthClinicContext.SaveChanges();
		}

		public void Deletar(Guid id)
		{
			MedEspecialidadeDomain medBuscado = _healthClinicContext.MedEspecialidades.Find(id)!;

			_healthClinicContext.MedEspecialidades.Remove(medBuscado);

			_healthClinicContext.SaveChanges();
		}

		public List<MedEspecialidadeDomain> Listar()
		{
			return _healthClinicContext.MedEspecialidades.ToList();
		}
	}
}
