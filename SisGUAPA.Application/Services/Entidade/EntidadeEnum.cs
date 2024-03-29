﻿using System.ComponentModel;

namespace SisGUAPA.Application.Services.Entidade
{
    public static class EntidadeEnum
    {
        /// <summary>
        /// Classificação das entidades que tem interesse no sistema.
        /// </summary>
        public enum TipoEntidades
        {
            [Description("Associação")]
            Associacao = 0,
            [Description("Canil")]
            Canil = 1,
            [Description("Gatil")]
            Gatil = 2,
            [Description("Lar temporário")]
            LarTemporario = 3,
            [Description("ONG")]
            ONG = 4,
            [Description("Outros")]
            Outros = 5,
            [Description("Prefeitura")]
            Prefeitura = 6,
            [Description("Protetor Individual")]
            ProtetorIndividual = 7
        }
    }
}