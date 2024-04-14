using AutoMapper;
using MediatR;
using SocialQuantum.Application.Core.UserProfiles.Commands;
using SocialQuantum.Application.Core.UserProfiles.Queries;
using SocialQuantum.Application.DTOs;
using SocialQuantum.Application.Interfaces;

namespace SocialQuantum.Application.Services
{
	public class UserProfileService : IUserProfileService
	{
		private readonly IMediator _mediator;
		private readonly IMapper _mapper;

		public UserProfileService(IMediator mediator, IMapper mapper)
		{
			_mediator = mediator;
			_mapper = mapper;
		}

		public async Task<IEnumerable<UserProfileDTO>> GetAllAsync()
		{
			GetUserProfileQuery userProfileQuery = new GetUserProfileQuery();
			if (userProfileQuery == null) throw new Exception("Entity could not be loaded.");

			var result = await _mediator.Send(userProfileQuery);
			return _mapper.Map<IEnumerable<UserProfileDTO>>(result);
		}

		public async Task<UserProfileDTO> GetByIdAsync(Guid id)
		{
			GetUserProfileByIdQuery userProfileQuery = new GetUserProfileByIdQuery(id);
			if (userProfileQuery == null) throw new Exception("Entity could not be loaded.");

			var result = await _mediator.Send(userProfileQuery);
			return _mapper.Map<UserProfileDTO>(result);
		}

		public async Task AddAsync(UserProfilePersistenceDTO user)
		{
			UserProfileCreateCommand userProfileCreateCommand = _mapper.Map<UserProfileCreateCommand>(user);
			await _mediator.Send(userProfileCreateCommand);
		}

		public async Task UpdateAsync(Guid id, UserProfilePersistenceDTO user)
		{
			user.Id = id;
			UserProfileUpdateCommand userProfileUpdateCommand = _mapper.Map<UserProfileUpdateCommand>(user);
			await _mediator.Send(userProfileUpdateCommand);
		}

		public async Task DeleteAsync(Guid id)
		{
			UserProfileDeleteCommand userProfileDeleteCommand = _mapper.Map<UserProfileDeleteCommand>(id);
			await _mediator.Send(userProfileDeleteCommand);
		}
	}
}
