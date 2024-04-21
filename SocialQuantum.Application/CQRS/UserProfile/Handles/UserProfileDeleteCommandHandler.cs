using MediatR;
using SocialQuantum.Application.CQRS.UserProfiles.Commands;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.CQRS.UserProfiles.Handles
{
	public class UserProfileDeleteCommandHandler : IRequestHandler<UserProfileDeleteCommand, User>
	{
		private readonly IUserProfileRepository _userProfileRepository;

		public UserProfileDeleteCommandHandler(IUserProfileRepository userProfileRepository)
		{
			_userProfileRepository = userProfileRepository;
		}

		public async Task<User> Handle(UserProfileDeleteCommand request, CancellationToken cancellationToken)
		{
			User userProfile = await _userProfileRepository.GetByIdAsync(request.Id);
			if (userProfile == null) throw new ArgumentException("Error: The item could not be found.");

			return await _userProfileRepository.DeleteAsync(request.Id);
		}
	}
}
