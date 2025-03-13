namespace API.Dtos.Produtos
{
    public class ProdutosDto
    {
        public string? Codigo { get; set; }
        public string? Descricao { get; set; }
        public string? Fabricante { get; set; }
        public string? Tipo_Produto { get; set; }
        public double? Estoque_Minimo { get; set; }
        public double? Estoque_Maximo { get; set; }
        public string? Tabela_Fabricante { get; set; }
        public string? Numero_Nota_Ultima { get; set; }
        public DateTime? Data_Nota_Ultima { get; set; }
        public string? Modelo { get; set; }
        public int? Durabilidade { get; set; }
    }
}
