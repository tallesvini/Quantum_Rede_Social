using MediatR;
using SocialQuantum.Application.CQRS.Status.Queries;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.CQRS.Status.Handles
{
	public class GetStatusAccountByIdQueryHandler : IRequestHandler<GetStatusAccountByIdQuery, StatusAccount>
	{
		private readonly IStatusAccountRepository _statusAccountRepository;

		public GetStatusAccountByIdQueryHandler(IStatusAccountRepository statusAccountRepository)
		{
			_statusAccountRepository = statusAccountRepository;
		}

		public async Task<StatusAccount> Handle(GetStatusAccountByIdQuery request, CancellationToken cancellationToken)
		{
			return await _statusAccountRepository.GetByIdAsync(request.Id);
		}
	}
}
