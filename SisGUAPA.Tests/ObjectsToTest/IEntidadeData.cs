using SisGUAPA.Domain.Entities;

namespace SisGUAPA.Tests.ObjectsToTest;

public interface IEntidadeData
{
    Entity[] GetEntidadesValidas();
    Entity GetEntidadeValida1();
    Entity GetEntidadeValida2();
    Entity GetEntidadeValida3();
    Entity GetEntidadeSemNome();
    Entity GetEntidadeSemEmail();
    Entity GetEntidadeSemSenha();
}
