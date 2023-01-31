using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Applications.Commands;
using WebApplication1.Domain;
using WebApplication1.Domain.Interfaces;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateFormulaController : ControllerBase
    {      
        private readonly ILogger<CalculateFormulaController> _logger;
        private readonly ICalculateFormulaRepository _repository;
        private readonly IMediator _mediator;

        public CalculateFormulaController(ILogger<CalculateFormulaController> logger, ICalculateFormulaRepository repository, IMediator mediator)
        {
            _logger = logger;
            _repository = repository;
            _mediator = mediator;
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(Guid id)
        {            
            var result = await _repository.GetByIdAsync(id);
            return Ok(result);                        
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _repository.GetAllAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateCalculateFormulaCommand command)
        {
            var validator = new BaseCalculateFormulaCommandValidator();
            var formula = validator.Validate(command);

            await _mediator.Send(command);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateCalculateFormulaCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new DeleteCalculateFormulaCommand(id));            
            return Ok();
        }
    }
}