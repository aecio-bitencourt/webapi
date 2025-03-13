using API.Dtos.Itens_do_Contrato_Nota;
using API.Models;

namespace API.Mappers
{
    public static class Itens_do_Contrato_NotaMappers
    {
        public static Itens_do_Contrato_NotaDto ToItens_do_Contrato_NotaDto(this Itens_do_Contrato_Nota itens_do_Contrato_NotaModel)
        {
            return new Itens_do_Contrato_NotaDto
            {
                Contrato = itens_do_Contrato_NotaModel.Contrato,
                Produto = itens_do_Contrato_NotaModel.Produto,
                Serie = itens_do_Contrato_NotaModel.Serie,
                Qtd = itens_do_Contrato_NotaModel.Qtd,
                Preco = itens_do_Contrato_NotaModel.Preco,
                Descricao = itens_do_Contrato_NotaModel.Descricao
            };
        }
    }
}
