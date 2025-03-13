using API.Dtos.Leituras_Equipamentos;
using API.Models;

namespace API.Mappers
{
    public static class Leituras_EquipamentosMappers
    {
        public static Leituras_EquipamentosDto ToLeituras_EquipamentosDto(this Leituras_Equipamentos leituras_EquipamentosModel)
        {
            return new Leituras_EquipamentosDto
            {
                Contrato = leituras_EquipamentosModel.Contrato,
                Equipamento = leituras_EquipamentosModel.Equipamento,
                Numero_Serie = leituras_EquipamentosModel.Numero_Serie,
                Data_Leitura = leituras_EquipamentosModel.Data_Leitura,
                TipoLeitura = leituras_EquipamentosModel.TipoLeitura,
                Informante = leituras_EquipamentosModel.Informante,
                Observacao = leituras_EquipamentosModel.Observacao,
                Contador = leituras_EquipamentosModel.Contador,
                ContadorMono = leituras_EquipamentosModel.ContadorMono,
                ContadorColor = leituras_EquipamentosModel.ContadorColor
            };
        }
    }
}
