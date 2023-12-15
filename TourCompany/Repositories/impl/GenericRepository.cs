using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace TourCompany.Repositories.impl
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public DbSet<TEntity> GetEntity()
        {
            return _dbSet;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task DeleteByIdAsync(int id)
        {
            TEntity? entityForRemoval = await _dbSet.FindAsync(id);
            _dbSet.Remove(entityForRemoval);
            Save();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int? id)
        {
            TEntity? entity = await _dbSet.FindAsync(id);
            return entity;
        }

        public async Task UpdateAsync(TEntity entity)
        {
             _dbSet.Update(entity);
            Save();
        }

        private void Save()
        {
            _context.SaveChanges();
        }
    }
}
