using System.ComponentModel.DataAnnotations.Schema;

namespace API.Dtos.Contratos
{
    public class ContratosDto
    {
        public string? Codigo { get; set; }
        public string? Tipo_de_Contrato { get; set; }
        public string? Cliente { get; set; }
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
        public string? Situacao { get; set; }
        public DateTime? Data_Ultima_Nota { get; set; }
        public string? Vendedor { get; set; }
        public string? Vendedor2 { get; set; }
        public string? Filial { get; set; }
        public string? Centro_Custo { get; set; }
        public DateTime? Data_Alteracao { get; set; }
        public string? Ultima_Nota { get; set; }
        public string? Ultimo_Periodo { get; set; }
        public decimal? Valor_Total { get; set; }
        public DateTime? Data_Assinatura { get; set; }
        public DateTime? Data_Reajuste { get; set; }
        public string? Moeda_Reajuste { get; set; }
        public string? Departamento { get; set; }
        public string? NotaRemessaLocacao { get; set; }
        public int? TemVariacaoCambial { get; set; }
        public string? SoftwareBilhetagem { get; set; }
        public double? DolarContrato { get; set; }
        public int? FranquiaMono { get; set; }
        public int? FranquiaColor { get; set; }
        public int? RelatorioClienteInativo { get; set; }
    }
}
