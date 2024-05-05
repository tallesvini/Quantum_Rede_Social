using MediatR;
using SocialQuantum.Application.CQRS.FollowAccount.Queries;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.CQRS.FollowAccount.Handler
{
	public class GetFollowingByIdQueryHandler : IRequestHandler<GetFollowingByIdQuery, IEnumerable<Follow>>
	{
		private readonly IFollowRepository _followRepository;

		public GetFollowingByIdQueryHandler(IFollowRepository followRepository)
		{
			_followRepository = followRepository;
		}

		public async Task<IEnumerable<Follow>> Handle(GetFollowingByIdQuery request, CancellationToken cancellationToken)
		{
			return await _followRepository.GetFollowingByIdAsync(request.Id);
		}
	}
}
