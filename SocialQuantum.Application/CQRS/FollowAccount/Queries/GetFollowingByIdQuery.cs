using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.CQRS.FollowAccount.Queries
{
	public class GetFollowingByIdQuery : IRequest<IEnumerable<Follow>>
	{
        public int Id { get; set; }

		public GetFollowingByIdQuery(int id)
		{
			Id = id;
		}
	}
}
