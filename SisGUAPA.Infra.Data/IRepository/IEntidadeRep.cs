using SisGUAPA.Domain.Entities;
using SisGUAPA.Infra.Data.BaseDB;
using System;

namespace SisGUAPA.Infra.Data.Repository.Interfaces
{
    public interface IEntidadeRep : IBaseRepository<Entidade>, IDisposable
    {
        
    }
}
