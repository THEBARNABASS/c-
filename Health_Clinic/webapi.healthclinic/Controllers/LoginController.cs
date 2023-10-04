using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

using webapi.event_.manha.ViewModels;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;
using webapi.healthclinic.Repositories;

namespace webapi.event_.manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]

    public class LoginController : ControllerBase
    {


        private readonly IUsuarioRepository _usuarioRepository;

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post(LoginViewModel usuario) 
        {

            try
            {

                UsuarioDomain usuarioEncontrado = _usuarioRepository.BuscaPorEmailESenha(usuario.Email!, usuario.Senha!);

                if (usuarioEncontrado == null)
                {
                    return StatusCode(401,"Email ou senha inválidos");

                }

                //Logica do token

                var claims = new[]
                {

                    new Claim(JwtRegisteredClaimNames.Email, usuarioEncontrado.Email!),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioEncontrado.IdUsuario.ToString()),
                    new Claim(ClaimTypes.Role, usuarioEncontrado.TipoUsuario_fk!.NomeTipoUsuario!)

                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("senai-health-clinic-chave-autenticacao-webapi-dev"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var Token = new JwtSecurityToken
                    (
                        issuer: "webapi.healthclinic",

                        audience: "webapi.healthclinic",

                        claims: claims,

                        expires: DateTime.Now.AddMinutes(5),

                        signingCredentials: creds
                    );

                return Ok(new
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(Token),
                });


            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }
    }
}
