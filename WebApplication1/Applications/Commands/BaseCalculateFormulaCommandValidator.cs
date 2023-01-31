using FluentValidation;

namespace WebApplication1.Applications.Commands
{
    public class BaseCalculateFormulaCommandValidator : AbstractValidator<BaseCalculateFormulaCommand>
    {
        public BaseCalculateFormulaCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("O nome deve ser preenchido");
            RuleFor(x => x.Description).NotEmpty().WithMessage("A descrição deve ser preenchida");
            RuleFor(x => x.Options).NotNull().SetValidator(new OptionsValidator());           
        }       
    }

    public class OptionsValidator : AbstractValidator<Options>
    {
        public OptionsValidator()
        {
            RuleFor(x => x.AcrOptions).NotNull().SetValidator(new AcrOptionsValidator());
            RuleFor(x => x.AclOptions).NotNull().SetValidator(new AclOptionsValidator());
        }
    }

    public class AcrOptionsValidator : AbstractValidator<AcrOptions>
    {
        public AcrOptionsValidator()
        {
            RuleFor(x => x.Energy).IsInEnum().WithMessage("Valor incorreto para a propriedade Energia");            
            RuleFor(x => x.Flag).IsInEnum().WithMessage("Valor incorreto para a propriedade Bandeira");
            RuleFor(x => x.TusdFio).IsInEnum().WithMessage("Valor incorreto para a propriedade Tusd Fio");
            RuleFor(x => x.ExceedingDemand).IsInEnum().WithMessage("Valor incorreto para a propriedade Ultrapassagem de demanda");
            RuleFor(x => x.ChargesTusd).IsInEnum().WithMessage("Valor incorreto para a propriedade Encargos Tusd");
            RuleFor(x => x.ReactiveEnergy).IsInEnum().WithMessage("Valor incorreto para a propriedade Energia reativa");
            RuleFor(x => x.ReactiveDemand).IsInEnum().WithMessage("Valor incorreto para a propriedade Demanda reativa");
            RuleFor(x => x.Generator).IsInEnum().WithMessage("Valor incorreto para a propriedade Gerador");
        }       
    }

    public class AclOptionsValidator : AbstractValidator<AclOptions>
    {
        public AclOptionsValidator()
        {
            RuleFor(x => x.Energy).IsInEnum().WithMessage("Valor incorreto para a propriedade Energia");            
            RuleFor(x => x.TusdFio).IsInEnum().WithMessage("Valor incorreto para a propriedade Tusd Fio");
            RuleFor(x => x.LastDemand).IsInEnum().WithMessage("Valor incorreto para a propriedade Ult de demanda");
            RuleFor(x => x.ChargesTusd).IsInEnum().WithMessage("Valor incorreto para a propriedade Encargos Tusd");
            RuleFor(x => x.ReactiveEnergy).IsInEnum().WithMessage("Valor incorreto para a propriedade Energia reativa");
            RuleFor(x => x.ReactiveDemand).IsInEnum().WithMessage("Valor incorreto para a propriedade Demanda reativa");
            RuleFor(x => x.FinancialSettlement).IsInEnum().WithMessage("Valor incorreto para a propriedade Liquidação financeira");
            RuleFor(x => x.EER).IsInEnum().WithMessage("Valor incorreto para a propriedade EER");
            RuleFor(x => x.AssociativeContribution).IsInEnum().WithMessage("Valor incorreto para a propriedade Contribuição associtativa");
            RuleFor(x => x.CovidCDE).IsInEnum().WithMessage("Valor incorreto para a propriedade Covid CDE");
        }
    }
}
