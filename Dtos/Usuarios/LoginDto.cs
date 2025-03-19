using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Identity.Client;

namespace API.Dtos.Usuarios
{
    public class LoginDto
    {
        public required string Nome { get; set; }
        public required string senha { get; set; }
    }
}
