using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SisGUAPA.Domain.Entities
{
    public class Entidade
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string CNPJ { get; set; } = string.Empty;
        public int TipoEntidade { get; set; }
        public int Estado { get; set; }
        public string Telefone { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }

        //public virtual ICollection<Animal> Animais { get; private set; } = new ObservableCollection<Animal>();

    }
}
