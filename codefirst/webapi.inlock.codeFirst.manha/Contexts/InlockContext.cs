using Microsoft.EntityFrameworkCore;
using webapi.inlock.codeFirst.manha.Domains;

namespace webapi.inlock.codeFirst.manha.Contexts
{
	public class InlockContext: DbContext
	{
		//Define as estidades do banco de dados
		public DbSet<Estudio> Estudio { get ; set ; }
		public DbSet<Jogo> Jogo { get; set; }
		public DbSet<TiposUsuario> TipoUsuario { get; set; }
		public DbSet<Usuario> Usuario { get; set; }



		/// <summary>
		/// Define as opcoes de construcao do banco(String Conexao)
		/// </summary>
		/// <param name="optionsBuilder">Objeto com as configuracoes definidas</param>
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=NOTE06-S14; Database=inlock_games_codeFirst_manha;User Id = sa; pwd = Senai@134; TrustServerCertificate=True;");

			base.OnConfiguring(optionsBuilder);
		}
	}
}
