using API.Dtos.Contratos;
using API.Models;

namespace API.Mappers
{
    public static class ContratosMappers
    {
        public static ContratosDto ToContratosDto(this Contratos contratosModel)
        {
            return new ContratosDto
            {
                Codigo = contratosModel.Codigo,
                Tipo_de_Contrato = contratosModel.Tipo_de_Contrato,
                Cliente = contratosModel.Cliente,
                Valor = contratosModel.Valor,
                Data_Primeiro_Pagamento = contratosModel.Data_Primeiro_Pagamento,
                Dia_do_Vencimento = contratosModel.Dia_do_Vencimento,
                Periodo_de_Reajuste = contratosModel.Periodo_de_Reajuste,
                Taxa_de_Reajuste = contratosModel.Taxa_de_Reajuste,
                Contrato_Assinado = contratosModel.Contrato_Assinado,
                Opcao_de_Compra = contratosModel.Opcao_de_Compra,
                Prazo = contratosModel.Prazo,
                Observacao = contratosModel.Observacao,
                Data_Inicio = contratosModel.Data_Inicio,
                Data_Termino = contratosModel.Data_Termino,
                Situacao = contratosModel.Situacao,
                Data_Ultima_Nota = contratosModel.Data_Ultima_Nota,
                Vendedor = contratosModel.Vendedor,
                Vendedor2 = contratosModel.Vendedor2,
                Filial = contratosModel.Filial,
                Centro_Custo = contratosModel.Centro_Custo,
                Data_Alteracao = contratosModel.Data_Alteracao,
                Ultima_Nota = contratosModel.Ultima_Nota,
                Ultimo_Periodo = contratosModel.Ultimo_Periodo,
                Valor_Total = contratosModel.Valor_Total,
                Data_Assinatura = contratosModel.Data_Assinatura,
                Data_Reajuste = contratosModel.Data_Reajuste,
                Moeda_Reajuste = contratosModel.Moeda_Reajuste,
                Departamento = contratosModel.Departamento,
                NotaRemessaLocacao = contratosModel.NotaRemessaLocacao,
                TemVariacaoCambial = contratosModel.TemVariacaoCambial,
                SoftwareBilhetagem = contratosModel.SoftwareBilhetagem,
                DolarContrato = contratosModel.DolarContrato,
                FranquiaMono = contratosModel.FranquiaMono,
                FranquiaColor = contratosModel.FranquiaColor,
                RelatorioClienteInativo = contratosModel.RelatorioClienteInativo
            };
        }
    }
}
