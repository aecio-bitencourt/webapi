using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace API.Models
{
    public class Taxa_Modelo
    {
        [Key]
        [Column(TypeName = "string(3)")]
        public string? Modelo { get; set; }
        public DateTime? Dia { get; set; }
        public double? Cotacao { get; set; }
        public DateTime? Data_Ult_Mov { get; set; }

        [Timestamp]
        public Byte[]? TimeStap_w { get; set; }
    }
}
