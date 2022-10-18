/*
* Criado em: 20/01/2020
* Última alteração em: 01/22/2021, 14/10/22
*/
using System;

namespace SisGUAPA.Domain.Entities
{
    public class Usuario
    {
        #region Propriedades
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; } = string.Empty;
        public virtual string Email { get; set; } = string.Empty;
        public virtual string Senha { get; set; } = string.Empty;
        public virtual string Telefone { get; set; } = string.Empty;
        //public virtual int GrauAcesso { get; set; } // ver se será uma classe separada, ou similar ao identity
        public virtual DateTime DataIngresso { get; set; }
        public virtual DateTime DataNascimento { get; set; }
        public virtual string Cargo { get; set; } = string.Empty;
        public virtual string RG { get; set; } = string.Empty;
        public virtual string CPF { get; set; } = string.Empty;
        public virtual int Status { get; set; }
        
        #endregion
    }
}
