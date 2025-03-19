using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Grupo_Empresarial
    {
        [Key]
        public required string Codigo { get; set; }
        public string? Nome { get; set; }
    }
}
