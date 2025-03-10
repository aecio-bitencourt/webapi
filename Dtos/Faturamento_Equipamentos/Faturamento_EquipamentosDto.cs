using System.ComponentModel.DataAnnotations.Schema;

namespace API.Dtos.Faturamento_Equipamentos
{
    public class Faturamento_EquipamentosDto
    {
        public string Cliente { get; set; } 
        public string Contrato { get; set; } 
        public DateTime Mes { get; set; }
        public string Produto { get; set; } 
        public string NumeroSerie { get; set; } 
        public double VariacaoCambial { get; set; }
        public string? Departamento { get; set; }
        public string? IPMaquina { get; set; }
        public double CustoPaginaMono { get; set; }
        public double CustoPaginaColor { get; set; }
        public double TaxaFixa { get; set; }
        public int ContadorAcumMono { get; set; }
        public int ContadorAcumColor { get; set; }
        public int PaginasMesMono { get; set; }
        public int PaginasMesColor { get; set; }
        public double ValorTotal { get; set; }
    }
}
