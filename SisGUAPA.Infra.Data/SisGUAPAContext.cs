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

        public virtual DbSet<Entidade> Entidades => Set<Entidade>();
        public virtual DbSet<Usuario> Usuarios => Set<Usuario>();

        public bool Save()
        {
            return base.SaveChanges() == 1;
        }
    }
}