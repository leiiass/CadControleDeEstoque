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
            var categorias = _categoriaServico.ObterTodas();
            return Ok(categorias);
        }

        [HttpGet("{id}")]
        public OkObjectResult ObterPorId(int id)
        {
            var categoria = _categoriaServico.ObterPorId(id);
            return Ok(categoria);
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
