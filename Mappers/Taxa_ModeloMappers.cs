using API.Dtos.Taxa_Modelo;
using API.Models;

namespace API.Mappers
{
    public static class Taxa_ModeloMappers
    {
        public static Taxa_ModeloDto ToTaxa_ModeloDto(this Taxa_Modelo taxa_modeloModel)
        {
            return new Taxa_ModeloDto
            {
                Modelo = taxa_modeloModel.Modelo,
                Dia = taxa_modeloModel.Dia,
                Cotacao = taxa_modeloModel.Cotacao,
                Data_Ult_Mov = taxa_modeloModel.Data_Ult_Mov,
                TimeStap_w = taxa_modeloModel.TimeStap_w
            };
        }
    }
}
