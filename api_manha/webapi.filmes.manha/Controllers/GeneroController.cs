using Microsoft.AspNetCore.Authorization;
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

	[Authorize(Roles = "Administrador,Comum")]

	//Método controlador que herda da controller base
	//Onde será criado os Endpoints (rotas)
	public class GeneroController : ControllerBase
    {
        /// <summary>
        /// Objeto _generoRepository que irá receber todos os métodos definidos na interface IGeneroRepository
        /// </summary>
        private IGeneroRepository _generoRepository {  get; set; }

        /// <summary>
        /// Instancia o objeto _generoRepository para que haja referência aos métodos no repositório
        /// </summary>
        public GeneroController()
        {
            _generoRepository = new GeneroRepository();
        }

        /// <summary>
        /// Endpoint que aciona o método ListarTodos no repositório 
        /// </summary>
        /// <returns>Resposta para o usúário(front-end)</returns>
        [HttpGet]
        [Authorize(Roles = "Administrador,Comum")]
        public IActionResult Get()
        {
            try
            {
                //Cria uma lista que recebe os dados da requisição
                List<GeneroDomain> listaGeneros = _generoRepository.ListarTodos();

                //Retorna a lista no formato JSON com o status code Ok(200)
                return Ok(listaGeneros);
                
            }
            catch (Exception erro)
            {
                //Retorna um status code BadRequest(400) e a mensagem do erro
                return BadRequest(erro.Message);
            }
        }

		[HttpPost]
		[Authorize(Roles = "Administrador,Comum")]
		public IActionResult Post(GeneroDomain novoGenero)
		{
			try
			{
				//Fazendo a chamada para o método cadastrar passando o objeto como parâmetro
				_generoRepository.Cadastrar(novoGenero);

				//Retorna um status code 201 - Created
				return StatusCode(201);
			}
			catch (Exception erro)
			{
				//Retorna um status code 400(BadRequest) e a mensagem do erro
				return BadRequest(erro.Message);
			}
		}

		/// <summary>
		/// EndPoint que deleta informacao vinda como JSON
		/// </summary>
		/// <param name="IdGenero"></param>
		/// <returns>o retornoi e a propria exclusao</returns>
		[HttpDelete]
        public IActionResult Delete(int IdGenero)
        {
            try
            {
                //traz um id para deletar
                _generoRepository.Deletar(IdGenero);

                // statuscode (204)
                return StatusCode(204);
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
                GeneroDomain generoBuscado = _generoRepository.BuscarPorId(id);

                if (generoBuscado == null)
                {
                    return NotFound("nada encontrado");
                }
                return Ok(generoBuscado);
            }
            catch (Exception erro)
            {

                //Retorna um status code 400(BadRequest) e a mensagem do erro
                return BadRequest(erro.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, GeneroDomain Genero)
        {
            try
            {
                _generoRepository.AtualizarIdUrl(id, Genero);
                return StatusCode(200);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }
        [HttpPut]
        public IActionResult Put(GeneroDomain Genero)
        {
            try
            {
                _generoRepository.AtualizarIdCorpo(Genero);
                return StatusCode(200);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }





    }
}
