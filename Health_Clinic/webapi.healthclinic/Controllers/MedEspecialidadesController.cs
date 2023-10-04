using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;
using webapi.healthclinic.Repositories;

namespace webapi.healthclinic.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MedEspecialidadesController : ControllerBase
	{
		private IMedEspecialidadeRepository _medEspecialidadeRepository { get; set; }

		public MedEspecialidadesController()
		{
			_medEspecialidadeRepository = new MedEspecialidadeRepository();
		}

		[HttpGet]
		public IActionResult Get()
		{
			try
			{
				return Ok(_medEspecialidadeRepository.Listar());
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
				return Ok(_medEspecialidadeRepository.BuscarPorId(id));
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
				_medEspecialidadeRepository.Deletar(id);

				return NoContent();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPost]
		public IActionResult Post(MedEspecialidadeDomain medE)
		{
			try
			{
					_medEspecialidadeRepository.Cadastrar(medE);

				return StatusCode(201);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPut("{id}")]
		public IActionResult Put(Guid id, MedEspecialidadeDomain medE)
		{
			try
			{
				_medEspecialidadeRepository.Atualizar(id, medE);

				return NoContent();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}
