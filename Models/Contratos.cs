using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API.Models
{
    public class Contratos
    {
        [Key]
        [Column(TypeName = "string(6)")]
        public string? Codigo { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Tipo_de_Contrato { get; set; }

        [Column(TypeName = "string(5)")]
        public string? Cliente { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? Valor { get; set; }
        
        public DateTime? Data_Primeiro_Pagamento { get; set; }

        public double? Dia_do_Vencimento { get; set; }

        public double? Periodo_de_Reajuste { get; set; }

        public double? Taxa_de_Reajuste { get; set; }
        
        public bool Contrato_Assinado { get; set; }
        
        public bool Opcao_de_Compra { get; set; }

        public double? Prazo { get; set; }
        
        public string? Observacao { get; set; }
        
        public DateTime? Data_Inicio { get; set; }
        
        public DateTime? Data_Termino { get; set; }

        [Column(TypeName = "string(1)")]
        public string? Situacao { get; set; }
        
        public DateTime? Data_Ultima_Nota { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Vendedor { get; set; }
        
        [Column(TypeName = "string(3)")]
        public string? Vendedor2 { get; set; }
        
        [Column(TypeName = "string(3)")]
        public string? Filial { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Centro_Custo { get; set; }
        
        public DateTime? Data_Alteracao { get; set; }

        [Column(TypeName = "string(20)")]
        public string? Ultima_Nota { get; set; }

        [Column(TypeName = "string(255)")]
        public string? Ultimo_Periodo { get; set; }

        [Column(TypeName = "decimal(3,2)")]
        public decimal? Valor_Total { get; set; }
        
        public DateTime? Data_Assinatura { get; set; }
        
        public DateTime? Data_Reajuste { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Moeda_Reajuste { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Departamento { get; set; }

        [Column(TypeName = "string(50)")]
        public string? NotaRemessaLocacao { get; set; }

        [Column(TypeName = "int(1)")]
        public int? TemVariacaoCambial { get; set; }

        [Column(TypeName = "string(50)")]
        public string? SoftwareBilhetagem { get; set; }

        public double? DolarContrato { get; set; }
        
        public int? FranquiaMono { get; set; }
        
        public int? FranquiaColor { get; set; }

        [Column(TypeName = "int(1)")]
        public int? RelatorioClienteInativo { get; set; }
    }
}
