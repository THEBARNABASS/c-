using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi.Repositories
{
	public class EstudioRepository:IEstudioRepository
	{
		private string StringConexao = "Data Source = NOTE06-S14 ;initial catalog = inlock_games_manha;User Id = sa; pwd=Senai@134";
		public void Cadastrar(EstudioDomain novoEstudio)
		{
			//Declara a conexão passando a string de conexão como parâmetro
			using (SqlConnection con = new SqlConnection(StringConexao))
			{
				//Declara a query que será executada
				string queryInsert = "INSERT INTO Estudio(Nome) VALUES (@Nome)";

				//Declara o SqlCommand passando a query que será executada e a conexão com o bd
				using (SqlCommand cmd = new SqlCommand(queryInsert, con))
				{
					// passa o valor do parametro nome
					cmd.Parameters.AddWithValue("@Nome", novoEstudio.Nome);

					//Abre a conexão com o banco de dados
					con.Open();

					//executar a query (queryInsert)
					cmd.ExecuteNonQuery();
				}
			}
		}

		public List<EstudioDomain> ListarTodos()
		{
			//Cria uma lista de objetos do tipo Estudio
			List<EstudioDomain> ListaEstudios = new List<EstudioDomain>();

			//Declara a SqlConnection passando a string de conexão como parâmetro
			using (SqlConnection con = new SqlConnection(StringConexao))
			{
				//Declara a instrução a ser executada
				string querySelectAll = "SELECT IdEstudio, Nome FROM Estudio";

				//Abre a conexão com o banco de dados
				con.Open();

				//Declara o SqlDataReader para percorrer a tabela do banco de dados
				SqlDataReader rdr;

				//Declara o SqlCommand passando a query que será executada e a conexão com o bd
				using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
				{
					//Executa a query e armazena os dados no rdr
					rdr = cmd.ExecuteReader();

					while (rdr.Read())
					{
						EstudioDomain estudio = new EstudioDomain()
						{
							//atribui a propriedade IdEstudio o valor recebido no rdr
							IdEstudio = Convert.ToInt32(rdr[0]),

							//atribui a propriedade Nome o valor recebido no rdr
							Nome = rdr["Nome"].ToString()
						};

						//Adiciona cada objeto dentro da lista
						ListaEstudios.Add(estudio);
					}
				}
			}

			//Retorna a lista de Estudio
			return ListaEstudios;
		}

		EstudioDomain IEstudioRepository.Cadastrar(EstudioDomain novoEstudio)
		{
			throw new NotImplementedException();
		}
	}
}
