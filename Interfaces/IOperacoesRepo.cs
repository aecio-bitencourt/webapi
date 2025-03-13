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
        Task<List<Filiais>> GetFiliais();
        Task<List<Grupo_Empresarial>> GetGrupo_Empresarial();
        Task<List<Itens_do_Contrato_Nota>> GetItens_do_Contrato_Nota();
        Task<List<Faturamento_Equipamentos>> GetFaturamento_Equipamentos();
        Task<List<Itens_do_Contrato>> GetItens_do_Contrato();
        Task<List<Fornecedores>> GetFornecedores();
        Task<List<Itens_Notas>> GetItens_Notas();
        Task<List<Leituras_Equipamentos>> GetLeituras_Equipamentos();
        Task<List<Modelos>> GetModelos();
        Task<List<Produtos>> GetProdutos();
    }
}
