using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Clientes
    {
        // Primary Key
        [Key]
        [Column(TypeName = "string(5)")]
        public string? Codigo { get; set; }

        [Column(TypeName = "string(40)")]
        public string? Nome { get; set; }

        [Column(TypeName = "string(18)")]
        public string? CNPJ { get; set; }

        [Column(TypeName = "string(20)")]
        public string? Inscricao { get; set; }

        [Column(TypeName = "string(40)")]
        public string? Endereco { get; set; }

        [Column(TypeName = "string(9)")]
        public string? CEP { get; set; }

        [Column(TypeName = "string(2)")]
        public string? Estado { get; set; }

        [Column(TypeName = "string(20)")]
        public string? Contato { get; set; }

        [Column(TypeName = "string(20)")]
        public string? Telefone { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Tipo_do_Cliente { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Regiao { get; set; }

        [Column(TypeName = "string(40)")]
        public string? Endereco_de_Cobranca { get; set; }

        [Column(TypeName = "string(30)")]
        public string? Bairro_de_Cobranca { get; set; }

        [Column(TypeName = "string(9)")]
        public string? CEP_de_Cobranca { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Municipio_de_Cobranca { get; set; }

        [Column(TypeName = "string(2)")]
        public string? Estado_de_Cobranca { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Vendedor { get; set; }

        [Column(TypeName = "string(20)")]
        public string? Telefone_de_Cobranca { get; set; }

        [Column(TypeName = "string(20)")]
        public string? Contato_de_Cobranca { get; set; }

        [Column(TypeName = "string(40)")]
        public string? Endereco_de_Entrega { get; set; }

        [Column(TypeName = "string(30)")]
        public string? Bairro_de_Entrega { get; set; }

        [Column(TypeName = "string(9)")]
        public string? CEP_de_Entrega { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Municipio_de_Entrega { get; set; }

        [Column(TypeName = "string(2)")]
        public string? Estado_de_Entrega { get; set; }

        [Column(TypeName = "string(20)")]
        public string? Pais_de_Entrega { get; set; }

        [Column(TypeName = "string(20)")]
        public string? Telefone_de_Entrega { get; set; }

        [Column(TypeName = "string(50)")]
        public string? Contato_de_Entrega { get; set; }

        [Column(TypeName = "string(20)")]
        public string? Departamento1 { get; set; }

        [Column(TypeName = "string(10)")]
        public string? Centro_de_Custo { get; set; }

        [Column(TypeName = "string(3)")]
        public string? Grupo_Empresarial { get; set; }

        [Column(TypeName = "string(5)")]
        public string? Codigo_Matriz { get; set; }

        [Column(TypeName = "string(200)")]
        public string? Email { get; set; }
    }
}