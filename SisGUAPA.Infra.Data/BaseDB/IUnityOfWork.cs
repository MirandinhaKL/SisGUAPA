using System;

namespace SisGUAPA.Infra.Data.BaseDB
{
    /*
     * A unidade de trabalho representa uma transação quando usada em camadas de dados. 
     * Normalmente, a unidade de trabalho reverterá a transação se SaveChanges() não tiver sido invocado antes de ser descartado. 
     */
    public interface IUnityOfWork : IDisposable
    {
        bool Save();
    }
}