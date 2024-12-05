namespace apiBurguer.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Path_Imagem { get; set; }
        public int Preco { get; set; }
        public string? Descricao { get; set; }
        public string? Ingredientes { get; set; }

    }
}
