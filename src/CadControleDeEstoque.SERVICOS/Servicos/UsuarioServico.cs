using CadControleDeEstoque.DOMINIO.Interfaces;
using CadControleDeEstoque.DOMINIO.Modelos;

namespace CadControleDeEstoque.SERVICOS.Servicos
{
    public class UsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public Usuario ObterPorId(int id)
        {
            return _usuarioRepositorio.ObterPorId(id);
        }

        public void Criar(Usuario usuario)
        {
            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
            _usuarioRepositorio.Criar(usuario);
        }

        public void Atualizar(int id, Usuario usuario)
        {
            _usuarioRepositorio.Atualizar(id, usuario);
        }

        public void Remover(int id)
        {
            _usuarioRepositorio.Remover(id);
        }

        public Usuario ObterPorEmail(string email)
        {
            return _usuarioRepositorio.ObterPorEmail(email);
        }

    }
}
