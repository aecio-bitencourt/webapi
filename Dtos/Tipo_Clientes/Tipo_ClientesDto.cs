using System.ComponentModel.DataAnnotations.Schema;

namespace API.Dtos.Tipo_Clientes
{
    public class Tipo_ClientesDto
    {
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
        public float? Desconto { get; set; }
        public double? Acrescimo { get; set; }
    }
}