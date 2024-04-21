using SocialQuantum.Domain.Validation;

namespace SocialQuantum.Domain.Entities
{
	public class User : BaseEntity
	{
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Name { get; private set; }
        public string Photo { get; private set; }
        public string Biography { get; private set; }
        public string Location { get; private set; }

        public int StatusAccountId { get; private set; }
        public StatusAccount StatusAccount { get; private set; }
	}
}
