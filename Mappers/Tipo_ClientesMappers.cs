using API.Dtos.Tipo_Clientes;
using API.Models;

namespace API.Mappers
{
    public static class Tipo_ClientesMappers
    {
        public static Tipo_ClientesDto ToTipo_ClientesDto(this Tipo_Clientes tipo_clientesModel)
        {
            return new Tipo_ClientesDto
            {
                Codigo = tipo_clientesModel.Codigo,
                Nome = tipo_clientesModel.Nome,
                Desconto = tipo_clientesModel.Desconto,
                Acrescimo = tipo_clientesModel.Acrescimo
            };
        }
    }
}
