using CadControleDeEstoque.DOMINIO.Interfaces;

namespace CadControleDeEstoque.SERVICOS.Servicos
{
    public class CategoriaServico
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        public CategoriaServico(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }
    }
}
