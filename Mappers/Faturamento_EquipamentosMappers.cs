using API.Dtos.Faturamento_Equipamentos;
using API.Models;

namespace API.Mappers
{
    public static class Faturamento_EquipamentosMappers
    {
        public static Faturamento_EquipamentosDto ToFaturamento_EquipamentosDto(this Faturamento_Equipamentos Faturamento_EquipamentosModel)
        {
            return new Faturamento_EquipamentosDto
            {
                Cliente = Faturamento_EquipamentosModel.Cliente,
                Contrato = Faturamento_EquipamentosModel.Contrato,
                Mes = Faturamento_EquipamentosModel.Mes,
                Produto = Faturamento_EquipamentosModel.Produto,
                NumeroSerie = Faturamento_EquipamentosModel.NumeroSerie,
                VariacaoCambial = Faturamento_EquipamentosModel.VariacaoCambial,
                IPMaquina = Faturamento_EquipamentosModel.IPMaquina,
                Departamento = Faturamento_EquipamentosModel.Departamento,
                CustoPaginaMono = Faturamento_EquipamentosModel.CustoPaginaMono,
                CustoPaginaColor = Faturamento_EquipamentosModel.CustoPaginaColor,
                TaxaFixa = Faturamento_EquipamentosModel.TaxaFixa,
                ContadorAcumMono = Faturamento_EquipamentosModel.ContadorAcumMono,
                ContadorAcumColor = Faturamento_EquipamentosModel.ContadorAcumColor,
                PaginasMesMono = Faturamento_EquipamentosModel.PaginasMesMono,
                PaginasMesColor = Faturamento_EquipamentosModel.PaginasMesColor,
                ValorTotal = Faturamento_EquipamentosModel.ValorTotal
            };
        }
    }
}