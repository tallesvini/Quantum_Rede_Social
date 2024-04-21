using SocialQuantum.Application.CQRS.user.Commands;

namespace SocialQuantum.Application.CQRS.UserProfiles.Commands
{
	public class UserProfileUpdateCommand : UserProfileCommand
	{
        public int Id { get; set; }
    }
}
