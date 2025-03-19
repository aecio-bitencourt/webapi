using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Tipo_Produtos
    {
        [Key]
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
        public float? Desconto { get; set; }
        public double? Acrescimo { get; set; }
        public string? Fabricante { get; set; }
        public string? Grupo { get; set; }
    }
}
