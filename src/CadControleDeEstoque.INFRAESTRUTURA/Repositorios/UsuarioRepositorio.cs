using CadControleDeEstoque.DOMINIO.Interfaces;
using CadControleDeEstoque.DOMINIO.Modelos;
using CadControleDeEstoque.INFRAESTRUTURA.BancoDeDados;

namespace CadControleDeEstoque.INFRAESTRUTURA.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly Context _context;
        public UsuarioRepositorio(Context context)
        {
            _context = context;
        }

        public Usuario ObterPorId(int id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public void Criar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Usuario usuario)
        {
            var usuarioAhSerAtualizado = _context.Usuarios.FirstOrDefault(x=> x.Id == id)
                ?? throw new Exception($"Usuario com Id {id} não encontrado.");

            usuarioAhSerAtualizado.Nome = usuario.Nome;
            usuarioAhSerAtualizado.Email = usuario.Email;
            usuarioAhSerAtualizado.NomeDoEstabelecimento = usuario.NomeDoEstabelecimento;

            _context.Usuarios.Update(usuarioAhSerAtualizado);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var usuarioAhSerRemovido = _context.Usuarios.FirstOrDefault( x => x.Id == id)
                ?? throw new Exception($"Usuario com id {id} não encontrado.");

            _context.Usuarios.Remove(usuarioAhSerRemovido);
            _context.SaveChanges();
        }
    }
}
