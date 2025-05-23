USE [Gomaq]
GO
/****** Object:  StoredProcedure [dbo].[spGetAPIOperacoes]    Script Date: 13/03/2025 14:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spGetAPIOperacoes]
@rota VARCHAR(40)
AS
BEGIN
SET NOCOUNT ON;

IF @rota = 'almoxarifados'
BEGIN
SELECT		Codigo, 
            Filial, 
            Nome, 
            Ult_Qtd, 
            Ult_Custo, 
            Almoxarifado_de_Venda
FROM Almoxarifados
END

ELSE IF @rota = 'centro_de_custo'
BEGIN 
SELECT		Codigo,
			Nome
FROM Centro_de_Custo
END

ELSE IF @rota = 'clientes'
BEGIN
SELECT	Codigo,  
		Nome, 
		CGC AS CNPJ, 
		Inscricao, 
		Endereco, 
		CEP, 
		Estado, 
		Contato, 
		Telefone, 
		Tipo_Cliente AS Tipo_do_Cliente, 
		Regiao, 
		Endereco_Cobranca AS Endereco_de_Cobranca, 
		Bairro_Cobranca AS Bairro_de_Cobranca, 
		CEP_Cobranca AS CEP_de_Cobranca, 
		Municipio_Cobranca AS Municipio_de_Cobranca, 
		Estado_Cobranca AS Estado_de_Cobranca, 
		Vendedor, 
		Telefone_Cobranca AS Telefone_de_Cobranca, 
		Contato_Cobranca AS Contato_de_Cobranca, 
		Endereco_Cobranca AS Endereco_de_Entrega, 
		Bairro_Entrega AS Bairro_de_Entrega, 
		CEP_Entrega AS CEP_de_Entrega, 
		Municipio_Entrega AS Municipio_de_Entrega, 
		Estado_Entrega AS Estado_de_Entrega, 
		Pais_Entrega AS Pais_de_Entrega, 
		Telefone_Entrega AS Telefone_de_Entrega, 
		Contato_Entrega AS Contato_de_Entrega, 
		Departamento1, 
		Centro_de_Custo, 
		Grupo_Empresarial, 
		Codigo_Matriz, 
		Email  
FROM Clientes
END

ELSE IF @rota = 'codigos_movimento'
BEGIN
SELECT	Codigo,
		Nome,
		Almoxarifado
FROM Codigos_Movimento
END

ELSE IF @rota = 'contratos'
BEGIN
SELECT	Codigo, 
		Tipo_de_Contrato,
		Cliente,
		Valor,
		Data_Primeiro_Pagamento,
		Dia_do_Vencimento,
		Periodo_de_Reajuste,
		Taxa_de_Reajuste,
		Contrato_Assinado,
		Opcao_de_Compra,
		Prazo,
		Observacao,
		Data_Inicio,
		Data_Termino,
		Situacao,
		Data_Ultima_Nota,
		Vendedor,
		Vendedor2,
		Filial,
		Centro_Custo,
		Data_Alteracao,
		Ultima_Nota,
		Ultimo_Periodo,
		Valor_Total,
		Data_Assinatura,
		Data_Reajuste,
		Moeda_Reajuste,
		Departamento,
		NotaRemessaLocacao,
		TemVariacaoCambial,
		SoftwareBilhetagem,
		DolarContrato,
		FranquiaMono,
		FranquiaColor,
		RelatorioClienteInativo
FROM Contratos
END

ELSE IF @rota = 'faturamento_equipamentos'
BEGIN
SELECT	Cliente,
		Contrato,
		Mes,
		Produto,
		NumeroSerie,
		VariacaoCambial,
		IPMaquina,
		Departamento,
		CustoPaginaMono,
		CustoPaginaColor,
		TaxaFixa,
		ContadorAcumMono,
		ContadorAcumColor,
		PaginasMesMono,
		PaginasMesColor,
		ValorTotal
FROM Faturamento_Equipamentos
END

ELSE IF @rota = 'filiais'
BEGIN
SELECT	Codigo,
		Nome,
		CGC,
		Estado,
		Endereco,
		CEP,
		Cidade,
		Inscricao,
		Bairro,
		Fax,
		Codigo_Movimento_Padrao,
		Almoxarifado_Padrao,
		Percentual_Iss,
		Inscricao_Municipal,
		Email
FROM Filiais
END

ELSE IF @rota = 'fornecedores'
BEGIN
SELECT	ISNULL(Codigo,'') AS Codigo,
		Nome,
		CGC,
		Inscricao,
		Endereco,
		Municipio,
		Estado,
		CEP,
		Contato,
		Telefone,
		Fax,
		Ult_Documento,
		Ult_DataDoc,
		Ult_Oper,
		Ult_Qtd,
		Ult_Custo,
		Icm,
		Telex,
		Bairro,
		Data_Ult_Mov,
		Observacao,
		Tipo_Fornecedor,
		Centro_de_Custo,
		Conta_Contabil,
		Representante,
		Contato_Representante,
		Telefone_Representante,
		Condicao_Despacho,
		Fax_Representante,
		Moeda,
		Codigo_Cliente,
		TimeStamp_w,
		Email,
		Inativo,
		Ult_Documento1,
		Ult_Document1,
		Fax__Representante,
		Fantasia,
		Numero_Proxima_Rr,
		Taxa_Distribuidor,
		Substituido,
		Numero,
		Complemento,
		PercentualSimplesFornecedor,
		Data_Alteracao_Cadastro_Fornecedor,
		PastaDriversDownload,
		CodigoFabricanteProdutoMesmoDoFornecedor,
		Conta_Contabil_Despesa,
		Retido_ISS,
		Retido_INSS,
		Retido_IRRF,
		Retido_PIS,
		Retido_COFINS,
		Retido_CSLL,
		codigo_movimento,
		Banco,
		Agencia,
		ContaCorrente
FROM Fornecedores
END

ELSE IF @rota = 'grupo_empresarial'
BEGIN
SELECT	Codigo,
		Nome
FROM Grupo_Empresarial
END

ELSE IF @rota = 'itens_contrato'
BEGIN
SELECT	ISNULL(Contrato, '') AS Contrato,
		Produto,
		Serie,
		Observacao,
		Endereco,
		Cidade,
		Estado,
		CEP,
		Qtd,
		Preco,
		Franquia,
		Qtd_Copias_Revisao,
		Val_excedente_Copias,
		Vu_Revelador,
		Vu_Cilindro,
		Vu_Kit_Manutencao_I,
		Vu_Kit_Manutencao_II,
		Vu_Kit_Aquecimento_I,
		Vu_Kit_Aquecimento_II,
		Ultima_Troca_1,
		Data_Ultima_Troca_1,
		Ultima_Troca_2,
		Data_Ultima_Troca_2,
		Ultima_Troca_3,
		Data_Ultima_Troca_3,
		Ultima_Troca_4,
		Data_Ultima_Troca_4,
		Ultima_Troca_5,
		Data_Ultima_Troca_5,
		Ultima_Troca_6,
		Data_Ultima_Troca_6,
		Contador_Geral,
		Contato,
		Telefone,
		Bairro,
		Andar,
		Predio,
		Sala,
		Departamento,
		ContadorAbertura,
		ContadorFechamento,
		Data_Instalacao,
		Contador_Instalacao,
		CustoPaginaMono,
		CustoPaginaColor,
		NotaRemessaLocacao,
		DolarFixo,
		DolarMesMedio,
		IPMaquina,
		TipoColeta,
		ContadorMono,
		ContadorColor,
		Acessorio,
		FranquiaColor
FROM Itens_do_Contrato
END

ELSE IF @rota = 'itens_contrato_nota'
BEGIN
SELECT	Contrato,
		Produto,
		Serie,
		Qtd,
		Preco,
		Descricao
FROM Itens_do_Contrato_Nota
END

ELSE IF @rota = 'itens_notas'
BEGIN
SELECT	ISNULL(Nota,'') AS Nota,
		Produto,
		Quantidade,
		Preco_Unitario,
		Custo,
		Custo_Dol,
		Filial,
		Almoxarifado,
		Pedido,
		Preco_Total,
		Saldo_Anterior,
		Saldo_Atual,
		Custo_Atual_Cru,
		Custo_Atual_Dol,
		Data_Nota,
		Codigo_Movimento,
		Cliente_Fornecedor,
		Tipo,
		Serie,
		Centro_de_Custo,
		Tipo_Produto
FROM Itens_Notas
END

ELSE IF @rota = 'leituras_equipamentos'
BEGIN
SELECT	Contrato,
		Equipamento,
		Numero_Serie,
		Data_Leitura,
		TipoLeitura,
		Informante,
		Observacao,
		Contador,
		ContadorMono,
		ContadorColor
FROM Leituras_Equipamentos
END

ELSE IF @rota = 'modelos'
BEGIN 
SELECT  Nome,
		Codigo,
		Inativo,
		EstimativaAtendimento
FROM Modelos
END

IF @rota = 'notas'
BEGIN
SELECT		Nota, 
            Filial, 
            Almoxarifado, 
            Serie, 
            Codigo_Movimentacao, 
            Cliente_Fornecedor, 
            Contabilizacao, 
            Emissao, 
            Total_Nota, 
            Descontos, 
            Acrescimos, 
            Vendedor, 
            Pedido, 
            Tipo, 
            Tipo_Nota, 
            Centro_de_Custo, 
            Endereco_Entrega, 
            Estado_Entrega, 
            Cep_Entrega, 
            Contato, 
            Natureza_Operacao, 
            Bairro_Entrega, 
            Numero_Serie_NotaAtivo, 
            Municipio_Entrega, 
            NumeroEntrega, 
            Historico1, 
            Historico2, 
            Historico3, 
            Historico4, 
            Frete, 
            RetencaoCofins, 
            RetencaoCSll, 
            RetencaoPis, 
            ValorRetencaoIRRF, 
            ValorRetencaoISS, 
            Complemento, 
            Valor_Titulo_COFINS, 
            Valor_Titulo_CSLL, 
            Valor_Titulo_INSS, 
            Valor_Titulo_IRRF, 
            Valor_Titulo_PIS, 
            Total_Servicos, 
            Total_IPI
FROM Notas
WHERE Emissao >= '2025-01-01'
END

ELSE IF @rota = 'produtos'
BEGIN
SELECT	ISNULL(Codigo,'') AS Codigo,
		Descricao,
		Fabricante,
		Tipo_Produto,
		Estoque_Minimo,
		Estoque_Maximo,
		Tabela_Fabricante,
		Numero_Nota_Ultima,
		Data_Nota_Ultima,
		Modelo,
		Durabilidade
FROM Produtos
END

ELSE IF @rota = 'requisicoes_pecas_suprimentos'
BEGIN
SELECT  ID, 
		Numero_Serie, 
		Equipamento, 
		Suprimento, 
		Usuario, 
		Cliente, 
		Situacao,
		Quantidade, 
		DataHoraAbertura, 
		DataFaturamento, 
		Pedido, 
		Nota, 
		Filial,
		DataPedido, 
		Contrato,
		EmailContato
FROM Requisicoes_PecasSuprimentos
END

ELSE IF @rota = 'saldos_estoque'
BEGIN
SELECT  ISNULL(Produto, '') AS Produto, 
		Almoxarifado, 
		Filial, 
		Saldo, 
		Saldo_Terceiros, 
		Custo, 
		Empenho, 
		Pendente, 
		Data_Ult_Mov
FROM Saldos_Estoque
END

ELSE IF @rota = 'serie_produtos'
BEGIN
SELECT	ISNULL(Produto,'') AS Produto,
		Nota_Entrada,
		Data_Nota_Entrada,
		Nota_Saida,
		Data_Nota_Saida,
		Serie_Nota_Saida,
		Serie_Nota_Entrada,
		Filial,
		Cliente,
		Fornecedor,
		Numero_Serie,
		Lote,
		Data_Fabricacao,
		Pedido,
		Almoxarifado,
		AlmoxarifadoTRF_Nota_Saida,
		Condicoes_Embalagem,
		Condicoes_Carcaca,
		Limpeza,
		Numero_Recarga,
		Data_Prevista_Saida,
		Partes_Trocadas,
		Observacao_Entrada,
		Observacao_Saida,
		Contador
FROM Serie_Produtos
END

ELSE IF @rota = 'taxa_modelo'
BEGIN
SELECT	ISNULL(Modelo,'') AS Modelo,
		Dia,
		Cotacao,
		Data_Ult_Mov,
		TimeStap_w
FROM Taxa_Modelo
END

ELSE IF @rota = 'tipo_clientes'
BEGIN
SELECT	Nome,
		Codigo,
		Desconto,
		Acrescimo
FROM Tipo_Clientes
END

ELSE IF @rota = 'tipo_produtos'
BEGIN
SELECT	Codigo,
		Nome,
		Desconto,
		Acrescimo,
		Fabricante,
		Grupo
FROM Tipo_Produtos
END

ELSE IF @rota = 'tipo_vendedor'
BEGIN
SELECT	Nome,
		Codigo
FROM Tipo_Vendedor
END

ELSE IF @rota = 'titulos'
BEGIN
SELECT  ISNULL(Codigo,'') AS Codigo,
		Sacado, 
		Tipo, 
		Valor, 
		Filial, 
		Vencimento, 
		Emissao, 
		Codigo_Emissao, 
		Vendedor, 
		Valor_Nota, 
		Nota
FROM Titulos
END

ELSE IF @rota = 'vendedores'
BEGIN
SELECT	Nome,
		Codigo,
		email,
		Centro_de_Custo
FROM vendedores
END

ELSE
BEGIN
RAISERROR ('Rota inválida', 16, 1);
END
END
