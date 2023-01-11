using FluentValidation;
using SisGUAPA.Application.Util;
using SisGUAPA.Domain.Entities;
using SisGUAPA.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SisGUAPA.Application.Services.Entidade;

/// <summary>
/// Criado em*: 01/01/23
/// Última alteração: 10/01/23
/// </summary>
public class EntidadeService : BaseService<Entity>, IEntidadeService
{
    private readonly IValidator<Entity> _validator;
    private readonly SisGUAPAContext _dataBaseContext;

    public EntidadeService(IValidator<Entity> validator, SisGUAPAContext dataBaseContext) : base(dataBaseContext)
    {
        _validator = validator;
        _dataBaseContext = dataBaseContext;
    }

    public Entity GetEntidade(int Id)
        => _dataBaseContext.Entitties.Where(ent => ent.Id == Id).FirstOrDefault();

    public Dictionary<int, string> GetTiposEntidade()
    {
        var entidades = new Dictionary<int, string>();

        foreach (EntidadeEnum.TipoEntidades item in FuncoesGerais.ConverterEnumParaLista<EntidadeEnum.TipoEntidades>())
        {
            var chave = (int)item;
            var valor = item.GetDescricaoEnum();
            entidades.Add(chave, valor);
        }
        return entidades;
    }

    public string SaveEntidade(Entity entidade)
    {
        if (EmailAlreadyUsed(entidade.Email))
            return "E-mail já cadastrado no sistema.";
        
        var saved = this.Save(entidade);
        if (!saved)
            return "Falha ao salvar os dados da entidade";

        return string.Empty;
    }

    FluentValidation.Results.ValidationResult IEntidadeService.MandatoryFieldValidation(Entity entidade)
      => _validator.Validate(entidade);

    public bool EmailAlreadyUsed(string email)
        =>  _dataBaseContext.Entitties.Where(ent => ent.Email.ToLower().Equals(email.ToLower())).Any();
}