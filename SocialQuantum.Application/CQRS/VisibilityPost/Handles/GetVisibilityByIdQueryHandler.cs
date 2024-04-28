using MediatR;
using SocialQuantum.Application.CQRS.VisibilityPost.Queries;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.CQRS.VisibilityPost.Handles
{
	public class GetVisibilityByIdQueryHandler : IRequestHandler<GetVisibilityByIdQuery, Visibility>
	{
		private readonly IVisibilityRepository _visibilityRepository;

		public GetVisibilityByIdQueryHandler(IVisibilityRepository visibilityRepository)
		{
			_visibilityRepository = visibilityRepository;
		}

		public async Task<Visibility> Handle(GetVisibilityByIdQuery request, CancellationToken cancellationToken)
		{
			return await _visibilityRepository.GetVisibilityByIdAsync(request.Id);
		}
	}
}
