using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.CQRS.UserProfiles.Queries
{
	public class GetUserProfileQuery : IRequest<IEnumerable<User>> { }
}
