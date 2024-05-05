using SocialQuantum.Application.DTOs.Visibility;

namespace SocialQuantum.Application.Interfaces
{
	public interface IVisibilityService
	{
		Task<IEnumerable<VisibilityDTO>> GetAllVisibilityAsync();
		Task<VisibilityDTO> GetVisibilityByIdAsync(int id);
	}
}
