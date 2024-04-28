using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Domain.Interfaces
{
	public interface IVisibilityRepository
	{
		Task<IEnumerable<Visibility>> GetVisibilityAsync();
		Task<Visibility> GetVisibilityByIdAsync(int id);
	}
}
