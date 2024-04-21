using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.CQRS.Status.Queries
{
	public class GetStatusAccountByIdQuery : IRequest<StatusAccount>
	{
        public int Id { get; set; }

        public GetStatusAccountByIdQuery(int id)
        {
            Id = id;
        }
    }
}
