using API.Dtos;
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
        //Chamada utilizando Procedure
        public async Task<IActionResult> spGetAPIOperacoes(string rota)
        {
            if (rota.ToLower() != "notas" && rota.ToLower() != "almoxarifados" && rota.ToLower() != "centro_de_custo" && rota.ToLower() != "clientes" && rota.ToLower() != "codigos_movimento" && rota.ToLower() != "contratos" && rota.ToLower() != "filiais" && rota.ToLower() != "grupo_empresarial" && rota.ToLower() != "itens_contrato" && rota.ToLower() != "faturamento_eq")
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
                var grupo_empresarialDto = grupo_empresarial.Select(g => g.ToGrupo_Empresarial());
                return Ok(grupo_empresarialDto);
            }
            else if (rota.ToLower() == "itens_contrato")
            {
                var itens_do_contrato_nota = await _operacoesRepo.GetItens_do_Contrato_Nota();
                var itens_do_contrato_notaDto = itens_do_contrato_nota.Select(i => i.ToItens_do_Contrato_Nota());
                return Ok(itens_do_contrato_notaDto);
            }
            else
            {
                var Faturamento_Equipamentos = await _operacoesRepo.GetFaturamento_Equipamentos();
                var Faturamento_EquipamentosDto = Faturamento_Equipamentos.Select(f => f.ToFaturamento_EquipamentosDto());
                return Ok(Faturamento_EquipamentosDto);
            }

        }
    }
}
