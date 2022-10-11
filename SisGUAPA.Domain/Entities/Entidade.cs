using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SisGUAPA.Domain.Entities
{
    public class Entidade
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        //public string Email { get; set; }
        //public string Senha { get; set; }
        //public string CNPJ { get; set; }
        //public int TipoEntidade { get; set; }
        //public int Estado { get; set; }
        //public string Telefone { get; set; }
        //public DateTime DataCadastro { get; set; }

        public virtual ICollection<Animal> Animais { get; private set; } = new ObservableCollection<Animal>();

    }
}
