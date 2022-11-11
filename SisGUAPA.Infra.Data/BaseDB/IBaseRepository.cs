using System.Linq;

namespace SisGUAPA.Infra.Data.BaseDB
{
    public interface IBaseRepository<T> where T : class
    {
        T Find(int id);

        IQueryable<T> List();

        bool Add(T item);

        void Remove(T item);

        void Update(T item);
    }
}