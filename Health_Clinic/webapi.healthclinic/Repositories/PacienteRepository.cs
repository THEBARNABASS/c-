using webapi.healthclinic.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
	public class PacienteRepository : IPacienteRepository
	{
		private readonly HealthClinicContext _healthClinicContext;

		public PacienteRepository()
		{
			_healthClinicContext = new HealthClinicContext();
		}

		public void Atualizar(Guid id, PacienteDomain paciente)
		{
			PacienteDomain PacienteBuscado = _healthClinicContext.Pacientes.Find(id)!;

			if (PacienteBuscado != null)
			{
				PacienteBuscado.Nome = paciente.Nome;
			}

			_healthClinicContext.Pacientes.Update(PacienteBuscado!);

			_healthClinicContext.SaveChanges();
		}

		public PacienteDomain BuscarPorId(Guid id)
		{
			return _healthClinicContext.Pacientes.FirstOrDefault(e => e.IdPaciente == id)!;
		}

		public void Cadastrar(PacienteDomain paciente)
		{
			_healthClinicContext.Pacientes.Add(paciente);

			_healthClinicContext.SaveChanges();
		}

		public void Deletar(Guid id)
		{
			PacienteDomain PacienteBuscado = _healthClinicContext.Pacientes.Find(id)!;

			_healthClinicContext.Pacientes.Remove(PacienteBuscado);

			_healthClinicContext.SaveChanges();
		}

		public List<PacienteDomain> Listar()
		{
			return _healthClinicContext.Pacientes.ToList();
		}
	}
}
