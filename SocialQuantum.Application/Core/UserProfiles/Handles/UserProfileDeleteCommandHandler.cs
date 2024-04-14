using MediatR;
using SocialQuantum.Application.Core.UserProfiles.Commands;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.Core.UserProfiles.Handles
{
	public class UserProfileDeleteCommandHandler : IRequestHandler<UserProfileDeleteCommand, UserProfile>
	{
		private readonly IUserProfileRepository _userProfileRepository;

		public UserProfileDeleteCommandHandler(IUserProfileRepository userProfileRepository)
		{
			_userProfileRepository = userProfileRepository;
		}

		public async Task<UserProfile> Handle(UserProfileDeleteCommand request, CancellationToken cancellationToken)
		{
			UserProfile userProfile = await _userProfileRepository.GetByIdAsync(request.Id);
			if (userProfile == null) throw new ArgumentException("Error: The item could not be found.");

			return await _userProfileRepository.DeleteAsync(request.Id);
		}
	}
}
