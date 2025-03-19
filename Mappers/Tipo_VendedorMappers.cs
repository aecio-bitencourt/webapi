using API.Dtos.Tipo_Vendedor;
using API.Models;

namespace API.Mappers
{
    public static class Tipo_VendedorMappers
    {
        public static Tipo_VendedorDto ToTipo_VendedorDto(this Tipo_Vendedor tipo_vendedorModel)
        {
            return new Tipo_VendedorDto
            {
                Codigo = tipo_vendedorModel.Codigo,
                Nome = tipo_vendedorModel.Nome,
            };
        }
    }
}
