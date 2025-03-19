using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Itens_do_Contrato_Nota
    {
        [Key]
        public string? Contrato { get; set; }
        public string? Produto { get; set; }
        public string? Serie { get; set; }
        public double? Qtd { get; set; }
        public decimal? Preco { get; set; }
        public string? Descricao { get; set; }
    }
}
