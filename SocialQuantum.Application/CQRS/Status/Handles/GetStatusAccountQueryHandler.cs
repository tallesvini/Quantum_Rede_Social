using MediatR;
using SocialQuantum.Application.CQRS.Status.Queries;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.CQRS.Status.Handles
{
	public class GetStatusAccountQueryHandler : IRequestHandler<GetStatusAccountQuery, IEnumerable<StatusAccount>>
	{
		private readonly IStatusAccountRepository _statusAccountRepository;

		public GetStatusAccountQueryHandler(IStatusAccountRepository statusAccountRepository)
		{
			_statusAccountRepository = statusAccountRepository;
		}

		public async Task<IEnumerable<StatusAccount>> Handle(GetStatusAccountQuery request, CancellationToken cancellationToken)
		{
			return await _statusAccountRepository.GetAllAsync();
		}
	}
}
