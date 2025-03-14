using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace API.Models
{
    public class Tipo_Produtos
    {
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
        public float? Desconto { get; set; }
        public float? Acrescimo { get; set; }
        public string? Fabricante { get; set; }
        public string? Grupo { get; set; }
    }
}
