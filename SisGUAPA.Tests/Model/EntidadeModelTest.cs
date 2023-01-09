using FluentValidation;
using Moq;
using SisGUAPA.Application.Services.Entidade;
using SisGUAPA.Domain.Entities;
using SisGUAPA.Infra.Data;
using SisGUAPA.Tests.ObjectsToTest;

namespace SisGUAPA.Test.Model
{
    public class EntidadeModelTest
    {
        public EntidadeModelTest()
        {
         
        }

        [Fact]
        public void CreateEntidade()
        {

            Mock<IValidator<Entidade>> _validator = new Mock<IValidator<Entidade>>();
            Mock<SisGUAPAContext> _mockRepo = new Mock<SisGUAPAContext>();
            IEntidadeService _entidadeService = new EntidadeService(_validator.Object, _mockRepo.Object);

            // arrange
            var entidade = new EntidadeData().GetEntidadeValida1();
          
            // act
            var result = _entidadeService.SaveEntidade(entidade);

            // assert
            Assert.Empty(result);
        }
    }
}