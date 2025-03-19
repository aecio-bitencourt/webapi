using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Modelos
    {
        [Key]
        public string? Nome { get; set; }
        public string? Codigo { get; set; }
        public int? Inativo { get; set; }
        public double? EstimativaAtendimento { get; set; }
    }
}
