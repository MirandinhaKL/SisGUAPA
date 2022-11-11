using SisGUAPA.Domain.Entities;
using SisGUAPA.Infra.Data.BaseDB;
using System;

namespace SisGUAPA.Infra.Data.Repository.Interfaces
{
    internal interface IEntidadeRep : IBaseRepository<Entidade>, IDisposable
    {
        
    }
}
