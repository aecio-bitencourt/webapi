using API.Dtos.Tipo_Vendedor;
using API.Models;

namespace API.Mappers
{
    public static class Tipo_VendedorMappers
    {
        public static Tipo_VendedorDto ToTipo_VendedorDto(this Tipo_Vendedor Tipo_VendedorModel)
        {
            return new Tipo_VendedorDto
            {
                Codigo = Tipo_VendedorModel.Codigo,
                Nome = Tipo_VendedorModel.Nome,
            };
        }
    }
}
