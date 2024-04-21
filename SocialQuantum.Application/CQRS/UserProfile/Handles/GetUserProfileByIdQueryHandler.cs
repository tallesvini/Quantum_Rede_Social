using MediatR;
using SocialQuantum.Application.CQRS.UserProfiles.Queries;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.CQRS.UserProfiles.Handles
{
	public class GetUserProfileByIdQueryHandler : IRequestHandler<GetUserProfileByIdQuery, User>
	{
		private readonly IUserProfileRepository _userProfileRepository;

		public GetUserProfileByIdQueryHandler(IUserProfileRepository userProfileRepository)
		{
			_userProfileRepository = userProfileRepository;
		}

		public async Task<User> Handle(GetUserProfileByIdQuery request, CancellationToken cancellationToken)
		{
			return await _userProfileRepository.GetByIdAsync(request.Id);
		}
	}
}
