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
	public class ConsultumController : ControllerBase
	{
		private IConsultumRepository _consultumRepository { get; set; }

		public ConsultumController()
		{
			_consultumRepository = new ConsultumRepository();
		}

		[HttpGet]
		public IActionResult Get()
		{
			try
			{
				return Ok(_consultumRepository.Listar());
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
				return Ok(_consultumRepository.BuscarPorId(id));
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
				_consultumRepository.Deletar(id);

				return NoContent();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPost]
		public IActionResult Post(ConsultumDomain consultum)
		{
			try
			{
				_consultumRepository.Cadastrar(consultum);

				return StatusCode(201);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPut("{id}")]
		public IActionResult Put(Guid id, ConsultumDomain consultum)
		{
			try
			{
				_consultumRepository.Atualizar(id, consultum);

				return NoContent();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}
