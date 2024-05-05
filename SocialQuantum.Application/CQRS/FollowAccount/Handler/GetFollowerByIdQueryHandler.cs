using MediatR;
using SocialQuantum.Application.CQRS.FollowAccount.Queries;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.CQRS.FollowAccount.Handler
{
	public class GetFollowerByIdQueryHandler : IRequestHandler<GetFollowerByIdQuery, IEnumerable<Follow>>
	{
		private readonly IFollowRepository _followerRepository;

		public GetFollowerByIdQueryHandler(IFollowRepository followerRepository)
		{
			_followerRepository = followerRepository;
		}

		public async Task<IEnumerable<Follow>> Handle(GetFollowerByIdQuery request, CancellationToken cancellationToken)
		{
			return await _followerRepository.GetFollowerByIdAsync(request.Id);
		}
	}
}
