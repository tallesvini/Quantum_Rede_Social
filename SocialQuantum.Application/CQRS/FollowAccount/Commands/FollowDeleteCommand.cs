using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.CQRS.FollowAccount.Commands
{
	public class FollowDeleteCommand : IRequest<Follow>
	{
		public int Id { get; set; }

		public FollowDeleteCommand(int id)
		{
			Id = id;
		}
	}
}
