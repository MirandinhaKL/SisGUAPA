using Microsoft.EntityFrameworkCore;
using SisGUAPA.Domain.Entities;
using SisGUAPA.Infra.Data.BaseDB;

namespace SisGUAPA.Infra.Data
{
    public class SisGUAPAContext : DbContext, IUnityOfWork
    {
        //public SisGUAPAContext(DbContextOptions options) : base(options)
        //{

        //}

        public SisGUAPAContext(DbContextOptions<SisGUAPAContext> options) : base(options) { }

        public DbSet<Entidade> Entidades => Set<Entidade>();
        public DbSet<Usuario> Usuarios => Set<Usuario>();

        public bool Save()
        {
            return base.SaveChanges() == 1;
        }
    }
}