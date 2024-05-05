using MediatR;
using SocialQuantum.Application.CQRS.FollowAccount.Commands;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.CQRS.FollowAccount.Handler
{
	public class FollowDeleteCommandHandler : IRequestHandler<FollowDeleteCommand, Follow>
	{
		private readonly IFollowRepository _followerRepository;

		public FollowDeleteCommandHandler(IFollowRepository followerRepository)
		{
			_followerRepository = followerRepository;
		}

		public async Task<Follow> Handle(FollowDeleteCommand request, CancellationToken cancellationToken)
		{
			Follow follower = await _followerRepository.GetByIdAsync(request.Id);
			if (follower == null) throw new ArgumentException("Error: The item could not be found.");
		
			return await _followerRepository.DeleteAsync(request.Id);
		}
	}
}
