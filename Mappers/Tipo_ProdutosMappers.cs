using API.Dtos.Tipo_Produtos;
using API.Models;
using System.Text.RegularExpressions;

namespace API.Mappers
{
    public static class Tipo_ProdutosMappers
    {
        public static Tipo_ProdutosDto ToTipo_ProdutosDto(this Tipo_Produtos tipoprodutosModel)
        {
            return new Tipo_ProdutosDto
            {
                Codigo = tipoprodutosModel.Codigo,
                Nome = tipoprodutosModel.Nome,
                Desconto = tipoprodutosModel.Desconto,
                Acrescimo = tipoprodutosModel.Acrescimo,
                Fabricante = tipoprodutosModel.Fabricante,
                Grupo = tipoprodutosModel.Grupo
            };
        }
    }
}
