namespace API.Dtos.Taxa_Modelo
{
    public class Taxa_ModeloDto
    {
        public string? Modelo { get; set; }
        public DateTime? Dia { get; set; }
        public double? Cotacao { get; set; }
        public DateTime? Data_Ult_Mov { get; set; }
        public byte[]? TimeStap_w { get; set; }
    }
}
