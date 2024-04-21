using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.CQRS.Status.Queries
{
	public class GetStatusAccountQuery : IRequest<IEnumerable<StatusAccount>> { }
}
