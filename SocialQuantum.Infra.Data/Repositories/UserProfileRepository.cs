using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;
using SocialQuantum.Infra.Data.Context;

namespace SocialQuantum.Infra.Data.Repositories
{
	public class UserProfileRepository : AbstractRepository<UserProfile>, IUserProfileRepository
	{
		public UserProfileRepository(AppDbContext dbContext) : base(dbContext) { }
	}
}
