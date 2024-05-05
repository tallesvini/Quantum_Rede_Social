using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Domain.Interfaces
{
	public interface IVisibilityRepository
	{
		Task<IEnumerable<Visibility>> GetAllVisibilityAsync();
		Task<Visibility> GetVisibilityByIdAsync(int id);
	}
}
