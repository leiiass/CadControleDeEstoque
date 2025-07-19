using CadControleDeEstoque.DOMINIO.Modelos;
using CadControleDeEstoque.SERVICOS.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadControleDeEstoque.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly CategoriaServico _categoriaServico;
        public CategoriaController(CategoriaServico categoriaServico)
        {
            _categoriaServico = categoriaServico;
        }

        [HttpGet]
        public OkObjectResult ObterTodas()
        {
            _categoriaServico.ObterTodas();
            return Ok("");
        }

        [HttpGet("{id}")]
        public OkObjectResult ObterPorId(int id)
        {
            _categoriaServico.ObterPorId(id);
            return Ok("");
        }

        [HttpPost]
        public CreatedResult Criar([FromBody] Categoria categoria)
        {
            _categoriaServico.Criar(categoria);
            return Created();
        }

        [HttpPatch("{id}")]
        public NoContentResult Atualizar(int id, [FromBody] Categoria categoria)
        {
            _categoriaServico.Atualizar(id, categoria);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public NoContentResult Remover(int id)
        {
            _categoriaServico.Remover(id);
            return NoContent();
        }
    }
}
