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
	public class TipoUsuarioController : ControllerBase
	{
		private ITipoUsuarioRepository _tipoUsuarioRepository { get; set; }

		public TipoUsuarioController()
		{
			_tipoUsuarioRepository = new TipoUsuarioRepository();
		}

		[HttpGet]
		public IActionResult Get()
		{
			try
			{
				return Ok(_tipoUsuarioRepository.Listar());
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
				return Ok(_tipoUsuarioRepository.BuscarPorId(id));
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
				_tipoUsuarioRepository.Deletar(id);

				return NoContent();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPost]
		public IActionResult Post(TipoUsuarioDomain tipoUsuario)
		{
			try
			{
				_tipoUsuarioRepository.Cadastrar(tipoUsuario);

				return StatusCode(201);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPut("{id}")]
		public IActionResult Put(Guid id, TipoUsuarioDomain tipoUsuario)
		{
			try
			{
				_tipoUsuarioRepository.Atualizar(id, tipoUsuario);

				return NoContent();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}
