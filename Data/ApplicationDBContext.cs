using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {

        }

        public DbSet<Almoxarifados> Almoxarifados { get; set; }
        public DbSet<Centro_de_Custo> Centro_de_Custo { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Codigos_Movimento> Codigos_Movimento { get; set; }
        public DbSet<Contratos> Contratos { get; set; }
        public DbSet<Faturamento_Equipamentos> Faturamento_Equipamentos { get; set; }
        public DbSet<Filiais> Filiais { get; set; }
        public DbSet<Fornecedores> Fornecedores { get; set; }
        public DbSet<Grupo_Empresarial> Grupo_Empresarial { get; set; }
        public DbSet<Itens_do_Contrato> Itens_do_Contrato { get; set; }
        public DbSet<Itens_do_Contrato_Nota> Itens_do_Contrato_Nota { get; set; }
        public DbSet<Itens_Notas> Itens_Notas { get; set; }
        public DbSet<Leituras_Equipamentos> Leituras_Equipamentos { get; set; }
        public DbSet<Modelos> Modelos { get; set; }
        public DbSet<Notas> Notas { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Requisicoes_PecasSuprimentos> Requisicoes_PecasSuprimentos { get; set; }
        public DbSet<Saldos_Estoque> Saldos_Estoque { get; set; }
        public DbSet<Serie_Produtos> Serie_Produtos { get; set; }
        public DbSet<Taxa_Modelo> Taxa_Modelo { get; set; }
        public DbSet<Tipo_Clientes> Tipo_Clientes { get; set; }
        public DbSet<Tipo_Produtos> Tipo_Produtos { get; set; }
        public DbSet<Tipo_Vendedor> Tipo_Vendedor { get; set; }
        public DbSet<Titulos> Titulos { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
    }
}
