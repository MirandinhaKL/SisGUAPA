using System.Linq;

namespace SisGUAPA.Application.Services
{
    public interface IBaseService<T> where T : class
    {
        T Find(int id);
        IQueryable<T> List();
        bool Save(T item, string entity);
        void Remove(T item);
        void Update(T item);
    }
}