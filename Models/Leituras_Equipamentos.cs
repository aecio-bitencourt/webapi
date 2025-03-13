using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Leituras_Equipamentos
    {
        [Key]
        public required string Contrato { get; set; }
        public required string Equipamento { get; set; }
        public required string Numero_Serie { get; set; }
        public required DateTime Data_Leitura { get; set; }
        public string? TipoLeitura { get; set; }
        public string? Informante { get; set; }
        public string? Observacao { get; set; }
        public double? Contador { get; set; }
        public double? ContadorMono { get; set; }
        public double? ContadorColor { get; set; }
    }
}
