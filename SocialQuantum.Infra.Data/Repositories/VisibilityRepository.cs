using Microsoft.EntityFrameworkCore;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;
using SocialQuantum.Infra.Data.Context;

namespace SocialQuantum.Infra.Data.Repositories
{
	public class VisibilityRepository : IVisibilityRepository
	{
		private readonly AppDbContext _DbContext;

		public VisibilityRepository(AppDbContext dbContext)
		{
			_DbContext = dbContext;
		}

		public async Task<IEnumerable<Visibility>> GetVisibilityAsync()
		{
			return await _DbContext.Set<Visibility>().ToListAsync();
		}

		public async Task<Visibility> GetVisibilityByIdAsync(int id)
		{
			return await _DbContext.Set<Visibility>().FirstOrDefaultAsync(x => x.Id == id);
		}
	}
}
