using CadControleDeEstoque.DOMINIO.Modelos;
using CadControleDeEstoque.SERVICOS.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadControleDeEstoque.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenServico _tokenServico;
        private readonly UsuarioServico _usuarioServico;
        public AuthController(TokenServico tokenServico, UsuarioServico usuarioServico)
        {
            _tokenServico = tokenServico;
            _usuarioServico = usuarioServico;
        }

        [HttpPost]
        public IActionResult Login([FromBody] UsuarioLogin usuarioLogin)
        {
            var usuario = _usuarioServico.ObterPorEmail(usuarioLogin.Email);

            if(usuario == null)
            {
                return Unauthorized("Usuário não encontrado.");
            }

            if (!BCrypt.Net.BCrypt.Verify(usuarioLogin.Senha, usuario.Senha))
            {
                return Unauthorized("Senha incorreta.");
            }

            var token = _tokenServico.GerarToken(usuario);
            return Ok(new { token });
        }
    }
}
