using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Saldos_Estoque
    {
        [Key]
        public string? Produto { get; set; }
        public string? Almoxarifado { get; set; }
        public string? Filial { get; set; }
        public double? Saldo { get; set; }
        public double? Saldo_Terceiros { get; set; }
        public decimal? Custo { get; set; }
        public double Empenho { get; set; }
        public double? Pendente { get; set; }
        public DateTime? Data_Ult_Mov { get; set; }
    }
}
