using Microsoft.EntityFrameworkCore;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;
using SocialQuantum.Infra.Data.Context;

namespace SocialQuantum.Infra.Data.Repositories
{
	public class FollowRepository : IFollowRepository
	{
		private readonly AppDbContext _dbContext;

		public FollowRepository(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<IEnumerable<Follow>> GetAllAsync()
		{
			return await _dbContext.Set<Follow>().ToListAsync();
		}

		public async Task<Follow> GetByIdAsync(int id)
		{
			return await _dbContext.Set<Follow>().FirstOrDefaultAsync(x => x.Id == id);
		}

		public async Task<IEnumerable<Follow>> GetFollowerByIdAsync(int id)
		{
			return await _dbContext.Set<Follow>().Where(x => x.UserFollowerId == id).ToListAsync();
		}

		public async Task<IEnumerable<Follow>> GetFollowingByIdAsync(int id)
		{
			return await _dbContext.Set<Follow>().Where(x => x.UserFollowingId == id).ToListAsync();
		}

		public async Task<Follow> CreateAsync(Follow follower)
		{
			if (follower == null) throw new ArgumentNullException(nameof(follower));

			await _dbContext.Set<Follow>().AddAsync(follower);
			await _dbContext.SaveChangesAsync();
			return follower;
		}

		public async Task<Follow> DeleteAsync(int id)
		{
			Follow entity = await GetByIdAsync(id);

			if (entity != null)
			{
				_dbContext.Set<Follow>().Remove(entity);
				await _dbContext.SaveChangesAsync();
			}
			return entity;
		}
	}
}
