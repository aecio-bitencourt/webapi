using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API.Models
{
    public class Usuarios
    {
        [Key]
        public required string Nome { get; set; }
        public required string senha { get; set; }
    }
}
