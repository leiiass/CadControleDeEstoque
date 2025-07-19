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
        public AuthController(TokenServico tokenServico)
        {
            _tokenServico = tokenServico;
        }

        [HttpPost]
        public IActionResult Login([FromBody] UsuarioLogin usuario)
        {

        }
    }
}
