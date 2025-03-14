using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace API.Models
{
    public class Titulos
    {
        [Key]
        [Column(TypeName = "string(12)")]
        public string? Codigo { get; set; }

        [Column(TypeName = "string(5)")]
        public string? Sacado { get; set; }

        [Column(TypeName = "string(1)")]
        public string? Tipo { get; set; }
        public decimal? Valor { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Filial { get; set; }
        public DateTime? Vencimento { get; set; }
        public DateTime? Emissao { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Codigo_Emissao { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Vendedor { get; set; }
        public decimal? Valor_Nota { get; set; }

        [Column(TypeName = "string(9)")]
        public string? Nota { get; set; }
    }
}
