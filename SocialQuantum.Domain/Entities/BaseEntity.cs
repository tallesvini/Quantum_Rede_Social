using System.Security;

namespace SocialQuantum.Domain.Entities
{
	public abstract class BaseEntity
	{
		private Guid _id;
		private DateTimeOffset _creationDate;
		private DateTimeOffset _lastEditDate;

		public Guid Id { get => _id; protected init => _id = value; }
		public DateTimeOffset CreationDate { get => _creationDate.ToLocalTime(); protected set => _creationDate = value; }
		public DateTimeOffset LastEditDate { get => _lastEditDate.ToLocalTime(); protected set => _lastEditDate = value; }
	}
}
