using API.Dtos.Produtos;
using API.Models;

namespace API.Mappers
{
    public static class ProdutosMappers
    {
        public static ProdutosDto ToProdutosDto(this Produtos produtosModel)
        {
            return new ProdutosDto
            {
                Codigo = produtosModel.Codigo,
                Descricao = produtosModel.Descricao,
                Fabricante = produtosModel.Fabricante,
                Tipo_Produto = produtosModel.Tipo_Produto,
                Estoque_Minimo = produtosModel.Estoque_Minimo,
                Estoque_Maximo = produtosModel.Estoque_Maximo,
                Tabela_Fabricante = produtosModel.Tabela_Fabricante,
                Numero_Nota_Ultima = produtosModel.Numero_Nota_Ultima,
                Data_Nota_Ultima = produtosModel.Data_Nota_Ultima,
                Modelo = produtosModel.Modelo,
                Durabilidade = produtosModel.Durabilidade
            };
        }
    }
}
