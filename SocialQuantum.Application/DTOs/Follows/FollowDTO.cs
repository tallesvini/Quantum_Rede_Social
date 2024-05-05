using SocialQuantum.Application.DTOs.UserProfile;

namespace SocialQuantum.Application.DTOs.Follows
{
	public class FollowDTO
	{
        public int Id { get; set; }
        public UserDTO UserFollower { get; private set; }
		public UserDTO UserFollowing { get; set; }
	}
}
