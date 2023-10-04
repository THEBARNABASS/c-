using webapi.event_.manha.Utils;
using webapi.healthclinic.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
	public class UsuarioRepository : IUsuarioRepository
	{
		private readonly HealthClinicContext _healthClinicContext;

		public UsuarioRepository()
		{ 
			_healthClinicContext = new HealthClinicContext();
		}

		public void Atualizar(Guid id, UsuarioDomain usuario)
		{
			UsuarioDomain userBuscado = _healthClinicContext.Usuario.Find(id)!;

			if (userBuscado != null)
			{
				userBuscado.Email = userBuscado.Email;
				userBuscado.Senha = userBuscado.Senha;

			}

			_healthClinicContext.Usuario.Update(userBuscado!);

			_healthClinicContext.SaveChanges();
		}

		public UsuarioDomain BuscaPorEmailESenha(string email, string senha)
		{
			try
			{
				UsuarioDomain usuarioBuscado = _healthClinicContext.Usuario
					.Select(u => new UsuarioDomain
					{

						IdUsuario = u.IdUsuario,
						Email = u.Email,
						Senha = u.Senha,
						TipoUsuario_fk = new TipoUsuarioDomain
						{
							IdTipoDeUsuario = u.IdTipoUsuario,
							NomeTipoUsuario = u.TipoUsuario_fk.NomeTipoUsuario
						}

					}).FirstOrDefault(u => u.Email == email)!;

				if (usuarioBuscado != null)
				{
					bool confere = Criptografia.CompararHAsh(senha, usuarioBuscado.Senha!);

					if (confere)
					{
						return usuarioBuscado;
					}

				}

				return null!;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public UsuarioDomain BuscaPorId(Guid id)
		{
			try
			{

				UsuarioDomain usuario = _healthClinicContext.Usuario
					.Select(u => new UsuarioDomain
					{

						IdUsuario = u.IdUsuario,
						Email = u.Email,
						Senha = u.Senha,
						TipoUsuario_fk = new TipoUsuarioDomain
						{
							IdTipoDeUsuario = u.IdTipoUsuario
						}

					}).FirstOrDefault(u => u.IdUsuario == id)!;

				if (usuario != null)
				{
					return usuario;
				}
				return null!;

			}
			catch (Exception)
			{

				throw;
			}
		}

		public void Cadastrar(UsuarioDomain usuario)
		{
			usuario.Senha = Criptografia.GerarHash(usuario.Senha!);

			_healthClinicContext.Usuario.Add(usuario);

			_healthClinicContext.SaveChanges();
		}

		public void Deletar(Guid id)
		{
			UsuarioDomain UsuarioBuscado = _healthClinicContext.Usuario.Find(id)!;

			_healthClinicContext.Usuario.Remove(UsuarioBuscado);

			_healthClinicContext.SaveChanges();
		}

		public List<UsuarioDomain> Listar()
		{
			return _healthClinicContext.Usuario.ToList();
		}

	}
}
