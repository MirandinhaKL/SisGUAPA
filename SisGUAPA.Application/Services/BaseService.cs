using SisGUAPA.Application.Logs;
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

        public bool Save(T item, string entity)
        {
            _repository.Insert(item);
            var successSave = _unitOfWork.Save();
            if (!successSave)
                new LogMessage($"Falha ao salvar os dados: {entity}", Util.Enumeracoes.MessageLogType.Error);
            return successSave;
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

            var successSave = _unitOfWork.Save();

            if (!successSave)
            {
                new LogMessage($"Dados excluídos: {nameof(item)}",
                               Util.Enumeracoes.MessageLogType.Information);
            }
        }

        public void Update(T item)
        {
            _repository.Update(item);
            _unitOfWork.Save();
        }
    }
}