using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi.Repositories
{
	public class JogoRepository:IJogoRepository
	{
		private string StringConexao = "Data Source = NOTE06-S14 ;initial catalog = inlock_games_manha;User Id = sa; pwd=Senai@134";
		public void Cadastrar(JogoDomain novoJogo)
		{
			// Declara a conexão passando a string de conexão como parâmetro
			using (SqlConnection con = new SqlConnection(StringConexao))
			{
				// Declara a query que será executada
				string queryInsert = "INSERT INTO Jogo(IdEstudio,Nome) VALUES (@IdEstudio,@Nome)";

				// Declara o SqlCommand cmd passando a query que será executada e a conexão como parâmetros
				using (SqlCommand cmd = new SqlCommand(queryInsert, con))
				{
					// Passa o valor do parâmetro
					cmd.Parameters.AddWithValue("@IdEstudio", novoJogo.IdEstudio);
					cmd.Parameters.AddWithValue("@Nome", novoJogo.Nome);


					// Abre a conexão com o banco de dados
					con.Open();

					// Executa a query
					cmd.ExecuteNonQuery();
				}
			}
		}

		public List<JogoDomain> ListarTodos()
		{
			// Cria uma lista listaFilmes onde serão armazenados os dados
			List<JogoDomain> ListaJogos = new List<JogoDomain>();

			// Declara a SqlConnection con passando a string de conexão como parâmetro
			using (SqlConnection con = new SqlConnection(StringConexao))
			{
				// Declara a instrução a ser executada
				string querySelectAll = "SELECT Jogo.IdJogo,Jogo.Descricao, Jogo.IdEstudio, Jogo.Nome, Estudio.Nome FROM Jogo INNER JOIN Estudio ON Jogo.IdEstudio = Estudio.IdEstudio";

				// Abre a conexão com o banco de dados
				con.Open();

				// Declara o SqlDataReader rdr para percorrer a tabela do banco de dados
				SqlDataReader rdr;

				// Declara o SqlCommand cmd passando a query que será executada e a conexão como parâmetros
				using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
				{
					// Executa a query e armazena os dados no rdr
					rdr = cmd.ExecuteReader();

					// Enquanto houver registros para serem lidos no rdr, o laço se repete
					while (rdr.Read())
					{
						// Instancia um objeto jogo do tipo JogoDomain
						JogoDomain jogo = new JogoDomain()
						{
							// Atribui à propriedade idJogo o valor da coluna "IdJogo" tabela do banco de dados
							IdJogo = Convert.ToInt32(rdr["IdJogo"]),

							// Atribui à propriedade idEstudio o valor "IdEstudio" coluna da tabela do banco de dados
							IdEstudio = Convert.ToInt32(rdr["IdEstudio"]),

							// Atribui à propriedade descricao o valor da coluna "descricao" da tabela do banco de dados
							Descricao = rdr["Descricao"].ToString(),

							// Atribui à propriedade datalancamento o valor da coluna "DataLancamento" da tabela do banco de dados
							DataLancamento = Convert.ToDateTime(rdr["DataLancamento"]),

							// Atribui à propriedade valor o valor da coluna "Valor" da tabela do banco de dados
							valor = Convert.ToInt32(rdr["Valor"]),

							// Atribui à propriedade nome o valor da coluna "Titulo" da tabela do banco de dados
							Nome = rdr["Nome"].ToString(),

							Estudio = new EstudioDomain()
							{
								// Atribui à propriedade IdEstudio o valor "IdEstudio" coluna da tabela do banco de dados
								IdEstudio = Convert.ToInt32(rdr["IdEstudio"]),

								// Atribui à propriedade Nome o valor "Estudio" coluna da tabela do banco de dados
								Nome = rdr["Nome"].ToString()
							}
						};
						// Adiciona o objeto filme criado à lista ListarJogos
						ListaJogos.Add(jogo);
					}
				}
			}
			return ListaJogos;
		}

		JogoDomain IJogoRepository.Cadastrar(JogoDomain novoJogo)
		{
			throw new NotImplementedException();
		}
	}
}
