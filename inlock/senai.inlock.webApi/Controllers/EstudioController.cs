using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.Repositories;
using System.Data;

namespace senai.inlock.webApi.Controllers
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
	public class EstudioController : ControllerBase
	{
		     /// <summary>
        /// Objeto _generoRepository que irá receber todos os métodos definidos na interface IGeneroRepository
        /// </summary>
        private IEstudioRepository _estudioRepository {  get; set; }

        /// <summary>
        /// Instancia o objeto _estudioRepository para que haja referência aos métodos no repositório
        /// </summary>
        public  EstudioController()
        {
            _estudioRepository = new EstudioRepository();
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
                List<EstudioDomain> ListaEstudio = _estudioRepository.ListarTodos();

                //Retorna a lista no formato JSON com o status code Ok(200)
                return Ok(ListaEstudio);
                
            }
            catch (Exception erro)
            {
                //Retorna um status code BadRequest(400) e a mensagem do erro
                return BadRequest(erro.Message);
            }
        }

		[HttpPost]
		[Authorize(Roles = "Administrador,Comum")]
		public IActionResult Post(EstudioDomain novoEstudio)
		{
			try
			{
				//Fazendo a chamada para o método cadastrar passando o objeto como parâmetro
				_estudioRepository.Cadastrar(novoEstudio);

				//Retorna um status code 201 - Created
				return StatusCode(201);
			}
			catch (Exception erro)
			{
				//Retorna um status code 400(BadRequest) e a mensagem do erro
				return BadRequest(erro.Message);
			}
		}
	}
}
