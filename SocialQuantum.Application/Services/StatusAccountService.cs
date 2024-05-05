using AutoMapper;
using MediatR;
using SocialQuantum.Application.CQRS.Status.Commands;
using SocialQuantum.Application.CQRS.Status.Queries;
using SocialQuantum.Application.DTOs.StatusAccount;
using SocialQuantum.Application.Interfaces;

namespace SocialQuantum.Application.Services
{
	public class StatusAccountService : IStatusAccountService
	{
		private readonly IMediator _mediator;
		private readonly IMapper _mapper;

		public StatusAccountService(IMediator mediator, IMapper mapper)
		{
			_mediator = mediator;
			_mapper = mapper;
		}

		public async Task<IEnumerable<StatusAccountDTO>> GetAllStatusAsync()
		{
			GetStatusAccountQuery statusAccountQuery = new GetStatusAccountQuery();
			if (statusAccountQuery == null) throw new Exception("Entity could not be loaded.");

			var result = await _mediator.Send(statusAccountQuery);
			return _mapper.Map<IEnumerable<StatusAccountDTO>>(result);
		}

		public async Task<StatusAccountDTO> GetStatusByIdAsync(int id)
		{
			GetStatusAccountByIdQuery statusAccountQuery = new GetStatusAccountByIdQuery(id);
			if (statusAccountQuery == null) throw new Exception("Entity could not be loaded.");

			var result = await _mediator.Send(statusAccountQuery);
			return _mapper.Map<StatusAccountDTO>(result);
		}

		public async Task CreateStatusAsync(StatusAccountPersistenceDTO user)
		{
			StatusAccountCreateCommand createCommand = _mapper.Map<StatusAccountCreateCommand>(user);
			await _mediator.Send(createCommand);
		}

		public async Task UpdateStatusAsync(int id, StatusAccountPersistenceDTO user)
		{
			user.Id = id;
			StatusAccountUpdateCommand updateCommand = _mapper.Map<StatusAccountUpdateCommand>(user);
			await _mediator.Send(updateCommand);
		}

		public async Task DeleteStatusAsync(int id)
		{
			StatusAccountDeleteCommand deleteCommand = new StatusAccountDeleteCommand(id);
			await _mediator.Send(deleteCommand);
		}
	}
}
