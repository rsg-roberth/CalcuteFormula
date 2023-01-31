using MediatR;

namespace WebApplication1.Applications.Commands
{
    public class CreateCalculateFormulaCommand : BaseCalculateFormulaCommand, IRequest<Unit>
    {
        public CreateCalculateFormulaCommand(Guid id, string name, string description, Options options) : base(id, name, description, options) { }        
    }
}
