using MediatR;
using WebApplication1.Applications.Commands;
using WebApplication1.Domain;
using WebApplication1.Domain.Interfaces;

namespace WebApplication1.Applications.Handlers
{
    public class DeleteCalculateFormulaCommandHandler : IRequestHandler<DeleteCalculateFormulaCommand, Unit>
    {
        private readonly ICalculateFormulaRepository _repository;

        public DeleteCalculateFormulaCommandHandler(ICalculateFormulaRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteCalculateFormulaCommand request, CancellationToken cancellationToken)
        {
            var record = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(record);
            return Unit.Value;
        }
    }
}
