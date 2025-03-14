using API.Dtos.Vendedores;
using API.Models;

namespace API.Mappers
{
    public static class VendedoresMappers
    {
        public static VendedoresDto ToVendedoresDto(this Vendedores VendedoresModel)
        {
            return new VendedoresDto
            {
                Codigo = VendedoresModel.Codigo,
                Nome = VendedoresModel.Nome,
                email = VendedoresModel.email,
                Centro_de_Custo = VendedoresModel.Centro_de_Custo
            };
        }
    }
}
