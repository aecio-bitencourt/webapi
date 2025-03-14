using API.Dtos;
using API.Interfaces;
using API.Mappers;
using API.Models;
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
        //Chamada utilizando Procedure
        public async Task<IActionResult> spGetAPIOperacoes(string rota)
        {
            if (rota.ToLower() != "notas" && rota.ToLower() != "almoxarifados" && rota.ToLower() != "centro_de_custo" && rota.ToLower() != "clientes" && rota.ToLower() != "codigos_movimento" && rota.ToLower() != "contratos" && rota.ToLower() != "filiais" && rota.ToLower() != "grupo_empresarial" && rota.ToLower() != "itens_contrato_nota" && rota.ToLower() != "faturamento_equipamentos" && rota.ToLower() != "itens_contrato" && rota.ToLower() != "fornecedores" && rota.ToLower() != "itens_notas" && rota.ToLower() != "leituras_equipamentos" && rota.ToLower() != "modelos" && rota.ToLower() != "produtos" && rota.ToLower() != "requisicoes_pecas_suprimentos" && rota.ToLower() != "saldos_estoque" && rota.ToLower() != "taxa_modelo")
                return BadRequest();

            if (rota.ToLower() == "notas")
            {
                var notas = await _operacoesRepo.GetNotas();
                var notasDto = notas.Select(n => n.ToNotasDto());
                return Ok(notasDto);
            }
            else if (rota.ToLower() == "almoxarifados")
            {
                var almoxarifados = await _operacoesRepo.GetAlmoxarifados();
                var almoxarifadosDto = almoxarifados.Select(a => a.ToAlmoxarifadosDto());
                return Ok(almoxarifadosDto);
            }
            else if (rota.ToLower() == "centro_de_custo")
            {
                var Centro_de_Custo = await _operacoesRepo.GetCentro_de_Custo();
                var Centro_de_CustoDto = Centro_de_Custo.Select(c => c.ToCentro_de_CustoDto());
                return Ok(Centro_de_CustoDto);
            }
            else if (rota.ToLower() == "clientes")
            {
                var Clientes = await _operacoesRepo.GetClientes();
                var ClientesDto = Clientes.Select(b => b.ToClientesDto());
                return Ok(ClientesDto);
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
            else if (rota.ToLower() == "filiais")
            {
                var filiais = await _operacoesRepo.GetFiliais();
                var filiaisDto = filiais.Select(f => f.ToFiliaisDto());
                return Ok(filiaisDto);
            }
            else if (rota.ToLower() == "grupo_empresarial")
            {
                var grupo_empresarial = await _operacoesRepo.GetGrupo_Empresarial();
                var grupo_empresarialDto = grupo_empresarial.Select(g => g.ToGrupo_EmpresarialDto());
                return Ok(grupo_empresarialDto);
            }
            else if (rota.ToLower() == "itens_contrato_nota")
            {
                var itens_do_contrato_nota = await _operacoesRepo.GetItens_do_Contrato_Nota();
                var itens_do_contrato_notaDto = itens_do_contrato_nota.Select(i => i.ToItens_do_Contrato_NotaDto());
                return Ok(itens_do_contrato_notaDto);
            }
            else if (rota.ToLower() == "faturamento_equipamentos")
            {
                var Faturamento_Equipamentos = await _operacoesRepo.GetFaturamento_Equipamentos();
                var Faturamento_EquipamentosDto = Faturamento_Equipamentos.Select(f => f.ToFaturamento_EquipamentosDto());
                return Ok(Faturamento_EquipamentosDto);
            }
            else if (rota.ToLower() == "itens_contrato")
            {
                var Itens_do_Contrato = await _operacoesRepo.GetItens_do_Contrato();
                var Itens_do_ContratoDto = Itens_do_Contrato.Select(i => i.ToItens_do_ContratoDto());
                return Ok(Itens_do_ContratoDto);
            }
            else if (rota.ToLower() == "itens_notas")
            {
                var Itens_Notas = await _operacoesRepo.GetItens_Notas();
                var Itens_NotasDto = Itens_Notas.Select(i => i.ToItens_NotasDto());
                return Ok(Itens_Notas);
            }
            else if (rota.ToLower() == "fornecedores")
            {
                var fornecedores = await _operacoesRepo.GetFornecedores();
                var fornecedoresDto = fornecedores.Select(f => f.ToFornecedoresDto());
                return Ok(fornecedoresDto);
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
            else if (rota.ToLower() == "produtos")
            {
                var produtos = await _operacoesRepo.GetProdutos();
                var produtosDto = produtos.Select(p => p.ToProdutosDto());
                return Ok(produtosDto);
            }
            else if (rota.ToLower() == "requisicoes_pecas_suprimentos")
            {
                var Requisicoes_PecasSuprimentos = await _operacoesRepo.GetRequisicoes_PecasSuprimentos();
                var Requisicoes_PecasSuprimentosDto = Requisicoes_PecasSuprimentos.Select(r => r.ToRequisicoes_PecasSuprimentosDto());
                return Ok(Requisicoes_PecasSuprimentosDto);
            }
            else if (rota.ToLower() == "saldos_estoque")
            {
                var Saldos_Estoque = await _operacoesRepo.GetSaldos_Estoque();
                var Saldos_EstoqueDto = Saldos_Estoque.Select(s => s.ToSaldos_EstoqueDto());
                return Ok(Saldos_EstoqueDto);
            }
            else
            {
                var Taxa_Modelo = await _operacoesRepo.GetTaxa_Modelo();
                var Taxa_ModeloDto = Taxa_Modelo.Select(s => s.ToTaxa_ModeloDto());
                return Ok(Taxa_ModeloDto);
            }
        }
    }
}
