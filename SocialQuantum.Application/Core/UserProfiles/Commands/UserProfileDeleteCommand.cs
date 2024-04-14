using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.Core.UserProfiles.Commands
{
	public class UserProfileDeleteCommand : IRequest<UserProfile>
	{
        public Guid Id { get; set; }
	}
}
