using SisGUAPA.Domain.Entities;

namespace SisGUAPA.Tests.ObjectsToTest;

public interface IEntidadeData
{
    Entidade[] GetEntidadesValidas();
    Entidade GetEntidadeValida1();
    Entidade GetEntidadeValida2();
    Entidade GetEntidadeValida3();
    Entidade GetEntidadeSemNome();
    Entidade GetEntidadeSemEmail();
    Entidade GetEntidadeSemSenha();
}
