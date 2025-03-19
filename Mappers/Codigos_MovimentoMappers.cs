using API.Dtos.Codigos_Movimento;
using API.Models;

namespace API.Mappers
{
    public static class Codigos_MovimentoMappers
    {
        public static Codigos_MovimentoDto ToCodigos_MovimentoDto(this Codigos_Movimento codigosMovimentoModel)
        {
            return new Codigos_MovimentoDto
            {
                Codigo = codigosMovimentoModel.Codigo,
                Nome = codigosMovimentoModel.Nome,
                Almoxarifado = codigosMovimentoModel.Almoxarifado
            };
        }
    }
}
