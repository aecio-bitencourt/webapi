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

        public DbSet<Notas> Notas { get; set; }
        public DbSet<Almoxarifados> Almoxarifados { get; set; }
        public DbSet<Centro_de_Custo> Centro_de_Custo { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Codigos_Movimento> Codigos_Movimento { get; set; }
        public DbSet<Contratos> Contratos { get; set; }
        public DbSet<Filiais> Filiais { get; set; }
    }
}
