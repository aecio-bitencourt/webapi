using API.Dtos.Requisicoes_PecasSuprimentos;
using API.Models;

namespace API.Mappers
{
    public static class Requisicoes_PecasSuprimentosMappers
    {
        public static Requisicoes_PecasSuprimentosDto ToRequisicoes_PecasSuprimentosDto(this Requisicoes_PecasSuprimentos Requisicoes_PecasSuprimentosModel)
        {
            return new Requisicoes_PecasSuprimentosDto
            {
                ID = Requisicoes_PecasSuprimentosModel.ID,
                Numero_Serie = Requisicoes_PecasSuprimentosModel.Numero_Serie,
                Equipamento = Requisicoes_PecasSuprimentosModel.Equipamento,
                Usuario = Requisicoes_PecasSuprimentosModel.Usuario,
                Cliente = Requisicoes_PecasSuprimentosModel.Cliente,
                Situacao = Requisicoes_PecasSuprimentosModel.Situacao,
                Quantidade = Requisicoes_PecasSuprimentosModel.Quantidade,
                DataHoraAbertura = Requisicoes_PecasSuprimentosModel.DataHoraAbertura,
                DataFaturamento = Requisicoes_PecasSuprimentosModel.DataFaturamento,
                Pedido = Requisicoes_PecasSuprimentosModel.Pedido,
                Nota = Requisicoes_PecasSuprimentosModel.Nota,
                Filial = Requisicoes_PecasSuprimentosModel.Filial,
                DataPedido = Requisicoes_PecasSuprimentosModel.DataPedido,
                Contrato = Requisicoes_PecasSuprimentosModel.Contrato,
                EmailContato = Requisicoes_PecasSuprimentosModel.EmailContato
            };
            
        }
    }
}
