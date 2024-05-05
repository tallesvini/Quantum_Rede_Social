using SocialQuantum.Application.DTOs.Follows;

namespace SocialQuantum.Application.Interfaces
{
	public interface IFollowService
	{
		Task<IEnumerable<FollowDTO>> GetAllFollowsAsync();
		Task<IEnumerable<FollowDTO>> GetFollowerByIdAsync(int id);
		Task<IEnumerable<FollowDTO>> GetFollowingByIdAsync(int id);
		Task CreateFollowAsync(FollowPersistenceDTO followerDTO);
		Task DeleteFollowAsync(int id);
	}
}
