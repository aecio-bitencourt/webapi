using API.Models;

namespace API.Interfaces
{
    public interface IOperacoesRepo
    {
        Task<List<Almoxarifados>> GetAlmoxarifados();
        Task<List<Notas>> GetNotas();
        Task<List<Centro_de_Custo>> GetCentro_de_Custo();
        Task<List<Clientes>> GetClientes();
        Task<List<Codigos_Movimento>> GetCodigos_Movimento();
        Task<List<Contratos>> GetContratos();
    }
}
