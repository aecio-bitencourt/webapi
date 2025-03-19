using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Faturamento_Equipamentos
    {
        [Key]
        public required string Cliente { get; set; }
        public required string Contrato { get; set; }
        public required DateTime Mes { get; set; }
        public required string Produto { get; set; }
        public required string NumeroSerie { get; set; }
        public required double VariacaoCambial { get; set; }
        public string? Departamento { get; set; }
        public string? IPMaquina { get; set; }
        public required double CustoPaginaMono { get; set; }
        public required double CustoPaginaColor { get; set; }
        public required double TaxaFixa { get; set; }
        public required int ContadorAcumMono { get; set; }
        public required int ContadorAcumColor { get; set; }
        public required int PaginasMesMono { get; set; }
        public required int PaginasMesColor { get; set; }
        public required double ValorTotal { get; set; }
    }
}
