using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisGUAPA.Infra.Data.BaseDB
{
    public class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : class
    {
        private SisGUAPAContext _context;

        public BaseRepository(IUnityOfWork unityOfWork)
        {
            if (unityOfWork is null)
                throw new ArgumentNullException("unitOfWork");

            _context = unityOfWork as SisGUAPAContext;
        }

        public T Find(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> List()
        {
            return _context.Set<T>();
        }

        public bool Add(T item)
        {
            var saved = _context.Set<T>().Add(item);
            return saved.State == EntityState.Added;
        }

        public void Remove(T item)
        {
            _context.Set<T>().Remove(item);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}