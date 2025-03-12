using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Itens_do_Contrato
    {
        [Key]
        [Column(TypeName = "string(6)")]
        public string? Contrato { get; set; }

        [Column(TypeName = "string(20)")]
        public string? Produto { get; set; }

        [Column(TypeName = "string(20)")]
        public string? Serie { get; set; }

        [Column(TypeName = "string(100)")]
        public string? Observacao { get; set; }

        [Column(TypeName = "string(200)")]
        public string? Endereco { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Cidade { get; set; }

        [Column(TypeName = "string(2)")]
        public string? Estado { get; set; }

        [Column(TypeName = "string(9)")]
        public string? CEP { get; set; }

        public double? Qtd { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        public decimal? Preco { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Franquia { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Qtd_Copias_Revisao { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Val_excedente_Copias { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Vu_Revelador { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Vu_Cilindro { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Vu_Kit_Manutencao_I { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Vu_Kit_Manutencao_II { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Vu_Kit_Aquecimento_I { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Vu_Kit_Aquecimento_II { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Ultima_Troca_1 { get; set; }
        public DateTime? Data_Ultima_Troca_1 { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Ultima_Troca_2 { get; set; }
        public DateTime? Data_Ultima_Troca_2 { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Ultima_Troca_3 { get; set; }
        public DateTime? Data_Ultima_Troca_3 { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Ultima_Troca_4 { get; set; }
        public DateTime? Data_Ultima_Troca_4 { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Ultima_Troca_5 { get; set; }
        public DateTime? Data_Ultima_Troca_5 { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Ultima_Troca_6 { get; set; }
        public DateTime? Data_Ultima_Troca_6 { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Contador_Geral { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Contato { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Telefone { get; set; }

        [Column(TypeName = "string(100)")]
        public string? Bairro { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Andar { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Predio { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Sala { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Departamento { get; set; }

        [Column(TypeName = "string(50)")]
        public string? ContadorAbertura { get; set; }

        [Column(TypeName = "string(50)")]
        public string? ContadorFechamento { get; set; }

        public DateTime? Data_Instalacao { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Contador_Instalacao { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        public decimal? CustoPaginaMono { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        public decimal? CustoPaginaColor { get; set; }

        [Column(TypeName = "string(50)")]
        public string? NotaRemessaLocacao { get; set; }

        public double? DolarFixo { get; set; }
        public double? DolarMesMedio { get; set; }

        [Column(TypeName = "string(50)")]
        public string? IPMaquina { get; set; }

        [Column(TypeName = "string(50)")]
        public string? TipoColeta { get; set; }

        [Column(TypeName = "string(50)")]
        public string? ContadorMono { get; set; }

        [Column(TypeName = "string(50)")]
        public string? ContadorColor { get; set; }

        public int? Acessorio { get; set; }

        [Column(TypeName = "string(50)")]
        public string? FranquiaColor { get; set; }
    }
}