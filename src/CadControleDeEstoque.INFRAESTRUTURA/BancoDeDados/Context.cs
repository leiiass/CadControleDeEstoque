﻿using CadControleDeEstoque.DOMINIO.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CadControleDeEstoque.INFRAESTRUTURA.BancoDeDados
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
