using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Tipo_Clientes
    {
        [Key]
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
        public float? Desconto { get; set; }
        public double? Acrescimo { get; set; }
    }
}
