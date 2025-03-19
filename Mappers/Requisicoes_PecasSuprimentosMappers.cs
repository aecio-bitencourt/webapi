using API.Dtos.Requisicoes_PecasSuprimentos;
using API.Models;

namespace API.Mappers
{
    public static class Requisicoes_PecasSuprimentosMappers
    {
        public static Requisicoes_PecasSuprimentosDto ToRequisicoes_PecasSuprimentosDto(this Requisicoes_PecasSuprimentos requisicoes_pecasSuprimentosModel)
        {
            return new Requisicoes_PecasSuprimentosDto
            {
                ID = requisicoes_pecasSuprimentosModel.ID,
                Numero_Serie = requisicoes_pecasSuprimentosModel.Numero_Serie,
                Equipamento = requisicoes_pecasSuprimentosModel.Equipamento,
                Suprimento = requisicoes_pecasSuprimentosModel.Suprimento,
                Usuario = requisicoes_pecasSuprimentosModel.Usuario,
                Cliente = requisicoes_pecasSuprimentosModel.Cliente,
                Situacao = requisicoes_pecasSuprimentosModel.Situacao,
                Quantidade = requisicoes_pecasSuprimentosModel.Quantidade,
                DataHoraAbertura = requisicoes_pecasSuprimentosModel.DataHoraAbertura,
                DataFaturamento = requisicoes_pecasSuprimentosModel.DataFaturamento,
                Pedido = requisicoes_pecasSuprimentosModel.Pedido,
                Nota = requisicoes_pecasSuprimentosModel.Nota,
                Filial = requisicoes_pecasSuprimentosModel.Filial,
                DataPedido = requisicoes_pecasSuprimentosModel.DataPedido,
                Contrato = requisicoes_pecasSuprimentosModel.Contrato,
                EmailContato = requisicoes_pecasSuprimentosModel.EmailContato
            };
            
        }
    }
}
