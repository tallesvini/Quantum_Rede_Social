using MediatR;
using SocialQuantum.Application.CQRS.UserProfiles.Queries;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.CQRS.UserProfiles.Handles
{
	public class GetUserProfileQueryHandler : IRequestHandler<GetUserProfileQuery, IEnumerable<User>>
	{
		private readonly IUserProfileRepository _userProfileRepository;

		public GetUserProfileQueryHandler(IUserProfileRepository userProfileRepository)
		{
			_userProfileRepository = userProfileRepository;
		}

		public async Task<IEnumerable<User>> Handle(GetUserProfileQuery request, CancellationToken cancellationToken)
		{
			return await _userProfileRepository.GetAllAsync();
		}
	}
}
