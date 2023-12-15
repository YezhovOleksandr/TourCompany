using Microsoft.EntityFrameworkCore;

namespace TourCompany.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        DbSet<TEntity> GetEntity();
        Task AddAsync(TEntity entity);
        Task DeleteByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int? id);
        Task UpdateAsync(TEntity entity);
    }
}
