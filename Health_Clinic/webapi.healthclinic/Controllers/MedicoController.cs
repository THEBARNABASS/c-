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
	public class MedicoController : ControllerBase
	{
		private IMedicoRepository _medicoRepository { get; set; }

		public MedicoController()
		{
			_medicoRepository = new MedicoRepository();
		}

		[HttpGet]
		public IActionResult Get()
		{
			try
			{
				return Ok(_medicoRepository.Litar());
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
				return Ok(_medicoRepository.BuscarPorId(id));
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
				_medicoRepository.Deletar(id);

				return NoContent();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPost]
		public IActionResult Post(MedicoDomain medico)
		{
			try
			{
					_medicoRepository.Cadastrar(medico);

				return StatusCode(201);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPut("{id}")]
		public IActionResult Put(Guid id, MedicoDomain medico)
		{
			try
			{
					_medicoRepository.Atualizar(id, medico);

				return NoContent();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}
