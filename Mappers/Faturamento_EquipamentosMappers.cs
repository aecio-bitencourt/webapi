using API.Dtos.Faturamento_Equipamentos;
using API.Models;

namespace API.Mappers
{
    public static class Faturamento_EquipamentosMappers
    {
        public static Faturamento_EquipamentosDto ToFaturamento_EquipamentosDto(this Faturamento_Equipamentos faturamento_equipamentosModel)
        {
            return new Faturamento_EquipamentosDto
            {
                Cliente = faturamento_equipamentosModel.Cliente,
                Contrato = faturamento_equipamentosModel.Contrato,
                Mes = faturamento_equipamentosModel.Mes,
                Produto = faturamento_equipamentosModel.Produto,
                NumeroSerie = faturamento_equipamentosModel.NumeroSerie,
                VariacaoCambial = faturamento_equipamentosModel.VariacaoCambial,
                IPMaquina = faturamento_equipamentosModel.IPMaquina,
                Departamento = faturamento_equipamentosModel.Departamento,
                CustoPaginaMono = faturamento_equipamentosModel.CustoPaginaMono,
                CustoPaginaColor = faturamento_equipamentosModel.CustoPaginaColor,
                TaxaFixa = faturamento_equipamentosModel.TaxaFixa,
                ContadorAcumMono = faturamento_equipamentosModel.ContadorAcumMono,
                ContadorAcumColor = faturamento_equipamentosModel.ContadorAcumColor,
                PaginasMesMono = faturamento_equipamentosModel.PaginasMesMono,
                PaginasMesColor = faturamento_equipamentosModel.PaginasMesColor,
                ValorTotal = faturamento_equipamentosModel.ValorTotal
            };
        }
    }
}
