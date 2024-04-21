using AutoMapper;
using MediatR;
using SocialQuantum.Application.CQRS.UserProfiles.Commands;
using SocialQuantum.Application.CQRS.UserProfiles.Queries;
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

		public async Task<UserProfileDTO> GetByIdAsync(int id)
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

		public async Task UpdateAsync(int id, UserProfilePersistenceDTO user)
		{
			user.Id = id;
			UserProfileUpdateCommand userProfileUpdateCommand = _mapper.Map<UserProfileUpdateCommand>(user);
			await _mediator.Send(userProfileUpdateCommand);
		}

		public async Task DeleteAsync(int id)
		{
			UserProfileDeleteCommand userProfileDeleteCommand = new UserProfileDeleteCommand(id);
			await _mediator.Send(userProfileDeleteCommand);
		}
	}
}
