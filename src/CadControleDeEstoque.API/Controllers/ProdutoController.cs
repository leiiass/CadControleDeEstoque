using CadControleDeEstoque.DOMINIO.Modelos;
using CadControleDeEstoque.SERVICOS.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace CadControleDeEstoque.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoServico _produtoServico;
        public ProdutoController(ProdutoServico produtoServico)
        {
            _produtoServico = produtoServico;
        }

        [HttpGet]
        public OkObjectResult ObterTodos()
        {
            _produtoServico.ObterTodos();
            return Ok("");
        }

        [HttpGet("{id}")]
        public OkObjectResult ObterPorId(int id)
        {
            _produtoServico.ObterPorId(id);
            return Ok("");
        }

        [HttpPost]
        public CreatedResult Criar([FromBody] Produto produto)
        {
            _produtoServico.Criar(produto);
            return Created();
        }

        [HttpPatch("{id}")]
        public NoContentResult Atualizar(int id, [FromBody] Produto produto)
        {
            _produtoServico.Atualizar(id, produto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public NoContentResult Remover(int id)
        {
            _produtoServico.Remover(id);
            return NoContent();
        }
    }
}
