using Microsoft.AspNetCore.Mvc;
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

        public CalculateFormulaController(ILogger<CalculateFormulaController> logger, ICalculateFormulaRepository repository)
        {
            _logger = logger;
            _repository = repository;
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
        public async Task<IActionResult> Post(CalculateFormula entity)
        {
            await _repository.CreateAsync(entity);
            return Ok();
        }

        [HttpPut("id")]
        public async Task<IActionResult> Put(Guid id)
        {
            var result = await _repository.GetByIdAsync(id);
            result.ChangeName("Teste editando");
            await _repository.UpdateAsync(result);
            return Ok();
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _repository.GetByIdAsync(id);            
            await _repository.DeleteAsync(result);
            return Ok();
        }
    }
}