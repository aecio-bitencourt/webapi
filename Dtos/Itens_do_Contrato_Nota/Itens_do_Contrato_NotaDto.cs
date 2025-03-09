using System.ComponentModel.DataAnnotations.Schema;

namespace API.Dtos.Itens_do_Contrato_Nota
{
    public class Itens_do_Contrato_NotaDto
    {
        public string? Contrato { get; set; }
        public string? Produto { get; set; }
        public string? Serie { get; set; }
        public double? Qtd { get; set; }
        public decimal? Preco { get; set; }
        public string? Descricao { get; set; }
    }
}
