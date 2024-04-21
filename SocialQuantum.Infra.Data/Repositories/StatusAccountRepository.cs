using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;
using SocialQuantum.Infra.Data.Context;

namespace SocialQuantum.Infra.Data.Repositories
{
	public class StatusAccountRepository : AbstractRepository<StatusAccount>, IStatusAccountRepository
	{
		public StatusAccountRepository(AppDbContext dbContext) : base(dbContext) { }
    }
}
