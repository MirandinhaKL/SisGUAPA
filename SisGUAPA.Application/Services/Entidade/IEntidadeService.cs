using domain = SisGUAPA.Domain.Entities;
using System;
using System.Collections.Generic;
using FluentValidation.Results;

namespace SisGUAPA.Application.Services.Entidade
{
    public interface IEntidadeService
    {
        Dictionary<int, string> GetTiposEntidade();

        bool SalvarEntidade(domain.Entidade entidade);

        domain.Entidade GetEntidade(Guid Id);

        ValidationResult ValidacaoCamposObrigatorios(domain.Entidade entidade);
    }
}