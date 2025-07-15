using CadControleDeEstoque.DOMINIO.Interfaces;
using CadControleDeEstoque.DOMINIO.Modelos;
using CadControleDeEstoque.INFRAESTRUTURA.BancoDeDados;

namespace CadControleDeEstoque.INFRAESTRUTURA.Repositorios
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly Context _context;
        public CategoriaRepositorio(Context context)
        {
            _context = context;
        }

        public List<Categoria> ObterTodas()
        {
           return _context.Categorias.ToList();
        }

        public Categoria ObterPorId(int id)
        {
            return _context.Categorias.FirstOrDefault(x => x.Id == id);
        }

        public void Criar(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Categoria categoria)
        {
           var categoriaAhSerAtualizada = _context.Categorias.FirstOrDefault(x=> x.Id == id)
                ?? throw new Exception($"Categoria não encontrada com {id}.");
            categoriaAhSerAtualizada.Nome = categoria.Nome;
            _context.Categorias.Update(categoriaAhSerAtualizada);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var categoriaAhSerRemovida = _context.Categorias.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception($"Categoria não encontrada com {id}.");

            _context.Categorias.Remove(categoriaAhSerRemovida);
            _context.SaveChanges();
        }
    }
}
