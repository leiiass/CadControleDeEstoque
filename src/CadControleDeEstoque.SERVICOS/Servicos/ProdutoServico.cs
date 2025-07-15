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
    }
}
