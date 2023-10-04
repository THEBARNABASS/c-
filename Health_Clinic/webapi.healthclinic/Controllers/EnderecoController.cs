using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;
using webapi.healthclinic.Repositories;

namespace webapi.healthclinic.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Produces("application/json")]
	public class EnderecoController : ControllerBase
	{
		private IEnderecoRepository _enderecoRepository { get; set; }

		public EnderecoController()
		{
			_enderecoRepository = new EnderecoRepository();
		}

		[HttpGet]
		public IActionResult Get()
		{
			try
			{
				return Ok(_enderecoRepository.Listar());
			}
			catch (Exception e)
			{

				return BadRequest(e.Message);
			}
		}


		[HttpGet("{id}")]
		public IActionResult GetById(Guid id)
		{
			try
			{
				return Ok(_enderecoRepository.BuscarPorId(id));
			}
			catch (Exception e)
			{

				return BadRequest(e.Message);
			}
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(Guid id)
		{
			try
			{
				_enderecoRepository.Deletar(id);

				return NoContent();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPost]
		public IActionResult Post(EnderecoDomain endereco)
		{
			try
			{
				_enderecoRepository.Cadastrar(endereco);

				return StatusCode(201);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPut("{id}")]
		public IActionResult Put(Guid id, EnderecoDomain endereco)
		{
			try
			{
				_enderecoRepository.Atualizar(id, endereco);

				return NoContent();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}
