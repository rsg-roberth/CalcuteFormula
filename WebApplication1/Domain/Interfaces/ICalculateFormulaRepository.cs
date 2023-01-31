namespace WebApplication1.Domain.Interfaces
{
    public interface ICalculateFormulaRepository
    {
        Task CreateAsync(CalculateFormula entity);
        Task UpdateAsync(CalculateFormula entity);
        Task<CalculateFormula?> GetByIdAsync(Guid id);
        Task<IEnumerable<CalculateFormula>> GetAllAsync();
        Task DeleteAsync(CalculateFormula entity);
    }
}
