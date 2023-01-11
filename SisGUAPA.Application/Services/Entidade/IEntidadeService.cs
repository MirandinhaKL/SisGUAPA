using FluentValidation.Results;
using SisGUAPA.Domain.Entities;
using System.Collections.Generic;
using domain = SisGUAPA.Domain.Entities;

namespace SisGUAPA.Application.Services.Entidade;

/// <summary>
/// Criado em*: 01/01/23
/// Última alteração: 10/01/23
/// </summary>
public interface IEntidadeService
{
    Dictionary<int, string> GetTiposEntidade();
    string SaveEntidade(domain.Entity entidade);
    bool EmailAlreadyUsed(string email);
    Entity GetEntidade(int Id);
    ValidationResult MandatoryFieldValidation(domain.Entity entidade);
}