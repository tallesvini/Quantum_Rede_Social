using AutoMapper;
using MediatR;
using SocialQuantum.Application.CQRS.VisibilityPost.Queries;
using SocialQuantum.Application.DTOs.Visibility;
using SocialQuantum.Application.Interfaces;

namespace SocialQuantum.Application.Services
{
	public class VisibilityService : IVisibilityService
	{
		private readonly IMediator _mediator;
		private readonly IMapper _mapper;

		public VisibilityService(IMediator mediator, IMapper mapper)
		{
			_mediator = mediator;
			_mapper = mapper;
		}

		public async Task<IEnumerable<VisibilityDTO>> GetAllVisibilityAsync()
		{
			GetVisibilityQuery visibilityQuery = new GetVisibilityQuery();
			if (visibilityQuery == null) throw new Exception("Entity could not be loaded.");

			var result = await _mediator.Send(visibilityQuery);
			return _mapper.Map<IEnumerable<VisibilityDTO>>(result);
		}

		public async Task<VisibilityDTO> GetVisibilityByIdAsync(int id)
		{
			GetVisibilityByIdQuery visibilityByIdQuery = new GetVisibilityByIdQuery(id);
			if (visibilityByIdQuery == null) throw new Exception("Entity could not be loaded.");

			var result = await _mediator.Send(visibilityByIdQuery);
			return _mapper.Map<VisibilityDTO>(result);
		}
	}
}
