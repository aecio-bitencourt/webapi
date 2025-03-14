using API.Dtos.Taxa_Modelo;
using API.Models;

namespace API.Mappers
{
    public static class Taxa_ModeloMappers
    {
        public static Taxa_ModeloDto ToTaxa_ModeloDto(this Taxa_Modelo Taxa_ModeloModel)
        {
            return new Taxa_ModeloDto
            {
                Modelo = Taxa_ModeloModel.Modelo,
                Dia = Taxa_ModeloModel.Dia,
                Cotacao = Taxa_ModeloModel.Cotacao,
                Data_Ult_Mov = Taxa_ModeloModel.Data_Ult_Mov,
                TimeStap_w = Taxa_ModeloModel.TimeStap_w
            };
        }
    }
}