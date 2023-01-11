using SisGUAPA.Domain.Entities;

namespace SisGUAPA.Tests.ObjectsToTest
{
    public class EntidadeData : IEntidadeData
    {
        private readonly int ID_1 = 1;
        private readonly string NOME_1 = "ONG PADRÃO";
        private readonly string EMAIL_1 = "karine.lm@hotmail.com";
        private readonly string SENHA_1 = "123";
        private readonly string CEP_1 = "95180-072";

        private readonly int ID_2 = 2;
        private readonly string NOME_2 = "Protetor Individual";
        private readonly string EMAIL_2 = "miranda_karine@yahoo.com.br";
        private readonly string SENHA_2 = "2222222";


        private readonly int ID_3 = 3;
        private readonly string NOME_3 = "Prefeitura de Farroupilha";
        private readonly string EMAIL_3 = "farroupilha@yahoo.com.br";
        private readonly string SENHA_3 = "F@rroup.123";

        public Entity GetEntidadeValida1()
        {
            return new Entity()
            {
                Id = ID_1,
                Nome = NOME_1,
                Email = EMAIL_1,
                Senha = SENHA_1,
                CEP = CEP_1,
                DataCadastro = DateTime.Today,
                SenhaRepeticao = SENHA_1,
                TipoEntidade = 1
            };
        }

        public Entity GetEntidadeValida2()
        {
            return new Entity()
            {
                Id = ID_2,
                Nome = NOME_2,
                Email = EMAIL_2,
                Senha = SENHA_2
            };
        }

        public Entity GetEntidadeValida3()
        {
            return new Entity()
            {
                Id = ID_3,
                Nome = NOME_3,
                Email = EMAIL_3,
                Senha = SENHA_3
            };
        }

        public Entity[] GetEntidadesValidas()
        {
            return new Entity[]
            {
                GetEntidadeValida1(),
                GetEntidadeValida2(),
                GetEntidadeValida3(),
            };
        }

        public Entity GetEntidadeSemNome()
        {
            return new Entity()
            {
                Nome = string.Empty,
                Email = EMAIL_1,
                Senha = SENHA_1
            };
        }

        public Entity GetEntidadeSemEmail()
        {
            return new Entity()
            {
                Nome = NOME_1,
                Email = String.Empty,
                Senha = SENHA_1
            };
        }

        public Entity GetEntidadeSemSenha()
        {
            return new Entity()
            {
                Nome = NOME_1,
                Email = EMAIL_1,
                Senha = String.Empty
            };
        }
    }
}