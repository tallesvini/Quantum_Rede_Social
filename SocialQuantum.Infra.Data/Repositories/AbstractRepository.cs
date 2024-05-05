using Microsoft.EntityFrameworkCore;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Infra.Data.Repositories
{
	public abstract class AbstractRepository<TEntity> : IAbstractRepository<TEntity>
		where TEntity : class
	{
		protected readonly DbContext _dbContext;

        public AbstractRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
		{
			return await _dbContext.Set<TEntity>().ToListAsync();
		}

		public virtual async Task<TEntity> GetByIdAsync(int id)
		{
			if(id == 0) throw new ArgumentNullException("Id cannot be empty", nameof(id));

			return await _dbContext.Set<TEntity>().FindAsync(id);
		}

		public virtual async Task<TEntity> CreateAsync(TEntity entity)
		{
			if(entity == null) throw new ArgumentNullException(nameof(entity));

			await _dbContext.Set<TEntity>().AddAsync(entity);
			await _dbContext.SaveChangesAsync();
			return entity;
		}
		public virtual async Task<TEntity> UpdateAsync(TEntity entity)
		{
			if (entity == null) throw new ArgumentNullException(nameof(entity));

			_dbContext.Entry(entity).State = EntityState.Modified;
			await _dbContext.SaveChangesAsync();
			return entity;
		}

		public virtual async Task<TEntity> DeleteAsync(int id)
		{
			TEntity entity = await GetByIdAsync(id);

			if (entity != null)
			{
				_dbContext.Set<TEntity>().Remove(entity);
				await _dbContext.SaveChangesAsync();
			}
			return entity;
		}
	}
}
