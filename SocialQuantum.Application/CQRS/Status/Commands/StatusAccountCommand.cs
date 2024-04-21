using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.CQRS.Status.Commands
{
	public abstract class StatusAccountCommand : IRequest<StatusAccount>
	{
		public string Name { get; private set; }
		public bool IsActive { get; private set; }
	}
}
