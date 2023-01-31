using MediatR;

namespace WebApplication1.Applications.Commands
{
    public class UpdateCalculateFormulaCommand : BaseCalculateFormulaCommand, IRequest<Unit>
    {
        public UpdateCalculateFormulaCommand(Guid id, string name, string description, Options options) : base(id, name, description, options) { }        
    }
}
