using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

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

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public bool Insert(T item)
        {
            var saved = _context.Set<T>().Add(item);
            return saved.State == EntityState.Added;
        }

        public void Delete(T item)
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