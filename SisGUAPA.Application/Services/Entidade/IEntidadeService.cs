using domain = SisGUAPA.Domain.Entities;
using System;
using System.Collections.Generic;
using FluentValidation.Results;

namespace SisGUAPA.Application.Services.Entidade
{
    public interface IEntidadeService
    {
        Dictionary<int, string> GetTiposEntidade();
        string SaveEntidade(domain.Entidade entidade);
        bool EmailAlreadyUsed(string email);
        domain.Entidade GetEntidade(Guid Id);
        ValidationResult MandatoryFieldValidation(domain.Entidade entidade);
    }
}