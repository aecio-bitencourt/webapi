using API.Dtos.Saldos_Estoque;
using API.Models;

namespace API.Mappers
{
    public static class Saldos_EstoqueMappers
    {
        public static Saldos_EstoqueDto ToSaldos_EstoqueDto(this Saldos_Estoque saldos_estoqueModel)
        {
            return new Saldos_EstoqueDto
            {
                Produto = saldos_estoqueModel.Produto,
                Almoxarifado = saldos_estoqueModel.Almoxarifado,
                Filial = saldos_estoqueModel.Filial,
                Saldo = saldos_estoqueModel.Saldo,
                Saldo_Terceiros = saldos_estoqueModel.Saldo_Terceiros,
                Custo = saldos_estoqueModel.Custo,
                Empenho = saldos_estoqueModel.Empenho,
                Pendente = saldos_estoqueModel.Pendente,
                Data_Ult_Mov = saldos_estoqueModel.Data_Ult_Mov
            };
        }
    }
}
