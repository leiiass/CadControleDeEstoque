using CadControleDeEstoque.DOMINIO.Interfaces;
using CadControleDeEstoque.DOMINIO.Modelos;

namespace CadControleDeEstoque.SERVICOS.Servicos
{
    public class ProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoServico(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
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
