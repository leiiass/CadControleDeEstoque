using CadControleDeEstoque.DOMINIO.Interfaces;
using CadControleDeEstoque.DOMINIO.Modelos;

namespace CadControleDeEstoque.SERVICOS.Servicos
{
    public class ProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        public ProdutoServico(IProdutoRepositorio produtoRepositorio, ICategoriaRepositorio categoriaRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
            _categoriaRepositorio = categoriaRepositorio;
        }

        public List<Produto> ObterTodos()
        {
            return _produtoRepositorio.ObterTodos();
        }

        public Produto ObterPorId(int id)
        {
            return _produtoRepositorio.ObterPorId(id);
        }

        public void Criar(Produto produto)
        {
            var categoriaExistente = _categoriaRepositorio.ObterPorNome(produto.Categoria.Nome);

            if(categoriaExistente != null)
            {
                produto.CategoriaId = categoriaExistente.Id;
                produto.Categoria = null;
            }
            else
            {
                _categoriaRepositorio.Criar(produto.Categoria);
                produto.CategoriaId = produto.Categoria.Id;
            }

            _produtoRepositorio.Criar(produto);
        }

        public void Atualizar(int id, Produto produto)
        {
            _produtoRepositorio.Atualizar(id, produto);
        }

        public void Remover(int id)
        {
            _produtoRepositorio.Remover(id);
        }
    }
}
