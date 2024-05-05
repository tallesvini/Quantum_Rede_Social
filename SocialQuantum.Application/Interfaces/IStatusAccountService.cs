using SocialQuantum.Application.DTOs.StatusAccount;

namespace SocialQuantum.Application.Interfaces
{
	public interface IStatusAccountService
	{
		Task<IEnumerable<StatusAccountDTO>> GetAllStatusAsync();
		Task<StatusAccountDTO> GetStatusByIdAsync(int id);
		Task CreateStatusAsync(StatusAccountPersistenceDTO user);
		Task UpdateStatusAsync(int id, StatusAccountPersistenceDTO user);
		Task DeleteStatusAsync(int id);
	}
}
