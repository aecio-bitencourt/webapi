namespace API.Dtos.Saldos_Estoque
{
    public class Saldos_EstoqueDto
    {
        public  string? Produto { get; set; }
        public  string? Almoxarifado { get; set; }
        public string? Filial { get; set; }
        public double? Saldo { get; set; }
        public double? Saldo_Terceiros { get; set; }
        public decimal? Custo { get; set; }
        public required double Empenho { get; set; }
        public double? Pendente { get; set; }
        public DateTime? Data_Ult_Mov { get; set; }
    }
}
