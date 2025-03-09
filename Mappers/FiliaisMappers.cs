using API.Dtos.Filiais;
using API.Models;

namespace API.Mappers
{
    public static class FiliaisMappers
    {
        public static FiliaisDto ToFiliaisDto(this Filiais filiaisModel)
        {
            return new FiliaisDto
            {
                Codigo = filiaisModel.Codigo,
                Nome = filiaisModel.Nome,
                CGC = filiaisModel.CGC,
                Estado = filiaisModel.Estado,
                Endereco = filiaisModel.Endereco,
                CEP = filiaisModel.CEP,
                Cidade = filiaisModel.Cidade,
                Inscricao = filiaisModel.Inscricao,
                Bairro = filiaisModel.Bairro,
                Fax = filiaisModel.Fax,
                Codigo_Movimento_Padrao = filiaisModel.Codigo_Movimento_Padrao,
                Almoxarifado_Padrao = filiaisModel.Almoxarifado_Padrao,
                Percentual_Iss = filiaisModel.Percentual_Iss,
                Inscricao_Municipal = filiaisModel.Inscricao_Municipal,
                Email = filiaisModel.Email,
            };
        }
    }
}
