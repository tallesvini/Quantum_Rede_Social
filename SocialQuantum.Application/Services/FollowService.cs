using AutoMapper;
using MediatR;
using SocialQuantum.Application.CQRS.FollowAccount.Commands;
using SocialQuantum.Application.CQRS.FollowAccount.Queries;
using SocialQuantum.Application.DTOs.Follows;
using SocialQuantum.Application.Interfaces;

namespace SocialQuantum.Application.Services
{
	public class FollowService : IFollowService
	{
		private readonly IMediator _mediator;
		private readonly IMapper _mapper;

		public FollowService(IMediator mediator, IMapper mapper)
		{
			_mediator = mediator;
			_mapper = mapper;
		}

		public async Task<IEnumerable<FollowDTO>> GetAllFollowsAsync()
		{
			GetFollowQuery followerQuery = new GetFollowQuery();
			if (followerQuery == null) throw new Exception("Entity could not be loaded.");

			var result = await _mediator.Send(followerQuery);
			return _mapper.Map<IEnumerable<FollowDTO>>(result);
		}

		public async Task<IEnumerable<FollowDTO>> GetFollowerByIdAsync(int id)
		{
			GetFollowerByIdQuery followerQuery = new GetFollowerByIdQuery(id);
			if (followerQuery == null) throw new Exception("Entity could not be loaded.");

			var result = await _mediator.Send(followerQuery);
			return _mapper.Map<IEnumerable<FollowDTO>>(result);
		}

		public async Task<IEnumerable<FollowDTO>> GetFollowingByIdAsync(int id)
		{
			GetFollowingByIdQuery followerQuery = new GetFollowingByIdQuery(id);
			if (followerQuery == null) throw new Exception("Entity could not be loaded.");

			var result = await _mediator.Send(followerQuery);
			return _mapper.Map<IEnumerable<FollowDTO>>(result);
		}

		public async Task CreateFollowAsync(FollowPersistenceDTO followerDTO)
		{
			FollowCreateCommand command = _mapper.Map<FollowCreateCommand>(followerDTO);
			await _mediator.Send(command);
		}

		public async Task DeleteFollowAsync(int id)
		{
			FollowDeleteCommand command = new FollowDeleteCommand(id);
			await _mediator.Send(command);
		}
	}
}
