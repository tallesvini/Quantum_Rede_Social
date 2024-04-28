using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.CQRS.VisibilityPost.Queries
{
	public class GetVisibilityQuery : IRequest<IEnumerable<Visibility>> { }
}
