using CadControleDeEstoque.DOMINIO.Modelos;
using CadControleDeEstoque.SERVICOS.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadControleDeEstoque.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioServico _usuarioServico;
        public UsuarioController(UsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        [HttpGet("{id}")]
        public OkObjectResult ObterPorId(int id)
        {
            _usuarioServico.ObterPorId(id);
            return Ok("");
        }

        [HttpPost]
        public CreatedResult Criar([FromBody] Usuario usuario)
        {
            _usuarioServico.Criar(usuario);
            return Created();
        }

        [HttpPatch("{id}")]
        public NoContentResult Atualizar(int id, [FromBody] Usuario usuario)
        {
            _usuarioServico.Atualizar(id, usuario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public NoContentResult Remover(int id)
        {
            _usuarioServico.Remover(id);
            return NoContent(); 
        }
    }
}
