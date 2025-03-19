using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Tipo_Vendedor
    {
        [Key]
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
    }
}
