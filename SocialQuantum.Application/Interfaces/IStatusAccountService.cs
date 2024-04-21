using SocialQuantum.Application.DTOs.StatusAccount;

namespace SocialQuantum.Application.Interfaces
{
	public interface IStatusAccountService
	{
		Task<IEnumerable<StatusAccountDTO>> GetAllAsync();
		Task<StatusAccountDTO> GetByIdAsync(int id);
		Task AddAsync(StatusAccountPersistenceDTO user);
		Task UpdateAsync(int id, StatusAccountPersistenceDTO user);
		Task DeleteAsync(int id);
	}
}
