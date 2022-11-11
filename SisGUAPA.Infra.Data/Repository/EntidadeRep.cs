using SisGUAPA.Domain.Entities;
using SisGUAPA.Infra.Data.BaseDB;
using SisGUAPA.Infra.Data.Repository.Interfaces;

namespace SisGUAPA.Infra.Data.Repository
{
    public class EntidadeRep : BaseRepository<Entidade>, IEntidadeRep
    {
        private readonly IUnityOfWork _unitOfWork;

        public EntidadeRep(IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            _unitOfWork = unityOfWork;
        }
    }
}
