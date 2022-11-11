/*
* Criado em: 20/01/2020
* Última alteração em: 24/10/22
*/
using System;
using System.ComponentModel.DataAnnotations;

namespace SisGUAPA.Domain.Entities
{
    public class Usuario
    {
        #region Propriedades
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Senha { get; set; } = string.Empty;

        [MaxLength(13)]
        public string Telefone { get; set; } = string.Empty;

        //public virtual int GrauAcesso { get; set; } // ver se será uma classe separada, ou similar ao identity
        
        public DateTime DataIngresso { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Cargo { get; set; } = string.Empty;

        public string RG { get; set; } = string.Empty;

        public string CPF { get; set; } = string.Empty;

        public int Status { get; set; }
        
        #endregion
    }
}
