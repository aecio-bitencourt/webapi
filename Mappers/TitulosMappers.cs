using API.Dtos.Titulos;
using API.Models;

namespace API.Mappers
{
    public static class TitulosMappers
    {
        public static TitulosDto ToTitulosDto(this Titulos TitulosModel)
        {
            return new TitulosDto
            {
                Codigo = TitulosModel.Codigo,
                Sacado = TitulosModel.Sacado,
                Tipo = TitulosModel.Tipo,
                Valor = TitulosModel.Valor,
                Filial = TitulosModel.Filial,
                Vencimento = TitulosModel.Vencimento,
                Emissao = TitulosModel.Emissao,
                Codigo_Emissao = TitulosModel.Codigo_Emissao,
                Vendedor = TitulosModel.Vendedor,
                Valor_Nota = TitulosModel.Valor_Nota,
                Nota = TitulosModel.Nota
            };
        }
     }
 }
