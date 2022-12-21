using SisGUAPA.Infra.Data;
using SisGUAPA.Infra.Data.BaseDB;
using System.Linq;

namespace SisGUAPA.Application.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        public IUnityOfWork _unitOfWork;
        private IBaseRepository<T> _repository;

        public BaseService(SisGUAPAContext dataBaseContext)
        {
            _unitOfWork = dataBaseContext;
            _repository = new BaseRepository<T>(_unitOfWork);
        }

        public bool Save(T item)
        {
            _repository.Insert(item);
            return _unitOfWork.Save();
        }

        public T Find(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<T> List()
        {
            return _repository.GetAll();
        }

        public void Remove(T item)
        {
            _repository.Delete(item);
            _unitOfWork.Save();
        }

        public void Update(T item)
        {
            _repository.Update(item);
            _unitOfWork.Save();
        }
    }
}