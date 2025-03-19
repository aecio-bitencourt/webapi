using API.Dtos.Centro_de_Custo;
using API.Models;

namespace API.Mappers
{
    public static class Centro_de_CustoMappers
    {
        public static Centro_de_CustoDto ToCentro_de_CustoDto(this Centro_de_Custo centro_de_custoModel)
        {
            return new Centro_de_CustoDto
            {
                Codigo = centro_de_custoModel.Codigo,
                Nome = centro_de_custoModel.Nome
            };

        }
    }
}
