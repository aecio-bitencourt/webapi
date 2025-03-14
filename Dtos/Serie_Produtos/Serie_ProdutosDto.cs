namespace API.Dtos.Serie_Produtos
{
    public class Serie_ProdutosDto
    {
        public string? Produto { get; set; }
        public string? Nota_Entrada { get; set; }
        public DateTime? Data_Nota_Entrada { get; set; }
        public string? Nota_Saida { get; set; }
        public DateTime? Data_Nota_Saida { get; set; }
        public string? Serie_Nota_Saida { get; set; }
        public string? Serie_Nota_Entrada { get; set; }
        public string? Filial { get; set; }
        public string? Cliente { get; set; }
        public string? Fornecedor { get; set; }
        public string? Numero_Serie { get; set; }
        public string? Lote { get; set; }
        public DateTime? Data_Fabricacao { get; set; }
        public string? Pedido { get; set; }
        public string? Almoxarifado { get; set; }
        public string? AlmoxarifadoTRF_Nota_Saida { get; set; }
        public string? Condicoes_Embalagem { get; set; }
        public string? Condicoes_Carcaca { get; set; }
        public string? Limpeza { get; set; }
        public int? Numero_Recarga { get; set; }
        public DateTime? Data_Prevista_Saida { get; set; }
        public string? Partes_Trocadas { get; set; }
        public string? Observacao_Entrada { get; set; }
        public string? Observacao_Saida { get; set; }
        public required int Contador { get; set; }
    }
}
