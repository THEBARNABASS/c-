using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.Repositories;

namespace senai.inlock.webApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Produces("application/json")]
	public class UsuarioController : ControllerBase
	{
		private IUsuarioReporitory _usuarioRepository;

		public UsuarioController()
		{
			_usuarioRepository = new UsuarioRepository();
		}
		[HttpPost]
		public IActionResult Login(UsuarioDomain usuario)
		{
			try
			{
				UsuarioDomain usuarioBuscado = _usuarioRepository.Login(usuario.Email, usuario.Senha);

				if (usuarioBuscado == null)
				{
					return NotFound("Email ou senha Invalidos");
				}

				var claims = new[]
				{
					new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Jti,usuarioBuscado.IdUsuario.ToString()),
					new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Email,usuarioBuscado.Email),
					new Claim(ClaimTypes.Role,usuarioBuscado.IdTipoUsuario.ToString()),

					new Claim("Claim Personalizada","Valor da Claim Personalizada")
				};

				var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("User-chave-autenticacao-senai.inlock.webApi-dev"));

				var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

		
				var token = new JwtSecurityToken
				(
					
					issuer: "senai.inlock.webApi",

					audience: "senai.inlock.webApi",

					claims: claims,

					expires: DateTime.Now.AddMinutes(5),

					signingCredentials: creds
				);


				return Ok(new
				{

					token = new JwtSecurityTokenHandler().WriteToken(token)
				});
			}
			catch (Exception erro)
			{

				return BadRequest(erro.Message);
			}
		}
	}
}
