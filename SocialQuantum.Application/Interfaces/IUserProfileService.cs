using SocialQuantum.Application.DTOs;

namespace SocialQuantum.Application.Interfaces
{
	public interface IUserProfileService
	{
		Task<IEnumerable<UserProfileDTO>> GetAllAsync();
		Task<UserProfileDTO> GetByIdAsync(int id);
		Task AddAsync(UserProfilePersistenceDTO user);
		Task UpdateAsync(int id, UserProfilePersistenceDTO user);
		Task DeleteAsync(int id);
	}
}
