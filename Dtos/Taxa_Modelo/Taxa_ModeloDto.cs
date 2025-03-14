using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Dtos.Taxa_Modelo
{
    public class Taxa_ModeloDto
    {
        public string? Modelo { get; set; }
        public DateTime? Dia { get; set; }
        public double? Cotacao { get; set; }
        public DateTime? Data_Ult_Mov { get; set; }

        [Timestamp]
        public Byte[]? TimeStap_w { get; set; }
    }
}

