using SisGUAPA.Application.Util;
using System.Collections.Generic;

namespace SisGUAPA.Application.Services.Entidade
{
    public class EntidadeService : IEntidadeService
    {
        public Dictionary<int, string> GetTiposEntidade()
        {
            var entidades = new Dictionary<int, string>();

            foreach (Enumeracoes.EnumTipoEntidades item in FuncoesGerais.ConverterEnumParaLista<Enumeracoes.EnumTipoEntidades>())
            {
                var chave = (int)item;
                var valor = item.GetDescricaoEnum();
                entidades.Add(chave, valor);
            }
            return entidades;
        }
    }
}