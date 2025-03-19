using API.Dtos.Tipo_Produtos;
using API.Models;

namespace API.Mappers
{
    public static class Tipo_ProdutosMappers
    {
        public static Tipo_ProdutosDto ToTipo_ProdutosDto(this Tipo_Produtos tipoProdutosModel)
        {
            return new Tipo_ProdutosDto
            {
                Codigo = tipoProdutosModel.Codigo,
                Nome = tipoProdutosModel.Nome,
                Desconto = tipoProdutosModel.Desconto,
                Acrescimo = tipoProdutosModel.Acrescimo,
                Fabricante = tipoProdutosModel.Fabricante,
                Grupo = tipoProdutosModel.Grupo
            };
        }
    }
}
