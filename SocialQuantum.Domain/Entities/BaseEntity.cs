using System.Security;

namespace SocialQuantum.Domain.Entities
{
	public abstract class BaseEntity
	{
		private DateTimeOffset _creationDate;

		public int Id { get; private init; }
		public DateTimeOffset CreationDate { get => _creationDate.ToLocalTime(); protected set => _creationDate = value; }
	}
}
