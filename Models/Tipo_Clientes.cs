using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Tipo_Clientes
    {
        [Key]
        [Column(TypeName = "string(3)")]
        public string? Codigo { get; set; }

        [Column(TypeName = "string(40)")]
        public string? Nome { get; set; }
        public float? Desconto { get; set; }
        public double? Acrescimo { get; set; }
    }
}
