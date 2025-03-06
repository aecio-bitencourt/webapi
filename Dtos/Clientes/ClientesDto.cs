using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Dtos.Clientes
{
    public class ClientesDto
    {
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
        public string? CNPJ { get; set; }
        public string? Inscricao { get; set; }
        public string? Endereco { get; set; }
        public string? CEP { get; set; }
        public string? Estado { get; set; }
        public string? Contato { get; set; }
        public string? Telefone { get; set; }
        public string? Tipo_do_Cliente { get; set; }
        public string? Regiao { get; set; }
        public string? Endereco_de_Cobranca { get; set; }
        public string? Bairro_de_Cobranca { get; set; }
        public string? CEP_de_Cobranca { get; set; }
        public string? Municipio_de_Cobranca { get; set; }
        public string? Estado_de_Cobranca { get; set; }
        public string? Vendedor { get; set; }
        public string? Telefone_de_Cobranca { get; set; }
        public string? Contato_de_Cobranca { get; set; }
        public string? Endereco_de_Entrega { get; set; }
        public string? Bairro_de_Entrega { get; set; }
        public string? CEP_de_Entrega { get; set; }
        public string? Municipio_de_Entrega { get; set; }
        public string? Estado_de_Entrega { get; set; }
        public string? Pais_de_Entrega { get; set; }
        public string? Telefone_de_Entrega { get; set; }
        public string? Contato_de_Entrega { get; set; }
        public string? Departamento1 { get; set; }
        public string? Centro_de_Custo { get; set; }
        public string? Grupo_Empresarial { get; set; }
        public string? Codigo_Matriz { get; set; }
        public string? Email { get; set; }
    }
}