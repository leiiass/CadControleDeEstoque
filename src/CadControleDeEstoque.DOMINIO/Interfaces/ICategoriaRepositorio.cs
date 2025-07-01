using CadControleDeEstoque.DOMINIO.Modelos;

namespace CadControleDeEstoque.DOMINIO.Interfaces
{
    public interface ICategoriaRepositorio
    {
        public List<Categoria> ObterTodas();
        public Categoria ObterPorId(int id);
        public void Criar(Categoria categoria);
        public void Atualizar(int id, Categoria categoria);
        public void Remover(int id);
    }
}
