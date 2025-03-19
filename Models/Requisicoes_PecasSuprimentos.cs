using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Requisicoes_PecasSuprimentos
    {
        [Key]
        public required int ID { get; set; }
        public required string Numero_Serie { get; set; }
        public string? Equipamento { get; set; }
        public string? Suprimento { get; set; }
        public int? Usuario { get; set; }
        public string? Cliente { get; set; }
        public string? Situacao { get; set; }  
        public double? Quantidade { get; set; }
        public DateTime? DataHoraAbertura { get; set; }
        public DateTime? DataFaturamento { get; set; }
        public string? Pedido { get; set; }
        public string? Nota { get; set; }
        public string? Filial { get; set; }
        public DateTime? DataPedido { get; set; }
        public string? Contrato { get; set; }
        public string? EmailContato { get; set; }
    }
}
