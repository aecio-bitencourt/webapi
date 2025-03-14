using API.Dtos.Tipo_Clientes;
using API.Models;

namespace API.Mappers
{
    public static class Tipo_ClientesMappers
    {
        public static Tipo_ClientesDto ToTipo_ClientesDto(this Tipo_Clientes Tipo_ClientesModel)
        {
            return new Tipo_ClientesDto
            {
                Codigo = Tipo_ClientesModel.Codigo,
                Nome = Tipo_ClientesModel.Nome,
                Desconto = Tipo_ClientesModel.Desconto,
                Acrescimo = Tipo_ClientesModel.Acrescimo
            };
        }
    }
}
