using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain;
using WebApplication1.Domain.Interfaces;

namespace WebApplication1.Infra
{
    public class CalculateFormulaRepository : ICalculateFormulaRepository
    {

        private readonly GuaranteedSavingsDbContext _dbContext;
        protected readonly DbSet<CalculateFormula> _dbSet;

        public CalculateFormulaRepository(GuaranteedSavingsDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<CalculateFormula>();
        }

        public async Task CreateAsync(CalculateFormula entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<CalculateFormula>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<CalculateFormula?> GetByIdAsync(Guid id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(CalculateFormula entity)
        {
            _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync();            
        }

        public async Task DeleteAsync(CalculateFormula entity)
        {
            _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
