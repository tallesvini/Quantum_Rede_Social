using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.CQRS.VisibilityPost.Queries
{
	public class GetVisibilityByIdQuery : IRequest<Visibility>
	{
        public int Id { get; set; }

		public GetVisibilityByIdQuery(int id)
		{
			Id = id;
		}
	}
}
