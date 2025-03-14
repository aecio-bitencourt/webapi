using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Tipo_Vendedor
    {
        [Key]
        [Column(TypeName = "string(3)")]
        public string? Codigo { get; set; }

        [Column(TypeName = "string(30)")]
        public string? Nome { get; set; }
    }
}
