using CadControleDeEstoque.DOMINIO.Interfaces;
using CadControleDeEstoque.DOMINIO.Modelos;

namespace CadControleDeEstoque.SERVICOS.Servicos
{
    public class CategoriaServico
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        public CategoriaServico(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        public List<Categoria> ObterTodas()
        {
            return _categoriaRepositorio.ObterTodas();
        }

        public Categoria ObterPorId(int id)
        {
            return _categoriaRepositorio.ObterPorId(id);
        }

        public void Criar(Categoria categoria)
        {
            _categoriaRepositorio.Criar(categoria);
        }

        public void Atualizar(int id, Categoria categoria)
        {
            _categoriaRepositorio.Atualizar(id, categoria);
        }

        public void Remover(int id)
        {
            _categoriaRepositorio.Remover(id);
        }
    }
}
