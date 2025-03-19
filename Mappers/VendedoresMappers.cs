using API.Dtos.Vendedores;
using API.Models;

namespace API.Mappers
{
    public static class VendedoresMappers
    {
        public static VendedoresDto ToVendedoresDto(this Vendedores vendedoresModel)
        {
            return new VendedoresDto
            {
                Codigo = vendedoresModel.Codigo,
                Nome = vendedoresModel.Nome,
                email = vendedoresModel.email,
                Centro_de_Custo = vendedoresModel.Centro_de_Custo
            };
        }
    }
}
