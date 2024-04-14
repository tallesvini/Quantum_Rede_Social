using MediatR;
using SocialQuantum.Application.Core.UserProfiles.Queries;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.Core.UserProfiles.Handles
{
	public class GetUserProfileByIdQueryHandler : IRequestHandler<GetUserProfileByIdQuery, UserProfile>
	{
		private readonly IUserProfileRepository _userProfileRepository;

		public GetUserProfileByIdQueryHandler(IUserProfileRepository userProfileRepository)
		{
			_userProfileRepository = userProfileRepository;
		}

		public async Task<UserProfile> Handle(GetUserProfileByIdQuery request, CancellationToken cancellationToken)
		{
			return await _userProfileRepository.GetByIdAsync(request.Id);
		}
	}
}
