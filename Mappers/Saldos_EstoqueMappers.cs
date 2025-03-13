using API.Dtos.Saldos_Estoque;
using API.Models;

namespace API.Mappers
{
    public static class Saldos_EstoqueMappers
    {
        public static Saldos_EstoqueDto ToSaldos_EstoqueDto(this Saldos_Estoque Saldos_EstoqueModel)
        {
            return new Saldos_EstoqueDto
            {
                Produto = Saldos_EstoqueModel.Produto,
                Almoxarifado = Saldos_EstoqueModel.Almoxarifado,
                Filial = Saldos_EstoqueModel.Filial,
                Saldo = Saldos_EstoqueModel.Saldo,
                Saldo_Terceiros = Saldos_EstoqueModel.Saldo_Terceiros,
                Custo = Saldos_EstoqueModel.Custo,
                Empenho = Saldos_EstoqueModel.Empenho,
                Pendente = Saldos_EstoqueModel.Pendente,
                Data_Ult_Mov = Saldos_EstoqueModel.Data_Ult_Mov
            };
        }
    }
}
