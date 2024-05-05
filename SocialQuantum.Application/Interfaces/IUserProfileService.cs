using SocialQuantum.Application.DTOs;

namespace SocialQuantum.Application.Interfaces
{
	public interface IUserProfileService
	{
		Task<IEnumerable<UserProfileDTO>> GetAllUsersAsync();
		Task<UserProfileDTO> GetUserByIdAsync(int id);
		Task CreateUserAsync(UserProfilePersistenceDTO user);
		Task UpdateUserAsync(int id, UserProfilePersistenceDTO user);
		Task DeleteUserAsync(int id);
	}
}
