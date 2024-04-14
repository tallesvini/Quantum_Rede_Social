using SocialQuantum.Application.DTOs;

namespace SocialQuantum.Application.Interfaces
{
	public interface IUserProfileService
	{
		Task<IEnumerable<UserProfileDTO>> GetAllAsync();
		Task<UserProfileDTO> GetByIdAsync(Guid id);
		Task AddAsync(UserProfilePersistenceDTO user);
		Task UpdateAsync(Guid id, UserProfilePersistenceDTO user);
		Task DeleteAsync(Guid id);
	}
}
