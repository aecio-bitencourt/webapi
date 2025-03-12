using API.Dtos.Fornecedores;
using API.Models;

namespace API.Mappers
{
    public static class FornecedoresMappers
    {
        public static FornecedoresDto ToFornecedoresDto(this Fornecedores fornecedoresModel)
        {
            return new FornecedoresDto
            {
                Codigo = fornecedoresModel.Codigo,
                Nome = fornecedoresModel.Nome,
                CGC = fornecedoresModel.CGC,
                Inscricao = fornecedoresModel.Inscricao,
                Endereco = fornecedoresModel.Endereco,
                Municipio = fornecedoresModel.Municipio,
                Estado = fornecedoresModel.Estado,
                CEP = fornecedoresModel.CEP,
                Contato = fornecedoresModel.Contato,
                Telefone = fornecedoresModel.Telefone,
                Fax = fornecedoresModel.Fax,
                Ult_Documento = fornecedoresModel.Ult_Documento,
                Ult_DataDoc = fornecedoresModel.Ult_DataDoc,
                Ult_Oper = fornecedoresModel.Ult_Oper,
                Ult_Qtd = fornecedoresModel.Ult_Qtd,
                Ult_Custo = fornecedoresModel.Ult_Custo,
                Icm = fornecedoresModel.Icm,
                Telex = fornecedoresModel.Telex,
                Bairro = fornecedoresModel.Bairro,
                Data_Ult_Mov = fornecedoresModel.Data_Ult_Mov,
                Observacao = fornecedoresModel.Observacao,
                Tipo_Fornecedor = fornecedoresModel.Tipo_Fornecedor,
                Centro_de_Custo = fornecedoresModel.Centro_de_Custo,
                Conta_Contabil = fornecedoresModel.Conta_Contabil,
                Representante = fornecedoresModel.Representante,
                Contato_Representante = fornecedoresModel.Contato_Representante,
                Telefone_Representante = fornecedoresModel.Telefone_Representante,
                Condicao_Despacho = fornecedoresModel.Condicao_Despacho,
                Fax_Representante = fornecedoresModel.Fax_Representante,
                Moeda = fornecedoresModel.Moeda,
                Codigo_Cliente = fornecedoresModel.Codigo_Cliente,
                TimeStamp_w = fornecedoresModel.TimeStamp_w,
                Email = fornecedoresModel.Email,
                Inativo = fornecedoresModel.Inativo,
                Ult_Documento1 = fornecedoresModel.Ult_Documento1,
                Ult_Document1 = fornecedoresModel.Ult_Document1,
                Fax__Representante = fornecedoresModel.Fax__Representante,
                Fantasia = fornecedoresModel.Fantasia,
                Numero_Proxima_Rr = fornecedoresModel.Numero_Proxima_Rr,
                Taxa_Distribuidor = fornecedoresModel.Taxa_Distribuidor,
                Substituido = fornecedoresModel.Substituido,
                Numero = fornecedoresModel.Numero,
                Complemento = fornecedoresModel.Complemento,
                PercentualSimplesFornecedor = fornecedoresModel.PercentualSimplesFornecedor,
                Data_Alteracao_Cadastro_Fornecedor = fornecedoresModel.Data_Alteracao_Cadastro_Fornecedor,
                PastaDriversDownload = fornecedoresModel.PastaDriversDownload,
                CodigoFabricanteProdutoMesmoDoFornecedor = fornecedoresModel.CodigoFabricanteProdutoMesmoDoFornecedor,
                Conta_Contabil_Despesa = fornecedoresModel.Conta_Contabil_Despesa,
                Retido_ISS = fornecedoresModel.Retido_ISS,
                Retido_INSS = fornecedoresModel.Retido_INSS,
                Retido_IRRF = fornecedoresModel.Retido_IRRF,
                Retido_PIS = fornecedoresModel.Retido_PIS,
                Retido_COFINS = fornecedoresModel.Retido_COFINS,
                Retido_CSLL = fornecedoresModel.Retido_CSLL,
                codigo_movimento = fornecedoresModel.codigo_movimento,
                Banco = fornecedoresModel.Banco,
                Agencia = fornecedoresModel.Agencia,
                ContaCorrente = fornecedoresModel.ContaCorrente
            };
        }
    }
}
