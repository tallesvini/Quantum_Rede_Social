using MediatR;
using SocialQuantum.Application.Core.UserProfiles.Queries;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.Core.UserProfiles.Handles
{
	public class GetUserProfileQueryHandler : IRequestHandler<GetUserProfileQuery, IEnumerable<UserProfile>>
	{
		private readonly IUserProfileRepository _userProfileRepository;

		public GetUserProfileQueryHandler(IUserProfileRepository userProfileRepository)
		{
			_userProfileRepository = userProfileRepository;
		}

		public async Task<IEnumerable<UserProfile>> Handle(GetUserProfileQuery request, CancellationToken cancellationToken)
		{
			return await _userProfileRepository.GetAllAsync();
		}
	}
}
