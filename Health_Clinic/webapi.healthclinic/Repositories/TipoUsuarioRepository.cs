using webapi.healthclinic.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
	public class TipoUsuarioRepository : ITipoUsuarioRepository
	{
		private readonly HealthClinicContext _healthClinicContext;

		public TipoUsuarioRepository()
		{ 
			_healthClinicContext = new HealthClinicContext();
		}

		public void Atualizar(Guid id, TipoUsuarioDomain tiposUsuario)
		{
			TipoUsuarioDomain tipoUsuarioBuscado = _healthClinicContext.TipoUsuarios.Find(id)!;

			if (tipoUsuarioBuscado != null)
			{
				tipoUsuarioBuscado.NomeTipoUsuario = tipoUsuarioBuscado.NomeTipoUsuario;
			}

			_healthClinicContext.TipoUsuarios.Update(tipoUsuarioBuscado!);

			_healthClinicContext.SaveChanges();
		}

		public TipoUsuarioDomain BuscarPorId(Guid id)
		{
			return _healthClinicContext.TipoUsuarios.FirstOrDefault(e => e.IdTipoDeUsuario == id)!;
		}

		public void Cadastrar(TipoUsuarioDomain tipoUsuario)
		{

			_healthClinicContext.TipoUsuarios.Add(tipoUsuario);

			_healthClinicContext.SaveChanges();

		}

		public void Deletar(Guid id)
		{
			TipoUsuarioDomain tipoUsuarioBuscado = _healthClinicContext.TipoUsuarios.Find(id)!;

			_healthClinicContext.TipoUsuarios.Remove(tipoUsuarioBuscado);

		    _healthClinicContext.SaveChanges();
		}

		public List<TipoUsuarioDomain> Listar()
		{
			return _healthClinicContext.TipoUsuarios.ToList();
		}
	}
}
