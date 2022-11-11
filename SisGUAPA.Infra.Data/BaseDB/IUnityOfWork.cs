using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisGUAPA.Infra.Data.BaseDB
{
    public interface IUnityOfWork
    {
        bool Save();
    }
}