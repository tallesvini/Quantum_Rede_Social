using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.Core.UserProfiles.Commands
{
	public abstract class UserProfileCommand : IRequest<UserProfile>
	{
		public string UserName { get; private set; }
		public string Photo { get; private set; }
		public string Biography { get; private set; }
		public bool IsActive { get; private set; }
	}
}
