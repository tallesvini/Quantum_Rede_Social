namespace SocialQuantum.Domain.Entities
{
	public class Visibility : BaseEntity
	{
        public string Name { get; private set; }
        public bool IsActive { get; private set; }
    }
}
