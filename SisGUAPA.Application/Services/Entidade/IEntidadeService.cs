using FluentValidation.Results;
using SisGUAPA.Domain.Entities;
using System;
using System.Collections.Generic;
using domain = SisGUAPA.Domain.Entities;

namespace SisGUAPA.Application.Services.Entidade;

/// <summary>
/// Criado em*: 01/01/23
/// Última alteração: 15/02/23
/// </summary>
public interface IEntidadeService
{
    Dictionary<int, string> GetTiposEntidade();

    string SaveEntidade(Entity entity, string entityName);

    string EmailAlreadyUsed(string email);

    Entity GetEntidade(int Id);

    ValidationResult MandatoryFieldValidation(domain.Entity entidade);

    void SaveExceptionLog(string message, Exception exception);
}