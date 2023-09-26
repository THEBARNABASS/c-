using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
	public interface IUsuarioReporitory
	{
		UsuarioDomain Login(string email, string senha);
	}
}
