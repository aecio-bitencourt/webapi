﻿using API.Models;

namespace API.Interfaces
{
    public interface IOperacoesRepo
    {
        Task<List<Almoxarifados>> GetAlmoxarifados();
        Task<List<Centro_de_Custo>> GetCentro_de_Custo();
        Task<List<Clientes>> GetClientes();
        Task<List<Codigos_Movimento>> GetCodigos_Movimento();
        Task<List<Contratos>> GetContratos();
        Task<List<Faturamento_Equipamentos>> GetFaturamento_Equipamentos();
        Task<List<Filiais>> GetFiliais();
        Task<List<Fornecedores>> GetFornecedores();
        Task<List<Grupo_Empresarial>> GetGrupo_Empresarial();
        Task<List<Itens_do_Contrato>> GetItens_do_Contrato();
        Task<List<Itens_do_Contrato_Nota>> GetItens_do_Contrato_Nota();
        Task<List<Itens_Notas>> GetItens_Notas();
        Task<List<Leituras_Equipamentos>> GetLeituras_Equipamentos();
        Task<List<Modelos>> GetModelos();
        Task<List<Notas>> GetNotas();
        Task<List<Produtos>> GetProdutos();
        Task<List<Requisicoes_PecasSuprimentos>> GetRequisicoes_PecasSuprimentos();
        Task<List<Saldos_Estoque>> GetSaldos_Estoque();
        Task<List<Serie_Produtos>> GetSerie_Produtos();
        Task<List<Taxa_Modelo>> GetTaxa_Modelo();
        Task<List<Tipo_Clientes>> GetTipo_Clientes();
        Task<List<Tipo_Produtos>> GetTipo_Produtos();
        Task<List<Tipo_Vendedor>> GetTipo_Vendedor();
        Task<List<Titulos>> GetTitulos();
        Task<List<Vendedores>> GetVendedores();
    }
}
