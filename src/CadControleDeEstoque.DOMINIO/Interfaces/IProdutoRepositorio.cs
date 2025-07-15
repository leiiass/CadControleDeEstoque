using CadControleDeEstoque.DOMINIO.Modelos;

namespace CadControleDeEstoque.DOMINIO.Interfaces
{
    public interface IProdutoRepositorio
    {
        public List<Produto> ObterTodos();
        public Produto ObterPorId(int id);
        public void Criar(Produto produto);
        public void Atualizar(int id, Produto produto);
        public void Remover(int id);
    }
}
