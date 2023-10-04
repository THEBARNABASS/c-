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
	public class StatusconsultumController : ControllerBase
	{
		private IStatusconsultumReporistory _statusconsultumReporistory { get; set; }

		public StatusconsultumController()
		{
			_statusconsultumReporistory = new StatusconsultumRepository();
		}

		[HttpGet]
		public IActionResult Get()
		{
			try
			{
				return Ok(_statusconsultumReporistory.Listar());
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
				_statusconsultumReporistory.Deletar(id);

				return NoContent();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPost]
		public IActionResult Post(StatusconsultumDomain statusconsultum)
		{
			try
			{
				_statusconsultumReporistory.Cadastrar(statusconsultum);

				return StatusCode(201);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPut("{id}")]
		public IActionResult Put(Guid id, StatusconsultumDomain statusconsultum)
		{
			try
			{
				_statusconsultumReporistory.Atualizar(id, statusconsultum);

				return NoContent();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}
