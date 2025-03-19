using API.Dtos.Modelos;
using API.Models;

namespace API.Mappers
{
    public static class ModelosMappers
    {
        public static ModelosDto ToModelosDto(this Modelos modelosModel)
        {
            return new ModelosDto
            {
                Nome = modelosModel.Nome,
                Codigo = modelosModel.Codigo,
                Inativo = modelosModel.Inativo,
                EstimativaAtendimento = modelosModel.EstimativaAtendimento
            };
        }
    }
}
