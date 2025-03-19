using API.Dtos.Itens_Notas;
using API.Models;

namespace API.Mappers
{
    public static class Itens_NotasMappers
    {
        public static Itens_NotasDto ToItens_NotasDto(this Itens_Notas itens_notasModel)
        {
            return new Itens_NotasDto
            {
                Nota = itens_notasModel.Nota,
                Produto = itens_notasModel.Produto,
                Quantidade = itens_notasModel.Quantidade,
                Preco_Unitario = itens_notasModel.Preco_Unitario,
                Custo = itens_notasModel.Custo,
                Custo_Dol = itens_notasModel.Custo_Dol,
                Filial = itens_notasModel.Filial,
                Almoxarifado = itens_notasModel.Almoxarifado,
                Pedido = itens_notasModel.Pedido,
                Preco_Total = itens_notasModel.Preco_Total,
                Saldo_Anterior = itens_notasModel.Saldo_Anterior,
                Saldo_Atual = itens_notasModel.Saldo_Atual,
                Custo_Atual_Cru = itens_notasModel.Custo_Atual_Cru,
                Custo_Atual_Dol = itens_notasModel.Custo_Atual_Dol,
                Data_Nota = itens_notasModel.Data_Nota,
                Codigo_Movimento = itens_notasModel.Codigo_Movimento,
                Cliente_Fornecedor = itens_notasModel.Cliente_Fornecedor,
                Tipo = itens_notasModel.Tipo,
                Serie = itens_notasModel.Serie,
                Centro_de_Custo = itens_notasModel.Centro_de_Custo,
                Tipo_Produto = itens_notasModel.Tipo_Produto
            };
        }
    }
}
