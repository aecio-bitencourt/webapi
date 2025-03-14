using System.ComponentModel.DataAnnotations.Schema;

namespace API.Dtos.Tipo_Vendedor
{
    public class Tipo_VendedorDto
    {
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
    }
}