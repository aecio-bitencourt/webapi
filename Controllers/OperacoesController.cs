using API.Interfaces;
using API.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/operacoes")]
    [ApiController]
    public class OperacoesController : ControllerBase
    {
        private readonly IOperacoesRepo _operacoesRepo;

        public OperacoesController(IOperacoesRepo operacoesRepo)
        {
            _operacoesRepo = operacoesRepo;
        }

        [HttpGet("{rota}")]
        //Chamada utilizando Procedure spGetAPIOperacoes
        public async Task<IActionResult> spGetAPIOperacoes(string rota)
        {
            if (rota.ToLower() != "almoxarifados" && rota.ToLower() != "centro_de_custo" && rota.ToLower() != "clientes" && rota.ToLower() != "codigos_movimento" && rota.ToLower() != "contratos" && rota.ToLower() != "faturamento_equipamentos" && rota.ToLower() != "filiais" && rota.ToLower() != "fornecedores" && rota.ToLower() != "grupo_empresarial" && rota.ToLower() != "itens_contrato" && rota.ToLower() != "itens_contrato_nota" && rota.ToLower() != "itens_notas" && rota.ToLower() != "leituras_equipamentos" && rota.ToLower() != "modelos" && rota.ToLower() != "notas" && rota.ToLower() != "produtos" && rota.ToLower() != "requisicoes_pecas_suprimentos" && rota.ToLower() != "saldos_estoque" && rota.ToLower() != "serie_produtos" && rota.ToLower() != "taxa_modelo" && rota.ToLower() != "tipo_clientes" && rota.ToLower() != "tipo_produtos" && rota.ToLower() != "tipo_vendedor" && rota.ToLower() != "titulos" && rota.ToLower() != "vendedores")
                return BadRequest();
            
            else if (rota.ToLower() == "almoxarifados")
            {
                var almoxarifados = await _operacoesRepo.GetAlmoxarifados();
                var almoxarifadosDto = almoxarifados.Select(a => a.ToAlmoxarifadosDto());
                return Ok(almoxarifadosDto);
            }

            else if (rota.ToLower() == "centro_de_custo")
            {
                var centro_de_custo = await _operacoesRepo.GetCentro_de_Custo();
                var centro_de_custoDto = centro_de_custo.Select(c => c.ToCentro_de_CustoDto());
                return Ok(centro_de_custoDto);
            }

            else if (rota.ToLower() == "clientes")
            {
                var clientes = await _operacoesRepo.GetClientes();
                var clientesDto = clientes.Select(b => b.ToClientesDto());
                return Ok(clientesDto);
            }

            else if (rota.ToLower() == "codigos_movimento")
            {
                var codigos_movimento = await _operacoesRepo.GetCodigos_Movimento();
                var codigos_movimentoDto = codigos_movimento.Select(c => c.ToCodigos_MovimentoDto());
                return Ok(codigos_movimentoDto);
            }

            else if (rota.ToLower() == "contratos")
            {
                var contratos = await _operacoesRepo.GetContratos();
                var contratosDto = contratos.Select(c => c.ToContratosDto());
                return Ok(contratosDto);
            }

            else if (rota.ToLower() == "faturamento_equipamentos")
            {
                var faturamento_equipamentos = await _operacoesRepo.GetFaturamento_Equipamentos();
                var faturamento_equipamentosDto = faturamento_equipamentos.Select(f => f.ToFaturamento_EquipamentosDto());
                return Ok(faturamento_equipamentosDto);
            }

            else if (rota.ToLower() == "filiais")
            {
                var filiais = await _operacoesRepo.GetFiliais();
                var filiaisDto = filiais.Select(f => f.ToFiliaisDto());
                return Ok(filiaisDto);
            }

            else if (rota.ToLower() == "fornecedores")
            {
                var fornecedores = await _operacoesRepo.GetFornecedores();
                var fornecedoresDto = fornecedores.Select(f => f.ToFornecedoresDto());
                return Ok(fornecedoresDto);
            }

            else if (rota.ToLower() == "grupo_empresarial")
            {
                var grupo_empresarial = await _operacoesRepo.GetGrupo_Empresarial();
                var grupo_empresarialDto = grupo_empresarial.Select(g => g.ToGrupo_EmpresarialDto());
                return Ok(grupo_empresarialDto);
            }

            else if (rota.ToLower() == "itens_contrato")
            {
                var itens_contrato = await _operacoesRepo.GetItens_do_Contrato();
                var itens_do_contratoDto = itens_contrato.Select(i => i.ToItens_do_ContratoDto());
                return Ok(itens_do_contratoDto);
            }

            else if (rota.ToLower() == "itens_contrato_nota")
            {
                var itens_contrato_nota = await _operacoesRepo.GetItens_do_Contrato_Nota();
                var itens_contrato_notaDto = itens_contrato_nota.Select(i => i.ToItens_do_Contrato_NotaDto());
                return Ok(itens_contrato_notaDto);
            }

            else if (rota.ToLower() == "itens_notas")
            {
                var itens_notas = await _operacoesRepo.GetItens_Notas();
                var itens_notasDto = itens_notas.Select(i => i.ToItens_NotasDto());
                return Ok(itens_notasDto);
            }

            else if (rota.ToLower() == "leituras_equipamentos")
            {
                var leituras_equipamentos = await _operacoesRepo.GetLeituras_Equipamentos();
                var leituras_equipamentosDto = leituras_equipamentos.Select(l => l.ToLeituras_EquipamentosDto());
                return Ok(leituras_equipamentosDto);
            }

            else if (rota.ToLower() == "modelos")
            {
                var modelos = await _operacoesRepo.GetModelos();
                var modelosDto = modelos.Select(m => m.ToModelosDto());
                return Ok(modelosDto);
            }

            else if (rota.ToLower() == "notas")
            {
                var notas = await _operacoesRepo.GetNotas();
                var notasDto = notas.Select(n => n.ToNotasDto());
                return Ok(notasDto);
            }

            else if (rota.ToLower() == "produtos")
            {
                var produtos = await _operacoesRepo.GetProdutos();
                var produtosDto = produtos.Select(p => p.ToProdutosDto());
                return Ok(produtosDto);
            }

            else if (rota.ToLower() == "requisicoes_pecas_suprimentos")
            {
                var requisicoes_pecasSuprimentos = await _operacoesRepo.GetRequisicoes_PecasSuprimentos();
                var requisicoes_pecasSuprimentosDto = requisicoes_pecasSuprimentos.Select(r => r.ToRequisicoes_PecasSuprimentosDto());
                return Ok(requisicoes_pecasSuprimentosDto);
            }

            else if (rota.ToLower() == "saldos_estoque")
            {
                var saldos_estoque = await _operacoesRepo.GetSaldos_Estoque();
                var saldos_estoqueDto = saldos_estoque.Select(s => s.ToSaldos_EstoqueDto());
                return Ok(saldos_estoqueDto);
            }

            else if (rota.ToLower() == "serie_produtos")
            {
                var serie_produtos = await _operacoesRepo.GetSerie_Produtos();
                var serie_produtosDto = serie_produtos.Select(s => s.ToSerie_ProdutosDto());
                return Ok(serie_produtosDto);
            }

            else if (rota.ToLower() == "taxa_modelo")
            {
                var taxa_modelo = await _operacoesRepo.GetTaxa_Modelo();
                var taxa_modeloDto = taxa_modelo.Select(s => s.ToTaxa_ModeloDto());
                return Ok(taxa_modeloDto);
            }

            else if (rota.ToLower() == "tipo_clientes")
            {
                var tipo_clientes = await _operacoesRepo.GetTipo_Clientes();
                var tipo_clientesDto = tipo_clientes.Select(t => t.ToTipo_ClientesDto());
                return Ok(tipo_clientesDto);
            }

            else if (rota.ToLower() == "tipo_produtos")
            {
                var tipo_produtos = await _operacoesRepo.GetTipo_Produtos();
                var tipo_produtosDto = tipo_produtos.Select(t => t.ToTipo_ProdutosDto());
                return Ok(tipo_produtosDto);
            }

            else if (rota.ToLower() == "tipo_vendedor")
            {
                var tipo_vendedor = await _operacoesRepo.GetTipo_Vendedor();
                var tipo_vendedorDto = tipo_vendedor.Select(t => t.ToTipo_VendedorDto());
                return Ok(tipo_vendedorDto);
            }

            else if (rota.ToLower() == "titulos")
            {
                var titulos = await _operacoesRepo.GetTitulos();
                var titulosDto = titulos.Select(t => t.ToTitulosDto());
                return Ok(titulosDto);
            }

            else
            {
                var vendedores = await _operacoesRepo.GetVendedores();
                var vendedoresDto = vendedores.Select(t => t.ToVendedoresDto());
                return Ok(vendedoresDto);
            }
        }
    }
}
