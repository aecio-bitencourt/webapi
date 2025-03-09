using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Itens_do_Contrato_Nota
    {
        [Key]
        [Column(TypeName = "string(6)")]
        public string? Contrato { get; set; }

        [Column(TypeName = "string(20)")]
        public string? Produto { get; set; }

        [Column(TypeName = "string(20)")]
        public string? Serie { get; set; }

        [Column(TypeName = "double(10)")]
        public double? Qtd { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        public decimal? Preco { get; set; }

        [Column(TypeName = "string(500)")]
        public string? Descricao { get; set; }
    }
}
