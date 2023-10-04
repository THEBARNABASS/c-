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
	public class PacienteController : ControllerBase
	{
		private IPacienteRepository _pacienteRepository { get; set; }

		public PacienteController()
		{
			_pacienteRepository = new PacienteRepository();
		}

		[HttpGet]
		public IActionResult Get()
		{
			try
			{
				return Ok(_pacienteRepository.Listar());
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
				return Ok(_pacienteRepository.BuscarPorId(id));
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
				_pacienteRepository.Deletar(id);

				return NoContent();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPost]
		public IActionResult Post(PacienteDomain paciente)
		{
			try
			{
				_pacienteRepository.Cadastrar(paciente);

				return StatusCode(201);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPut("{id}")]
		public IActionResult Put(Guid id, PacienteDomain paciente)
		{
			try
			{
				_pacienteRepository.Atualizar(id, paciente);

				return NoContent();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}

}
