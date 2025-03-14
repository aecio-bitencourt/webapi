using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Vendedores
    {
        [Key]
        [Column(TypeName = "string(5)")]
        public string? Codigo { get; set; }

        [Column(TypeName = "string(40)")]
        public string? Nome { get; set; }
        public string? email { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Centro_de_Custo { get; set; }
    }
}
