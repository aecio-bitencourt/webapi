using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Filiais
    {
        [Key]
        [Column(TypeName = "string(3)")]
        public string? Codigo { get; set; }

        [Column(TypeName = "string(40)")]
        public string? Nome { get; set; }

        [Column(TypeName = "string(18)")]
        public string? CGC { get; set; }

        [Column(TypeName = "string(2)")]
        public string? Estado { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Endereco { get; set; }

        [Column(TypeName = "string(9)")]
        public string? CEP { get; set; }

        [Column(TypeName = "string(20)")]
        public string? Cidade { get; set; }

        [Column(TypeName = "string(20)")]
        public string? Inscricao { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Bairro { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Fax { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Codigo_Movimento_Padrao { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Almoxarifado_Padrao { get; set; }

        public double? Percentual_Iss { get; set; }

        [Column(TypeName = "string(40)")]
        public string? Inscricao_Municipal { get; set; }

        [Column(TypeName = "string(100)")]
        public string? Email { get; set; }
    }
}
