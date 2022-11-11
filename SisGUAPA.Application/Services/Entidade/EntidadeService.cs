using FluentValidation;
using FluentValidation.Results;
using SisGUAPA.Application.Util;
using SisGUAPA.Infra.Data;
using System;
using System.Collections.Generic;
using domain = SisGUAPA.Domain.Entities;

namespace SisGUAPA.Application.Services.Entidade
{
    public class EntidadeService : BaseService<domain.Entidade>, IEntidadeService
    {
        private readonly IValidator<domain.Entidade> _validator;
        private readonly SisGUAPAContext _dataBaseContext;

        public EntidadeService(IValidator<domain.Entidade> validator, SisGUAPAContext dataBaseContext) : base(dataBaseContext)
        {
            _validator = validator;
            _dataBaseContext = dataBaseContext;
        }

        public domain.Entidade GetEntidade(Guid Id)
        {
            throw new NotImplementedException();
        }

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

        public bool SalvarEntidade(domain.Entidade entidade)
        {
            var saved = this.Save(entidade);
            if (!saved)
            {
                //TODO: Adiciona erro em arquivo ou no banco?
            }

            return saved;
        }

        public ValidationResult ValidacaoCamposObrigatorios(domain.Entidade entidade)
            => _validator.Validate(entidade);
    }
}