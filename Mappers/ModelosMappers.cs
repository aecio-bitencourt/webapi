using API.Dtos.Modelos;
using API.Models;

namespace API.Mappers
{
    public static class ModelosMappers
    {
        public static ModelosDto ToModelosDto(this Modelos ModelosModel)
        {
            return new ModelosDto
            {
                Nome = ModelosModel.Nome,
                Codigo = ModelosModel.Codigo,
                Inativo = ModelosModel.Inativo,
                EstimativaAtendimento = ModelosModel.EstimativaAtendimento
            };
        }
    }
}
