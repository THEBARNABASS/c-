using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.Repositories;

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
	public class JogoController : ControllerBase
	{
		private IJogoRepository _jogoRepository { get; set; }

		/// <summary>
		/// Instancia o objeto _jogoRepository para que haja referência aos métodos no repositório
		/// </summary>
		public JogoController()
		{
			_jogoRepository = new JogoRepository();
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
				List<JogoDomain> ListaJogos = _jogoRepository.ListarTodos();

				//Retorna a lista no formato JSON com o status code Ok(200)
				return Ok(ListaJogos);

			}
			catch (Exception erro)
			{
				//Retorna um status code BadRequest(400) e a mensagem do erro
				return BadRequest(erro.Message);
			}
		}

		/// <summary>
		/// Endpoint que aciona o método de cadastro de jogo
		/// </summary>
		/// <param name="novoJogo">Objeto recebido na requisição</param>
		/// <returns>Resposta para o usuário(front-end)</returns>
		[HttpPost]
		public IActionResult Post(JogoDomain novoJogo)
		{
			try
			{
				//Fazendo a chamada para o método cadastrar passando o objeto como parâmetro
				_jogoRepository.Cadastrar(novoJogo);

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
