﻿using CadControleDeEstoque.DOMINIO.Modelos;

namespace CadControleDeEstoque.DOMINIO.Interfaces
{
    public interface IUsuarioRepositorio
    {
        //public List<Usuario> ObterTodos();
        public Usuario ObterPorId(int id);
        public void Criar(Usuario usuario);
        public void Atualizar(int id, Usuario usuario);
        public void Remover(int id);
    }
}
