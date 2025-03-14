using API.Dtos.Serie_Produtos;
using API.Models;

namespace API.Mappers
{
    public static class Serie_ProdutosMappers
    {
        public static Serie_ProdutosDto ToSerie_ProdutosDto(this Serie_Produtos serieprodutosModel)
        {
            return new Serie_ProdutosDto
            {
                Produto = serieprodutosModel.Produto,
                Nota_Entrada = serieprodutosModel.Nota_Entrada,
                Data_Nota_Entrada = serieprodutosModel.Data_Nota_Entrada,
                Nota_Saida = serieprodutosModel.Nota_Saida,
                Data_Nota_Saida = serieprodutosModel.Data_Nota_Saida,
                Serie_Nota_Saida = serieprodutosModel.Serie_Nota_Saida,
                Serie_Nota_Entrada = serieprodutosModel.Serie_Nota_Entrada,
                Filial = serieprodutosModel.Filial,
                Cliente = serieprodutosModel.Cliente,
                Fornecedor = serieprodutosModel.Fornecedor,
                Numero_Serie = serieprodutosModel.Numero_Serie,
                Lote = serieprodutosModel.Lote,
                Data_Fabricacao = serieprodutosModel.Data_Fabricacao,
                Pedido = serieprodutosModel.Pedido,
                Almoxarifado = serieprodutosModel.Almoxarifado,
                AlmoxarifadoTRF_Nota_Saida = serieprodutosModel.AlmoxarifadoTRF_Nota_Saida,
                Condicoes_Embalagem = serieprodutosModel.Condicoes_Embalagem,
                Condicoes_Carcaca = serieprodutosModel.Condicoes_Carcaca,
                Limpeza = serieprodutosModel.Limpeza,
                Numero_Recarga = serieprodutosModel.Numero_Recarga,
                Data_Prevista_Saida = serieprodutosModel.Data_Prevista_Saida,
                Partes_Trocadas = serieprodutosModel.Partes_Trocadas,
                Observacao_Entrada = serieprodutosModel.Observacao_Entrada,
                Observacao_Saida = serieprodutosModel.Observacao_Saida,
                Contador = serieprodutosModel.Contador
            };
        }
    }
}
