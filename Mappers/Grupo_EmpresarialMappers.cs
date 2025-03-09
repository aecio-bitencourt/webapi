using API.Dtos.Grupo_Empresarial;
using API.Models;

namespace API.Mappers
{
    public static class Grupo_EmpresarialMappers
    {
        public static Grupo_EmpresarialDto ToGrupo_Empresarial(this Grupo_Empresarial grupo_EmpresarialModel)
        {
            return new Grupo_EmpresarialDto
            {
                Codigo = grupo_EmpresarialModel.Codigo,
                Nome = grupo_EmpresarialModel.Nome
            };
        }
    }
}
