using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Requisicoes_PecasSuprimentos
    {
        [Key]
        public required int ID { get; set; }
        
        [Column (TypeName = "string(100)")]
        public required string Numero_Serie { get; set; }

        [Column (TypeName = "string(50)")]
        public string? Equipamento { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Suprimento { get; set; }
        
        public int? Usuario { get; set; }

        [Column (TypeName = "string(5)")]
        public string? Cliente { get; set; }

        [Column (TypeName = "string(1)")]
        public string? Situacao { get; set; }  

        public double? Quantidade { get; set; }

        public DateTime? DataHoraAbertura { get; set; }

        public DateTime? DataFaturamento { get; set; }

        [Column (TypeName = "string(50)")]
        public string? Pedido { get; set; }

        [Column (TypeName = "string(50)")]
        public string? Nota { get; set; }

        [Column (TypeName = "string(3)")]
        public string? Filial { get; set; }

        public DateTime? DataPedido { get; set; }

        [Column (TypeName = "string(50)")]
        public string? Contrato { get; set; }

        [Column (TypeName = "string(30)")]
        public string? EmailContato { get; set; }

    }
}
