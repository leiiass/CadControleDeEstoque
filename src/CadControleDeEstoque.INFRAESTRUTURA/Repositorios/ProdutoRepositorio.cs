using CadControleDeEstoque.DOMINIO.Interfaces;
using CadControleDeEstoque.DOMINIO.Modelos;
using CadControleDeEstoque.INFRAESTRUTURA.BancoDeDados;

namespace CadControleDeEstoque.INFRAESTRUTURA.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly Context _context;
        public ProdutoRepositorio(Context context)
        {
            _context = context;
        }

        public List<Produto> ObterTodos()
        {
            return _context.Produtos.ToList();
        }

        public Produto ObterPorId(int id)
        {
            return _context.Produtos.FirstOrDefault(x => x.Id == id);
        }

        public void Criar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Produto produto)
        {
            var produtoAhSerAtualizado = _context.Produtos.FirstOrDefault(x =>x.Id == id)
                ?? throw new Exception($"Produto com id {id} não encontrado.");

            produtoAhSerAtualizado.Nome = produto.Nome;
            produtoAhSerAtualizado.Quantidade = produto.Quantidade;
            produtoAhSerAtualizado.Fornecedor = produto.Fornecedor;
            produtoAhSerAtualizado.CodigoDoProduto = produto.CodigoDoProduto;
            produtoAhSerAtualizado.Categoria = produto.Categoria;

            _context.Produtos.Update(produtoAhSerAtualizado);
            _context.SaveChanges();

        }

        public void Remover(int id)
        {
            var produtoAhSerRemovido = _context.Produtos.FirstOrDefault(x=>x.Id == id)
                ?? throw new Exception($"Produto com id {id} não encontrado.");
            _context.Produtos.Remove(produtoAhSerRemovido);
            _context.SaveChanges();
        }
    }
}
