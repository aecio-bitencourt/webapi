using API.Dtos.Titulos;
using API.Models;

namespace API.Mappers
{
    public static class TitulosMappers
    {
        public static TitulosDto ToTitulosDto(this Titulos titulosModel)
        {
            return new TitulosDto
            {
                Codigo = titulosModel.Codigo,
                Sacado = titulosModel.Sacado,
                Tipo = titulosModel.Tipo,
                Valor = titulosModel.Valor,
                Filial = titulosModel.Filial,
                Vencimento = titulosModel.Vencimento,
                Emissao = titulosModel.Emissao,
                Codigo_Emissao = titulosModel.Codigo_Emissao,
                Vendedor = titulosModel.Vendedor,
                Valor_Nota = titulosModel.Valor_Nota,
                Nota = titulosModel.Nota
            };
        }
     }
 }
