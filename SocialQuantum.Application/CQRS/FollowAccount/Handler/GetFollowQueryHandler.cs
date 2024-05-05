using MediatR;
using SocialQuantum.Application.CQRS.FollowAccount.Queries;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.CQRS.FollowAccount.Handler
{
	public class GetFollowQueryHandler : IRequestHandler<GetFollowQuery, IEnumerable<Follow>>
	{
		private readonly IFollowRepository _followerRepository;

		public GetFollowQueryHandler(IFollowRepository followerRepository)
		{
			_followerRepository = followerRepository;
		}

		public async Task<IEnumerable<Follow>> Handle(GetFollowQuery request, CancellationToken cancellationToken)
		{
			return await _followerRepository.GetAllAsync();
		}
	}
}
