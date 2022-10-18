using Microsoft.EntityFrameworkCore;
using SisGUAPA.Domain.Entities;

namespace SisGUAPA.Infra.Data
{
    public class SisGUAPAContext : DbContext
    {
        public DbSet<Entidade> Entidades => Set<Entidade>();
        public DbSet<Usuario> Usuarios => Set<Usuario>();

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=sisguapa_sqlite.db");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
