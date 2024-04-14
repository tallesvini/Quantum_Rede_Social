using MediatR;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.Core.UserProfiles.Queries
{
	public class GetUserProfileByIdQuery : IRequest<UserProfile>
	{
        public Guid Id { get; set; }

		public GetUserProfileByIdQuery(Guid id)
		{
			Id = id;
		}
	}
}
