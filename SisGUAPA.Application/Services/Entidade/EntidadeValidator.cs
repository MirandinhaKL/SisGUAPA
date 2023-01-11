using FluentValidation;
using domain = SisGUAPA.Domain.Entities;

namespace SisGUAPA.Application.Services.Entidade
{
    public class EntidadeValidator : AbstractValidator<domain.Entity>
    {
        public EntidadeValidator()
        {
            RuleFor(x => x.Nome).NotEmpty()
                .WithMessage("O nome da entidade deve ser informado.");

            RuleFor(x => x.Senha).NotEmpty()
                .WithMessage("A senha para acesso ao sistema deve ser informada.");

            RuleFor(x => x.Email).NotEmpty().EmailAddress()
                .WithMessage("O e-mail não é válido.");
        }
    }
}