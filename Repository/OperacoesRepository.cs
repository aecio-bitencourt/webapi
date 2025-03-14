using API.Data;
using API.Interfaces;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class OperacoesRepository : IOperacoesRepo
    {
        private readonly ApplicationDBContext _context;
        public OperacoesRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public Task<List<Almoxarifados>> GetAlmoxarifados()
        {
            return _context.Almoxarifados
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"almoxarifados"}")
                .ToListAsync();
        }

        public Task<List<Notas>> GetNotas()
        {
            return _context.Notas
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"notas"}")
                .ToListAsync();
        }

        public Task<List<Centro_de_Custo>> GetCentro_de_Custo()
        {
            return _context.Centro_de_Custo
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"centro_de_custo"}")
                .ToListAsync();
        }

        public Task<List<Clientes>> GetClientes()
        {
            return _context.Clientes
                .FromSqlInterpolated($"EXEC SpGetAPIOperacoes @rota = {"clientes"}")
                .ToListAsync();
        }

        public Task<List<Codigos_Movimento>> GetCodigos_Movimento()
        {
            return _context.Codigos_Movimento
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"codigos_movimento"}")
                .ToListAsync();
        }

        public Task<List<Contratos>> GetContratos()
        {
            return _context.Contratos
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"contratos"}")
                .ToListAsync();
        }

        public Task<List<Filiais>> GetFiliais()
        {
            return _context.Filiais
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"filiais"}")
                .ToListAsync();
        }

        public Task<List<Grupo_Empresarial>> GetGrupo_Empresarial()
        {
            return _context.Grupo_Empresarial
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"grupo_empresarial"}")
                .ToListAsync();
        }

        public Task<List<Itens_do_Contrato_Nota>> GetItens_do_Contrato_Nota()
        {
            return _context.Itens_do_Contrato_Nota
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"itens_contrato_nota"}")
                .ToListAsync();
        }

        public Task<List<Faturamento_Equipamentos>> GetFaturamento_Equipamentos()
        {
            return _context.Faturamento_Equipamentos
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"faturamento_equipamentos"}")
                .ToListAsync();
        }

        public Task<List<Itens_do_Contrato>> GetItens_do_Contrato()
        {
            return _context.Itens_do_Contrato
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"itens_contrato"}")
                .ToListAsync();
        }

        public Task<List<Fornecedores>> GetFornecedores()
        {
            return _context.Fornecedores
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"fornecedores"}")
                .ToListAsync();
        }

        public Task<List<Itens_Notas>> GetItens_Notas()
        {
            return _context.Itens_Notas
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"itens_notas"}")
                .ToListAsync();
        }

        public Task<List<Leituras_Equipamentos>> GetLeituras_Equipamentos()
        {
            return _context.Leituras_Equipamentos
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"leituras_equipamentos"}")
                .ToListAsync();
        }

        public Task<List<Modelos>> GetModelos()
        {
            return _context.Modelos
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"modelos"}")
                .ToListAsync();
        }

        public Task<List<Produtos>> GetProdutos()
        {
            return _context.Produtos
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"produtos"}")
                .ToListAsync();
        }

        public Task<List<Requisicoes_PecasSuprimentos>> GetRequisicoes_PecasSuprimentos()
        {
            return _context.Requisicoes_PecasSuprimentos
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"requisicoes_pecas_suprimentos"}")
                .ToListAsync();
        }

        public Task<List<Saldos_Estoque>> GetSaldos_Estoque()
        {
            return _context.Saldos_Estoque
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"saldos_estoque"}")
                .ToListAsync();
        }

        public Task<List<Serie_Produtos>> GetSerie_Produtos()
        {
            return _context.Serie_Produtos
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"serie_produtos"}")
                .ToListAsync();
        }

        public Task<List<Taxa_Modelo>> GetTaxa_Modelo()
        {
            return _context.Taxa_Modelo
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"taxa_modelo"}")
                .ToListAsync();
        }

        public Task<List<Tipo_Clientes>> GetTipo_Clientes()
        {
            return _context.Tipo_Clientes
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"tipo_clientes"}")
                .ToListAsync();
        }
        public Task<List<Tipo_Vendedor>> GetTipo_Vendedor()
        {
            return _context.Tipo_Vendedor
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"tipo_vendedor"}")
                .ToListAsync();
        }
        public Task<List<Titulos>> GetTitulos()
        {
            return _context.Titulos
                .FromSqlInterpolated($"EXEC spGetAPIOperacoes @rota = {"titulos"}")
                .ToListAsync();
        }
    }
}
