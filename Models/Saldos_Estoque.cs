using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Saldos_Estoque
    {
        [Key]
        [Column (TypeName = "string(15)")]
        public string? Produto { get; set; }

        [Column(TypeName = "string(15)")]
        public string? Almoxarifado { get; set; }

        [Column(TypeName = "string(15)")]
        public string? Filial { get; set; }
        public double? Saldo { get; set; }
        public double? Saldo_Terceiros { get; set; }
        public decimal? Custo { get; set; }
        public double Empenho { get; set; }
        public double? Pendente { get; set; }
        public DateTime? Data_Ult_Mov { get; set; }
    }
}
