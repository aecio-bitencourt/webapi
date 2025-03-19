namespace API.Dtos.Titulos
{
    public class TitulosDto
    {
        public string? Codigo { get; set; }
        public string? Sacado { get; set; }
        public string? Tipo { get; set; }
        public decimal? Valor { get; set; }
        public string? Filial { get; set; }
        public DateTime? Vencimento { get; set; }
        public DateTime? Emissao { get; set; }
        public string? Codigo_Emissao { get; set; }
        public string? Vendedor { get; set; }
        public decimal? Valor_Nota { get; set; }
        public string? Nota { get; set; }
    }
}
