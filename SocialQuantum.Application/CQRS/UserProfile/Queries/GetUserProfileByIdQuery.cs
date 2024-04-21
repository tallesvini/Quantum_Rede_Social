using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.CQRS.UserProfiles.Queries
{
	public class GetUserProfileByIdQuery : IRequest<User>
	{
        public int Id { get; set; }

		public GetUserProfileByIdQuery(int id)
		{
			Id = id;
		}
	}
}
