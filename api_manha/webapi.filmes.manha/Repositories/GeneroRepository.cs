using System.Data.SqlClient;
using webapi.filmes.manha.Domains;
using webapi.filmes.manha.Interfaces;

namespace webapi.filmes.manha.Repositories
{
    /// <summary>
    /// Classe responsável pelo repositório dos gêneros
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// String de conexão com o banco de dados que recebe os seguintes parâmetros:
        /// Data Source : Nome do servidor
        /// Initial Catalog : Nome do banco de dados
        /// Autenticação:
        ///     - Windows : Integrated Security = true
        ///     - SqlServer: User Id = sa; Pwd = Senha
        /// </summary>
        private string StringConexao = "Data Source = NOTE06-S14 ;initial catalog = Filmes_Manha_API;User Id = sa; pwd=Senai@134";
        

        public void AtualizarIdCorpo(GeneroDomain genero)
        {
                        using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryUpdateByIdc = "UPDATE Genero SET Nome = @novoNome WHERE IdGenero = @IdBuscado";
                
                using (SqlCommand cmd = new SqlCommand(queryUpdateByIdc, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@IdBuscado", genero);
                    cmd.Parameters.AddWithValue("@novoNome", genero.Nome);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        

        public void AtualizarIdUrl(int id, GeneroDomain genero)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryUpdateByUrl = "UPDATE  SET Nome = @novoNome WHERE IdGenero = @IdBuscado";

                using (SqlCommand cmd = new SqlCommand(queryUpdateByUrl, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@IdBuscado", id);
                    cmd.Parameters.AddWithValue("@novoNome", genero.Nome);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public GeneroDomain BuscarPorId(int id)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string querySelectById = "SELECT IdGenero,nome FROM Genero WHERE IdGenero= @IdBuscado";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectById, con))
                {
                    cmd.Parameters.AddWithValue("@IdBuscado", id);

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        GeneroDomain generoBuscado = new GeneroDomain()
                        {
                            IdGenero = Convert.ToInt32(rdr["id"]),
                            Nome = rdr["Nome"].ToString()
                        };

                        return generoBuscado;
                    }
                    else
                    {
                        return null;
                    }

                }
            }
        }

        /// <summary>
        /// Cadastrar um novo gênero
        /// </summary>
        /// <param name="novoGenero">Objeto com as informações que serão cadastradas</param>
        public void Cadastrar(GeneroDomain novoGenero)
        {
            //Declara a conexão passando a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //Declara a query que será executada
                string queryInsert   = "INSERT INTO Genero(Nome) VALUES (@Nome)";

                //Declara o SqlCommand passando a query que será executada e a conexão com o bd
                using (SqlCommand cmd = new SqlCommand(queryInsert,con))
                {
                    // passa o valor do parametro nome
                    cmd.Parameters.AddWithValue("@Nome", novoGenero.Nome);

                    //Abre a conexão com o banco de dados
                    con.Open();

                    //executar a query (queryInsert)
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int IdGenero)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryDelete = "DELETE FROM Genero WHERE IdGenero = @IdGenero ";


                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    cmd.Parameters.AddWithValue(@"IdGenero", IdGenero);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    
                }

            }
        }

        /// <summary>
        /// Listar todos objetos (gêneros)
        /// </summary>
        /// <returns>Lista de objetos (gêneros)</returns>
        public List<GeneroDomain> ListarTodos()
        {
            //Cria uma lista de objetos do tipo gênero
            List<GeneroDomain> listaGeneros = new List<GeneroDomain>();

            //Declara a SqlConnection passando a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //Declara a instrução a ser executada
                string querySelectAll = "SELECT IdGenero, Nome FROM Genero";

                //Abre a conexão com o banco de dados
                con.Open();

                //Declara o SqlDataReader para percorrer a tabela do banco de dados
                SqlDataReader rdr;

                //Declara o SqlCommand passando a query que será executada e a conexão com o bd
                using (SqlCommand cmd = new SqlCommand(querySelectAll,con))
                {
                    //Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    while(rdr.Read())
                    {
                        GeneroDomain genero = new GeneroDomain()
                        {
                            //atribui a propriedade IdGenero o valor recebido no rdr
                            IdGenero = Convert.ToInt32(rdr[0]),

                            //atribui a propriedade Nome o valor recebido no rdr
                            Nome = rdr["Nome"].ToString()
                        };

                        //Adiciona cada objeto dentro da lista
                        listaGeneros.Add(genero);
                    }
                }
            }

            //Retorna a lista de gêneros
            return listaGeneros;
        }
    }
}

