using Microsoft.EntityFrameworkCore;
using SisGUAPA.Domain.Entities;

namespace SisGUAPA.Infra.Data
{
    public class AnimalContext : DbContext
    {
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Entidade> Entidades { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=sisguapa_sqlite.db");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
