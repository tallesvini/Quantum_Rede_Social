using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.Core.UserProfiles.Queries
{
	public class GetUserProfileQuery : IRequest<IEnumerable<UserProfile>> { }
}
