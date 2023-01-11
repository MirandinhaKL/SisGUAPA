using System;

namespace SisGUAPA.Domain.Entities
{
    public class Animal
    {
        public int Id { get; set; }

        //public string Identificacao { get; set; }

        public string Nome { get; set; } = string.Empty;

        //public DateTime DataNascimento { get; set; }

        //public float Peso { get; set; }

        //public int Castrado { get; set; }

        //public string Deficiencia { get; set; }

        //public int Genero { get; set; }

        //public byte[] Imagem { get; set; }

        //public int AnimalStatus { get; set; }

        //public string Raca { get; set; }

        //public DateTime DataFalecimento { get; set; }

        //public bool Hospedado { get; set; }


        public Guid EntidadeId { get; set; }
        public virtual Entity Entidade { get; set; }

    }
}
