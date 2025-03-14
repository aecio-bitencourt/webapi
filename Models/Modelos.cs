using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Modelos
    {
        [Key]
        [Column(TypeName = "string(50)")]
        public string? Nome { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Codigo { get; set; }

        public int? Inativo { get; set; }

        public double? EstimativaAtendimento { get; set; }
    }
}
