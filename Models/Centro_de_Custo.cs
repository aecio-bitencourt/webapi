using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Centro_de_Custo
    {
        [Key]
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
    }
}