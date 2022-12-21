using System.Linq;

namespace SisGUAPA.Infra.Data.BaseDB
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        bool Insert(TEntity item);
       
        void Delete(TEntity item);

        IQueryable<TEntity> GetAll();

        TEntity GetById(int id);

        void Update(TEntity item);
    }
}