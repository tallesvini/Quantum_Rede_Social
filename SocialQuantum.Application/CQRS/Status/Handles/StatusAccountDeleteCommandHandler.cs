using MediatR;
using SocialQuantum.Application.CQRS.Status.Commands;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.CQRS.Status.Handles
{
	public class StatusAccountDeleteCommandHandler : IRequestHandler<StatusAccountDeleteCommand, StatusAccount>
	{
		private readonly IStatusAccountRepository _statusAccountRepository;

		public StatusAccountDeleteCommandHandler(IStatusAccountRepository statusAccountRepository)
		{
			_statusAccountRepository = statusAccountRepository;
		}

		public async Task<StatusAccount> Handle(StatusAccountDeleteCommand request, CancellationToken cancellationToken)
		{
			StatusAccount statusAccount = await _statusAccountRepository.GetByIdAsync(request.Id);
			if (statusAccount == null) throw new ArgumentException("Error: The item could not be found.");

			return await _statusAccountRepository.DeleteAsync(request.Id);
		}
	}
}
