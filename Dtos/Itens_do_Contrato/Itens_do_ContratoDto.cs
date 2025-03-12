using System.ComponentModel.DataAnnotations.Schema;

namespace API.Dtos.Itens_do_Contrato
{
    public class Itens_do_ContratoDto
    {
        public string? Contrato { get; set; }
        public string? Produto { get; set; }
        public string? Serie { get; set; }
        public string? Observacao { get; set; }
        public string? Endereco { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? CEP { get; set; }
        public double? Qtd { get; set; }
        public decimal? Preco { get; set; }
        public string? Franquia { get; set; }
        public string? Qtd_Copias_Revisao { get; set; }
        public string? Val_excedente_Copias { get; set; }
        public string? Vu_Revelador { get; set; }
        public string? Vu_Cilindro { get; set; }
        public string? Vu_Kit_Manutencao_I { get; set; }
        public string? Vu_Kit_Manutencao_II { get; set; }
        public string? Vu_Kit_Aquecimento_I { get; set; }
        public string? Vu_Kit_Aquecimento_II { get; set; }
        public string? Ultima_Troca_1 { get; set; }
        public DateTime? Data_Ultima_Troca_1 { get; set; }
        public string? Ultima_Troca_2 { get; set; }
        public DateTime? Data_Ultima_Troca_2 { get; set; }
        public string? Ultima_Troca_3 { get; set; }
        public DateTime? Data_Ultima_Troca_3 { get; set; }
        public string? Ultima_Troca_4 { get; set; }
        public DateTime? Data_Ultima_Troca_4 { get; set; }
        public string? Ultima_Troca_5 { get; set; }
        public DateTime? Data_Ultima_Troca_5 { get; set; }
        public string? Ultima_Troca_6 { get; set; }
        public DateTime? Data_Ultima_Troca_6 { get; set; }
        public string? Contador_Geral { get; set; }
        public string? Contato { get; set; }
        public string? Telefone { get; set; }
        public string? Bairro { get; set; }
        public string? Andar { get; set; }
        public string? Predio { get; set; }
        public string? Sala { get; set; }
        public string? Departamento { get; set; }
        public string? ContadorAbertura { get; set; }
        public string? ContadorFechamento { get; set; }
        public DateTime? Data_Instalacao { get; set; }
        public string? Contador_Instalacao { get; set; }
        public decimal? CustoPaginaMono { get; set; }
        public decimal? CustoPaginaColor { get; set; }
        public string? NotaRemessaLocacao { get; set; }
        public double? DolarFixo { get; set; }
        public double? DolarMesMedio { get; set; }
        public string? IPMaquina { get; set; }
        public string? TipoColeta { get; set; }
        public string? ContadorMono { get; set; }
        public string? ContadorColor { get; set; }
        public int? Acessorio { get; set; }
        public string? FranquiaColor { get; set; }
    }
}