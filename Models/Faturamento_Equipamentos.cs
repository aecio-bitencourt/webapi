using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Faturamento_Equipamentos
    {
        [Key]
        [Column(TypeName = "string(5)")]
        [Required]
        public string Cliente { get; set; }

        [Column(TypeName = "string(50)")]
        [Required]
        public string Contrato { get; set; }

        [Required]
        public DateTime Mes { get; set; }

        [Column(TypeName = "string(50)")]
        [Required]
        public string Produto { get; set; }

        [Column(TypeName = "string(50)")]
        [Required]
        public string NumeroSerie { get; set; }

        [Required]
        public double VariacaoCambial { get; set; }

        [Column(TypeName = "string(100)")]
        public string? Departamento { get; set; }

        [Column(TypeName = "string(50)")]
        public string? IPMaquina { get; set; }

        [Required]
        public double CustoPaginaMono { get; set; }

        [Required]
        public double CustoPaginaColor { get; set; }

        [Required]
        public double TaxaFixa { get; set; }

        [Required]
        public int ContadorAcumMono { get; set; }

        [Required]
        public int ContadorAcumColor { get; set; }

        [Required]
        public int PaginasMesMono { get; set; }

        [Required]
        public int PaginasMesColor { get; set; }

        [Required]
        public double ValorTotal { get; set; }
    }
}