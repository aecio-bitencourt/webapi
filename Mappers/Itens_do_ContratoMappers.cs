using API.Dtos.Itens_do_Contrato;
using API.Models;

namespace API.Mappers
{
    public static class Itens_do_ContratoMappers
    {
        public static Itens_do_ContratoDto ToItens_do_ContratoDto(this Itens_do_Contrato itens_do_ContratoModel)
        {
            return new Itens_do_ContratoDto
            {
                Contrato = itens_do_ContratoModel.Contrato,
                Produto = itens_do_ContratoModel.Produto,
                Serie = itens_do_ContratoModel.Serie,
                Observacao = itens_do_ContratoModel.Observacao,
                Endereco = itens_do_ContratoModel.Endereco,
                Cidade = itens_do_ContratoModel.Cidade,
                Estado = itens_do_ContratoModel.Estado,
                CEP = itens_do_ContratoModel.CEP,
                Qtd = itens_do_ContratoModel.Qtd,
                Preco = itens_do_ContratoModel.Preco,
                Franquia = itens_do_ContratoModel.Franquia,
                Qtd_Copias_Revisao = itens_do_ContratoModel.Qtd_Copias_Revisao,
                Val_excedente_Copias = itens_do_ContratoModel.Val_excedente_Copias,
                Vu_Revelador = itens_do_ContratoModel.Vu_Revelador,
                Vu_Cilindro = itens_do_ContratoModel.Vu_Cilindro,
                Vu_Kit_Manutencao_I = itens_do_ContratoModel.Vu_Kit_Manutencao_I,
                Vu_Kit_Manutencao_II = itens_do_ContratoModel.Vu_Kit_Manutencao_II,
                Vu_Kit_Aquecimento_I = itens_do_ContratoModel.Vu_Kit_Aquecimento_I,
                Vu_Kit_Aquecimento_II = itens_do_ContratoModel.Vu_Kit_Aquecimento_II,
                Ultima_Troca_1 = itens_do_ContratoModel.Ultima_Troca_1,
                Data_Ultima_Troca_1 = itens_do_ContratoModel.Data_Ultima_Troca_1,
                Ultima_Troca_2 = itens_do_ContratoModel.Ultima_Troca_2,
                Data_Ultima_Troca_2 = itens_do_ContratoModel.Data_Ultima_Troca_2,
                Ultima_Troca_3 = itens_do_ContratoModel.Ultima_Troca_3,
                Data_Ultima_Troca_3 = itens_do_ContratoModel.Data_Ultima_Troca_3,
                Ultima_Troca_4 = itens_do_ContratoModel.Ultima_Troca_4,
                Data_Ultima_Troca_4 = itens_do_ContratoModel.Data_Ultima_Troca_4,
                Ultima_Troca_5 = itens_do_ContratoModel.Ultima_Troca_5,
                Data_Ultima_Troca_5 = itens_do_ContratoModel.Data_Ultima_Troca_5,
                Ultima_Troca_6 = itens_do_ContratoModel.Ultima_Troca_6,
                Data_Ultima_Troca_6 = itens_do_ContratoModel.Data_Ultima_Troca_6,
                Contador_Geral = itens_do_ContratoModel.Contador_Geral,
                Contato = itens_do_ContratoModel.Contato,
                Telefone = itens_do_ContratoModel.Telefone,
                Bairro = itens_do_ContratoModel.Bairro,
                Andar = itens_do_ContratoModel.Andar,
                Predio = itens_do_ContratoModel.Predio,
                Sala = itens_do_ContratoModel.Sala,
                Departamento = itens_do_ContratoModel.Departamento,
                ContadorAbertura = itens_do_ContratoModel.ContadorAbertura,
                ContadorFechamento = itens_do_ContratoModel.ContadorFechamento,
                Data_Instalacao = itens_do_ContratoModel.Data_Instalacao,
                Contador_Instalacao = itens_do_ContratoModel.Contador_Instalacao,
                CustoPaginaMono = itens_do_ContratoModel.CustoPaginaMono,
                CustoPaginaColor = itens_do_ContratoModel.CustoPaginaColor,
                NotaRemessaLocacao = itens_do_ContratoModel.NotaRemessaLocacao,
                DolarFixo = itens_do_ContratoModel.DolarFixo,
                DolarMesMedio = itens_do_ContratoModel.DolarMesMedio,
                IPMaquina = itens_do_ContratoModel.IPMaquina,
                TipoColeta = itens_do_ContratoModel.TipoColeta,
                ContadorMono = itens_do_ContratoModel.ContadorMono,
                ContadorColor = itens_do_ContratoModel.ContadorColor,
                Acessorio = itens_do_ContratoModel.Acessorio,
                FranquiaColor = itens_do_ContratoModel.FranquiaColor
            };
        }
    }
}
