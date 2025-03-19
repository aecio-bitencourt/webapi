using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Taxa_Modelo
    {
        [Key]
        public string? Modelo { get; set; }
        public DateTime? Dia { get; set; }
        public double? Cotacao { get; set; }
        public DateTime? Data_Ult_Mov { get; set; }
        [Timestamp]
        public byte[]? TimeStap_w { get; set; }
    }
}
