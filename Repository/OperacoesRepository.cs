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
    }
}
