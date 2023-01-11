using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisGUAPA.Domain.Entities
{
    public class Entity
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da entidade deve ser informado.")]
        [MaxLength(255)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string Senha { get; set; } = string.Empty;

        [NotMapped]
        public string SenhaRepeticao { get; set; } = string.Empty;
        
        public int TipoEntidade { get; set; }
        
        public DateTime DataCadastro { get; set; }

        [MaxLength(9)]
        [Column(TypeName = "varchar(9)")]
        public string CEP { get; set; } = string.Empty;

        //public virtual ICollection<Animal> Animais { get; private set; } = new ObservableCollection<Animal>();

    }
}
