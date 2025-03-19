using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Codigos_Movimento
    {
        [Key]
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Almoxarifado { get; set; }
    }
}
