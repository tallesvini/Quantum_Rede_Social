using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.CQRS.UserProfiles.Commands
{
	public class UserProfileDeleteCommand : IRequest<User>
	{
        public int Id { get; set; }

		public UserProfileDeleteCommand(int id)
		{
			Id = id;
		}
	}
}
