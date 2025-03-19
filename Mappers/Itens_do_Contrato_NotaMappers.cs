using API.Dtos.Itens_do_Contrato_Nota;
using API.Models;

namespace API.Mappers
{
    public static class Itens_do_Contrato_NotaMappers
    {
        public static Itens_do_Contrato_NotaDto ToItens_do_Contrato_NotaDto(this Itens_do_Contrato_Nota itens_contrato_notaModel)
        {
            return new Itens_do_Contrato_NotaDto
            {
                Contrato = itens_contrato_notaModel.Contrato,
                Produto = itens_contrato_notaModel.Produto,
                Serie = itens_contrato_notaModel.Serie,
                Qtd = itens_contrato_notaModel.Qtd,
                Preco = itens_contrato_notaModel.Preco,
                Descricao = itens_contrato_notaModel.Descricao
            };
        }
    }
}
