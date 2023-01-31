using MediatR;

namespace WebApplication1.Applications.Commands
{
    public class DeleteCalculateFormulaCommand : IRequest<Unit> 
    {
        public DeleteCalculateFormulaCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
