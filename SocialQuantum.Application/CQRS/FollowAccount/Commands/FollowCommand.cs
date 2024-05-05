using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.CQRS.FollowAccount.Commands
{
	public class FollowCommand : IRequest<Follow>
	{
		public User UserFollowing { get; private set; }
		public int UserFollowingId { get; private set; }

		public User UserFollower { get; private set; }
		public int UserFollowerId { get; private set; }
	}
}
