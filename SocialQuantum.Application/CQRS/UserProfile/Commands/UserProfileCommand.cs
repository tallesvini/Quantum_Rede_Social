using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.CQRS.user.Commands
{
	public abstract class UserProfileCommand : IRequest<User>
	{
		public string UserName { get; private set; }
		public string Email { get; private set; }
		public string Password { get; private set; }
		public string Name { get; private set; }
		public string Photo { get; private set; }
		public string Biography { get; private set; }
		public string Location { get; private set; }
		public int StatusAccountId { get; set; }
	}
}
