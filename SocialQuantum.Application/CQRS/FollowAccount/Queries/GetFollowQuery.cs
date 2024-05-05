using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.CQRS.FollowAccount.Queries
{
	public class GetFollowQuery : IRequest<IEnumerable<Follow>> { }
}
