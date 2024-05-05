using SocialQuantum.Application.DTOs.UserProfile;

namespace SocialQuantum.Application.DTOs.Follows
{
	public class FollowingDTO
	{
        public int Id { get; set; }
        public UserDTO UserFollowing { get; set; }
	}
}
