using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Itens_Notas
    {
        [Key]
        [Column(TypeName = "string(9)")]
        public string? Nota { get; set; }

        [Column(TypeName = "string(15)")]
        public string? Produto { get; set; }

        public double? Quantidade { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Preco_Unitario { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Custo { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Custo_Dol { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Filial { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Almoxarifado { get; set; }

        [Column(TypeName = "string(10)")]
        public string? Pedido { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Preco_Total { get; set; }

        public double? Saldo_Anterior { get; set; }

        public double? Saldo_Atual { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Custo_Atual_Cru { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Custo_Atual_Dol { get; set; }

        public DateTime? Data_Nota { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Codigo_Movimento { get; set; }

        [Column(TypeName = "string(5)")]
        public string? Cliente_Fornecedor { get; set; }

        [Column(TypeName = "string(1)")]
        public string? Tipo { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Serie { get; set; }

        [Column(TypeName = "string(10)")]
        public string? Centro_de_Custo { get; set; }

        [Column(TypeName = "string(4)")]
        public string? Tipo_Produto { get; set; }
    }
}