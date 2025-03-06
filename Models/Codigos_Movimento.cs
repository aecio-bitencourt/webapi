using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Codigos_Movimento
    {
        [Key]
        [Column(TypeName = "string(3)")]
        public string? Codigo { get; set; }
        
        [Column(TypeName = "string(40)")]
        public string? Nome { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Almoxarifado { get; set; }
    }
}
