using Microsoft.EntityFrameworkCore;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;
using SocialQuantum.Infra.Data.Context;

namespace SocialQuantum.Infra.Data.Repositories
{
	public class VisibilityRepository : IVisibilityRepository
	{
		private readonly AppDbContext _dbContext;

		public VisibilityRepository(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<IEnumerable<Visibility>> GetAllVisibilityAsync()
		{
			return await _dbContext.Set<Visibility>().ToListAsync();
		}

		public async Task<Visibility> GetVisibilityByIdAsync(int id)
		{
			return await _dbContext.Set<Visibility>().FirstOrDefaultAsync(x => x.Id == id);
		}
	}
}
