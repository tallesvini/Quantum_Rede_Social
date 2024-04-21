namespace SocialQuantum.Domain.Interfaces
{
	public interface IAbstractRepository<TEntity> where TEntity : class
	{
		Task<TEntity> GetByIdAsync(int id);
		Task<IEnumerable<TEntity>> GetAllAsync();
		Task<TEntity> CreateAsync(TEntity entity);
		Task<TEntity> DeleteAsync(int id);
		Task<TEntity> UpdateAsync(TEntity entity);
	}
}
