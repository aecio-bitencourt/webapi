namespace API.Dtos.Itens_Notas
{
    public class Itens_NotasDto
    {
        public string? Nota { get; set; }
        public string? Produto { get; set; }
        public double? Quantidade { get; set; }
        public decimal? Preco_Unitario { get; set; }
        public decimal? Custo { get; set; }
        public decimal? Custo_Dol { get; set; }
        public string? Filial { get; set; }
        public string? Almoxarifado { get; set; }
        public string? Pedido { get; set; }
        public decimal? Preco_Total { get; set; }
        public double? Saldo_Anterior { get; set; }
        public double? Saldo_Atual { get; set; }
        public decimal? Custo_Atual_Cru { get; set; }
        public decimal? Custo_Atual_Dol { get; set; }
        public DateTime? Data_Nota { get; set; }
        public string? Codigo_Movimento { get; set; }
        public string? Cliente_Fornecedor { get; set; }
        public string? Tipo { get; set; }
        public string? Serie { get; set; }
        public string? Centro_de_Custo { get; set; }
        public string? Tipo_Produto { get; set; }
    }
}