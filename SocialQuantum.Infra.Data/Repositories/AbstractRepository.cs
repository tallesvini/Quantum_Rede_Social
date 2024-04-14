using System.Text.RegularExpressions;
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

        public async Task<IEnumerable<TEntity>> GetAllAsync()
		{
			return await _dbContext.Set<TEntity>().ToListAsync();
		}

		public async Task<TEntity> GetByIdAsync(Guid id)
		{
			if(id == Guid.Empty) throw new ArgumentNullException("Id cannot be empty", nameof(id));

			return await _dbContext.Set<TEntity>().FindAsync(id);
		}

		public async Task<TEntity> CreateAsync(TEntity entity)
		{
			if(entity == null) throw new ArgumentNullException(nameof(entity));

			await _dbContext.Set<TEntity>().AddAsync(entity);
			await _dbContext.SaveChangesAsync();
			return entity;
		}
		public async Task<TEntity> UpdateAsync(TEntity entity)
		{
			if (entity == null) throw new ArgumentNullException(nameof(entity));

			_dbContext.Entry(entity).State = EntityState.Modified;
			await _dbContext.SaveChangesAsync();
			return entity;
		}

		public async Task<TEntity> DeleteAsync(Guid id)
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
