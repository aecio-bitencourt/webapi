using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Vendedores
    {
        [Key]
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
        public string? email { get; set; }
        public string? Centro_de_Custo { get; set; }
    }
}
