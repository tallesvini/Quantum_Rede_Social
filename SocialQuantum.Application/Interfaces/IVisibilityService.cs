using SocialQuantum.Application.DTOs.Visibility;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.Interfaces
{
	public interface IVisibilityService
	{
		Task<IEnumerable<VisibilityDTO>> GetVisibilityAsync();
		Task<VisibilityDTO> GetVisibilityByIdAsync(int id);
	}
}
