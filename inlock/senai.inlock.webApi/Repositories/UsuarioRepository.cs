using System.Data.SqlClient;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;

namespace senai.inlock.webApi.Repositories
{
	public class UsuarioRepository : IUsuarioReporitory
	{ 
		private string StringConexao = "Data Source = NOTE06-S14 ;initial catalog = inlock_games_manha;User Id = sa; pwd=Senai@134";
		public UsuarioDomain Login(string email, string senha)
		{
			using (SqlConnection con = new SqlConnection(StringConexao))
			{
				string queryLogin = "SELECT IdUsuario,Email,IdTipoUsuario FROM Usuario WHERE Email = @Email AND Senha = @Senha";

				con.Open();

				using (SqlCommand cmd = new SqlCommand(queryLogin,con))
				{
					cmd.Parameters.AddWithValue("@Email",email);
					cmd.Parameters.AddWithValue("@Senha",senha);

					SqlDataReader rdr = cmd.ExecuteReader();

					if (rdr.Read())
					{
						UsuarioDomain usuario = new UsuarioDomain
						{
							IdUsuario = Convert.ToInt32(rdr["IdUsuario"]),

							Email = rdr["Email"].ToString(),

							IdTipoUsuario = rdr["IdTipoUsuario"].ToString()
						};
						return usuario;
					}
				}return null;
			}
		}
	}
}
