using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.CQRS.Status.Commands
{
	public class StatusAccountDeleteCommand : IRequest<StatusAccount>
	{
        public int Id { get; set; }

		public StatusAccountDeleteCommand(int id)
		{
			Id = id;
		}
	}
}
