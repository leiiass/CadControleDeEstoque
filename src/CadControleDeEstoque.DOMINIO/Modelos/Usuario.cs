﻿namespace CadControleDeEstoque.DOMINIO.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string NomeDoEstabelecimento { get; set; }
    }
}
