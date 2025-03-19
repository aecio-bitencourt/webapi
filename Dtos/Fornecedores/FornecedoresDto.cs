using System.ComponentModel.DataAnnotations;

namespace API.Dtos.Fornecedores
{
    public class FornecedoresDto
    {
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
        public string? CGC { get; set; }
        public string? Inscricao { get; set; }
        public string? Endereco { get; set; }
        public string? Municipio { get; set; }
        public string? Estado { get; set; }
        public string? CEP { get; set; }
        public string? Contato { get; set; }
        public string? Telefone { get; set; }
        public string? Fax { get; set; }
        public string? Ult_Documento { get; set; }
        public DateTime? Ult_DataDoc { get; set; }
        public string? Ult_Oper { get; set; }
        public double? Ult_Qtd { get; set; }
        public decimal? Ult_Custo { get; set; }
        public double? Icm { get; set; }
        public string? Telex { get; set; }
        public string? Bairro { get; set; }
        public DateTime? Data_Ult_Mov { get; set; }
        public string? Observacao { get; set; }
        public string? Tipo_Fornecedor { get; set; }
        public string? Centro_de_Custo { get; set; }
        public string? Conta_Contabil { get; set; }
        public string? Representante { get; set; }
        public string? Contato_Representante { get; set; }
        public string? Telefone_Representante { get; set; }
        public string? Condicao_Despacho { get; set; }
        public string? Fax_Representante { get; set; }
        public string? Moeda { get; set; }
        public string? Codigo_Cliente { get; set; }
        public byte[]? TimeStamp_w { get; set; }
        public string? Email { get; set; }
        public int? Inativo { get; set; }
        public string? Ult_Documento1 { get; set; }
        public string? Ult_Document1 { get; set; }
        public string? Fax__Representante { get; set; }
        public string? Fantasia { get; set; }
        public double? Numero_Proxima_Rr { get; set; }
        public double? Taxa_Distribuidor { get; set; }
        public int? Substituido { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public double? PercentualSimplesFornecedor { get; set; }
        public DateTime? Data_Alteracao_Cadastro_Fornecedor { get; set; }
        public string? PastaDriversDownload { get; set; }
        public int? CodigoFabricanteProdutoMesmoDoFornecedor { get; set; }
        public string? Conta_Contabil_Despesa { get; set; }
        public double? Retido_ISS { get; set; }
        public double? Retido_INSS { get; set; }
        public double? Retido_IRRF { get; set; }
        public double? Retido_PIS { get; set; }
        public double? Retido_COFINS { get; set; }
        public double? Retido_CSLL { get; set; }
        public string? codigo_movimento { get; set; }
        public string? Banco { get; set; }
        public string? Agencia { get; set; }
        public string? ContaCorrente { get; set; }
    }
}
