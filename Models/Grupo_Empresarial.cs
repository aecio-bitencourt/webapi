using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Grupo_Empresarial
    {
        [Key]
        [Column(TypeName = "string(3)")]
        public string Codigo { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Nome { get; set; }
    }
}
