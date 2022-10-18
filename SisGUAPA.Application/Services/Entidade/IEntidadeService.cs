using System.Collections.Generic;

namespace SisGUAPA.Application.Services.Entidade
{
    public interface IEntidadeService
    {
        Dictionary<int, string> GetTiposEntidade();
    }
}
