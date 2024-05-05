using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Domain.Interfaces
{
	public interface IFollowRepository
	{
		Task<IEnumerable<Follow>> GetAllAsync();
		Task<Follow> GetByIdAsync(int id);
		Task<IEnumerable<Follow>> GetFollowerByIdAsync(int id);
		Task<IEnumerable<Follow>> GetFollowingByIdAsync(int id);
		Task<Follow> CreateAsync(Follow follower);
		Task<Follow> DeleteAsync(int id);
	}
}
