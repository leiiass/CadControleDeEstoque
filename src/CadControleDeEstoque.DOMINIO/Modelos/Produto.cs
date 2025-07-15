namespace CadControleDeEstoque.DOMINIO.Modelos
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fornecedor { get; set; }
        public int Quantidade { get; set; }
        public string CodigoDoProduto { get; set; }
        public Categoria Categoria { get; set; }
    }
}
