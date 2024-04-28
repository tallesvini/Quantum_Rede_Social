using MediatR;
using SocialQuantum.Application.CQRS.VisibilityPost.Queries;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.CQRS.VisibilityPost.Handles
{
	internal class GetVisibilityQueryHandler : IRequestHandler<GetVisibilityQuery, IEnumerable<Visibility>>
	{
		private readonly IVisibilityRepository _visibilityRepository;

		public GetVisibilityQueryHandler(IVisibilityRepository visibilityRepository)
		{
			_visibilityRepository = visibilityRepository;
		}

		public async Task<IEnumerable<Visibility>> Handle(GetVisibilityQuery request, CancellationToken cancellationToken)
		{
			return await _visibilityRepository.GetVisibilityAsync();
		}
	}
}
