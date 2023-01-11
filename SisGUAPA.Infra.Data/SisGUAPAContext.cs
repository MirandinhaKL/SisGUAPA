using Microsoft.EntityFrameworkCore;
using SisGUAPA.Domain.Entities;
using SisGUAPA.Infra.Data.BaseDB;

namespace SisGUAPA.Infra.Data
{
    public class SisGUAPAContext : DbContext, IUnityOfWork
    {
        public SisGUAPAContext(DbContextOptions<SisGUAPAContext> options) : base(options) { }

        // Adicionado por causa do Mock do construtor dessa clase.
        public SisGUAPAContext(){}

        public virtual DbSet<Entity> Entitties => Set<Entity>();
        public virtual DbSet<User> Users => Set<User>();

        public bool Save()
        {
            return base.SaveChanges() == 1;
        }
    }
}