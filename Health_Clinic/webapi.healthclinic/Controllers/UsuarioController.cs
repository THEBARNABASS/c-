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

	public class UsuarioController : ControllerBase
	{

		private IUsuarioRepository _usuarioRepository;

		public UsuarioController()
		{
			_usuarioRepository = new UsuarioRepository();
		}

		[HttpPost]
		public IActionResult Post(UsuarioDomain usuario)
		{
			try
			{
				_usuarioRepository.Cadastrar(usuario);

				return StatusCode(201);
			}
			catch (Exception e)
			{

				return BadRequest(e.Message);
			}
		}

		[HttpGet]
		public IActionResult Get()
		{
			try
			{
				return Ok(_usuarioRepository.Listar());
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
				return Ok(_usuarioRepository.BuscaPorId(id));
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
				_usuarioRepository.Deletar(id);

				return NoContent();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}


		[HttpPut("{id}")]
		public IActionResult Put(Guid id, UsuarioDomain usuario)
		{
			try
			{
				_usuarioRepository.Atualizar(id, usuario);

				return NoContent();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}



	}
}
