using CadControleDeEstoque.DOMINIO.Interfaces;

namespace CadControleDeEstoque.SERVICOS.Servicos
{
    public class UsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
    }
}
