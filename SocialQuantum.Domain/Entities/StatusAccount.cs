namespace SocialQuantum.Domain.Entities
{
	public class StatusAccount : BaseEntity
	{
        public string Name { get; private set; }
        public bool IsActive { get; private set; }

        public ICollection<User> UserProfiles { get; private set; }
    }
}
