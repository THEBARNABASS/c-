using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.filmes.manha.Domains;
using webapi.filmes.manha.Interfaces;
using webapi.filmes.manha.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace webapi.filmes.manha.Controllers
{
    //Define que a rota de uma requisição será no seguinte formato
    //dominio/api/nomeController
    //ex: http://localhost:5000/api/genero
    [Route("api/[controller]")]

    //Define que é um controlador de API
    [ApiController]

    //Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    //Método controlador que herda da controller base
    //Onde será criado os Endpoints (rotas)
    public class FilmeController : ControllerBase
    {
        private IFilmeRepository _filmeRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _generoRepository para que haja referência aos métodos no repositório
        /// </summary>
        public FilmeController()
        {
            _filmeRepository = new FilmeRepository();
        }

        /// <summary>
        /// Endpoint que aciona o método ListarTodos no repositório 
        /// </summary>
        /// <returns>Resposta para o usúário(front-end)</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                //Cria uma lista que recebe os dados da requisição
                List<FilmeDomain> listaGeneros = _filmeRepository.ListarTodos();

                //Retorna a lista no formato JSON com o status code Ok(200)
                return Ok(listaGeneros);

            }
            catch (Exception erro)
            {
                //Retorna um status code BadRequest(400) e a mensagem do erro
                return BadRequest(erro.Message);
            }
        }
        /// <summary>
        /// Endpoint que adiciona metodo deletar
        /// </summary>
        /// <param name="id">objto recebido formato json</param>
        /// <returns>resposta para lo usuario</returns>
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                //traz um id para deletar
                _filmeRepository.Deletar(id);

                // statuscode (204)
                return StatusCode(204);
            }
            catch (Exception erro)
            {
                //Retorna um status code 400(BadRequest) e a mensagem do erro
                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// Endpoint que aciona o método de cadastro de gênero
        /// </summary>
        /// <param name="novoFilme">Objeto recebido na requisição</param>
        /// <returns>Resposta para o usuário(front-end)</returns>
        [HttpPost]
        public IActionResult Post(FilmeDomain novoFilme)
        {
            try
            {
                //Fazendo a chamada para o método cadastrar passando o objeto como parâmetro
                _filmeRepository.Cadastrar(novoFilme);

                //Retorna um status code 201 - Created
                return StatusCode(201);
            }
            catch (Exception erro)
            {
                //Retorna um status code 400(BadRequest) e a mensagem do erro
                return BadRequest(erro.Message);
            }
        }
        [HttpGet(("{id}"))]

        public IActionResult BuscaPorId(int id)
        {
            try
            {
                FilmeDomain filmeBuscado = _filmeRepository.BuscarPorId(id);

                if (filmeBuscado == null)
                {
                    return NotFound("nada encontrado");
                }
                return Ok(filmeBuscado);
            }
            catch (Exception erro)
            {

                //Retorna um status code 400(BadRequest) e a mensagem do erro
                return BadRequest(erro.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, FilmeDomain Filme)
        {
            try
            {
                _filmeRepository.AtualizarIdUrl(id, Filme);
                return StatusCode(200);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }
        [HttpPut]
        public IActionResult Put(FilmeDomain Filme)
        {
            try
            {
                _filmeRepository.AtualizarIdCorpo(Filme);
                return StatusCode(200);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }

    }
}
