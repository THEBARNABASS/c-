using Microsoft.EntityFrameworkCore.Diagnostics;
using webapi.inlock.codeFirst.manha.Contexts;
using webapi.inlock.codeFirst.manha.Domains;
using webapi.inlock.codeFirst.manha.Interfaces;
using webapi.inlock.codeFirst.manha.Utils;

namespace webapi.inlock.codeFirst.manha.Repositories
{
	public class UsuarioRepository : IUsuarioRepository
	{
		private readonly InlockContext ctx;

		/// <summary>
		/// 
		/// </summary>
		public UsuarioRepository()
		{
			ctx = new InlockContext();
		}
		public Usuario BuscarUsuario(string email, string senha)
		{
			try
			{
				Usuario usuarioBuscado = ctx.Usuario.FirstOrDefault(u => u.Email == email);

				if (usuarioBuscado != null)
				{
					bool confere = Criptografria.CompararHash(senha, usuarioBuscado.Senha);
					if (confere)
					{
						return usuarioBuscado;
					}
				}
					return null;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public void Cadastrar(Usuario usuario)
		{
			try
			{
				usuario.Senha = Criptografria.GerarHash(usuario.Senha!);

				ctx.Add(usuario);

				ctx.SaveChanges();
			}
			catch (Exception)
			{

				throw;
			}

		}
	}
}
