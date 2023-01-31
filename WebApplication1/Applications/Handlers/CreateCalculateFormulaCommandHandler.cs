using MediatR;
using WebApplication1.Applications.Commands;
using WebApplication1.Domain;
using WebApplication1.Domain.Interfaces;

namespace WebApplication1.Applications.Handlers
{
    public class CreateCalculateFormulaCommandHandler : IRequestHandler<CreateCalculateFormulaCommand, Unit>
    {
        private readonly ICalculateFormulaRepository _repository;

        public CreateCalculateFormulaCommandHandler(ICalculateFormulaRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateCalculateFormulaCommand request, CancellationToken cancellationToken)
        {
            var acrOptions = new WebApplication1.Domain.AcrOptions(request.Options.AcrOptions.Energy,
                request.Options.AcrOptions.Flag,
                request.Options.AcrOptions.TusdFio,
                request.Options.AcrOptions.ExceedingDemand,
                request.Options.AcrOptions.ChargesTusd,
                request.Options.AcrOptions.ReactiveEnergy,
                request.Options.AcrOptions.ReactiveDemand,
                request.Options.AcrOptions.Generator
                );

            var aclOptions = new WebApplication1.Domain.AclOptions(request.Options.AclOptions.Energy,
                request.Options.AclOptions.TusdFio,
                request.Options.AclOptions.LastDemand,
                request.Options.AclOptions.ChargesTusd,
                request.Options.AclOptions.ReactiveEnergy,                
                request.Options.AclOptions.ReactiveDemand,
                request.Options.AclOptions.FinancialSettlement,
                request.Options.AclOptions.EER,
                request.Options.AclOptions.AssociativeContribution,
                request.Options.AclOptions.CovidCDE
                );

            var options = new WebApplication1.Domain.Options(acrOptions, aclOptions);

            var calculateFormula = new CalculateFormula(request.Name, request.Description, options);

            await _repository.CreateAsync(calculateFormula);

            return Unit.Value;
        }
    }
}
