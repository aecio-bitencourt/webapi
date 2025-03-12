using API.Dtos.Itens_Notas;
using API.Models;

namespace API.Mappers
{
    public static class Itens_NotasMappers
    {
        public static Itens_NotasDto ToItens_NotasDto(this Itens_Notas Itens_NotasModel)
        {
            return new Itens_NotasDto
            {
                Nota = Itens_NotasModel.Nota,
                Produto = Itens_NotasModel.Produto,
                Quantidade = Itens_NotasModel.Quantidade,
                Preco_Unitario = Itens_NotasModel.Preco_Unitario,
                Custo = Itens_NotasModel.Custo,
                Custo_Dol = Itens_NotasModel.Custo_Dol,
                Filial = Itens_NotasModel.Filial,
                Almoxarifado = Itens_NotasModel.Almoxarifado,
                Pedido = Itens_NotasModel.Pedido,
                Preco_Total = Itens_NotasModel.Preco_Total,
                Saldo_Anterior = Itens_NotasModel.Saldo_Anterior,
                Saldo_Atual = Itens_NotasModel.Saldo_Atual,
                Custo_Atual_Cru = Itens_NotasModel.Custo_Atual_Cru,
                Custo_Atual_Dol = Itens_NotasModel.Custo_Atual_Dol,
                Data_Nota = Itens_NotasModel.Data_Nota,
                Codigo_Movimento = Itens_NotasModel.Codigo_Movimento,
                Cliente_Fornecedor = Itens_NotasModel.Cliente_Fornecedor,
                Tipo = Itens_NotasModel.Tipo,
                Serie = Itens_NotasModel.Serie,
                Centro_de_Custo = Itens_NotasModel.Centro_de_Custo,
                Tipo_Produto = Itens_NotasModel.Tipo_Produto
            };
        }
    }
}