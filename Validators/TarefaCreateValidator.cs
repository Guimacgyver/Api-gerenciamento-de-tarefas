using FluentValidation;
using TarefasApi.DTOs;

namespace TarefasApi.Validators;

public class TarefaCreateValidator : AbstractValidator<TarefaCreateDto>
{
    public TarefaCreateValidator()
    {
        RuleFor(x => x.Titulo)
            .NotEmpty().WithMessage("Título é obrigatório")
            .MaximumLength(100).WithMessage("Título máximo 100 caracteres");
            
        RuleFor(x => x.Descricao)
            .MaximumLength(500).WithMessage("Descrição máximo 500 caracteres");
    }
}