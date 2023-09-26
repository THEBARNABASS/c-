using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using webapi.filmes.manha.Domains;
using webapi.filmes.manha.Interfaces;
using webapi.filmes.manha.Repositories;

namespace webapi.filmes.manha.Controllers
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
		public IActionResult Login(UsuarioDomain usuario)
		{
			try
			{
				UsuarioDomain usuarioBuscado = _usuarioRepository.Login(usuario.Email, usuario.Senha);

				if (usuarioBuscado == null)
				{
					return NotFound("Email ou senha Invalidos");
				}

				//caso encontre o usuario , prossegue para a criacao do token

				//1º - Definir as informacoes (Claims) que serao fornecidos no token (PAYLOAD)
				var claims = new[]
				{
					new Claim(JwtRegisteredClaimNames.Jti,usuarioBuscado.IdUsuario.ToString()),
					new Claim(JwtRegisteredClaimNames.Email,usuarioBuscado.Email),
					new Claim(ClaimTypes.Role,usuarioBuscado.Permissao.ToString()),

					//existe a possibilidade de  criar uma claim pernonalizada
					new Claim("Claim Personalizada","Valor da Claim Personalizada")
				};

				//2º - Definir a chave de acesso ao token 
				var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("Filmes-chave-autenticacao-webapi-dev"));
				//3º - Definir as credenciais dom token (HEADER)
				var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

				//4º - gerar token
				var token = new JwtSecurityToken
				(
					//emisor do token
					issuer: "Webapi.filmes.manha",

					//destinatario do token
					audience: "Webapi.filmes.manha",

					//dados definidos nas claims(informacoes)
					claims : claims,

					//tempo de expiracao do token
					expires: DateTime.Now.AddMinutes(5),

					signingCredentials: creds
				);


				return Ok(new{

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
