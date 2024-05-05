using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.CQRS.FollowAccount.Queries
{
	public class GetFollowerByIdQuery : IRequest<IEnumerable<Follow>>
	{
        public int Id { get; set; }

		public GetFollowerByIdQuery(int id)
		{
			Id = id;
		}
	}
}
