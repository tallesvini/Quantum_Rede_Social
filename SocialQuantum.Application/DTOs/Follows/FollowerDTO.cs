using SocialQuantum.Application.DTOs.UserProfile;

namespace SocialQuantum.Application.DTOs.Follows
{
	public class FollowerDTO
	{
		public int Id { get; set; }
		public UserDTO UserFollower { get; set; }
	}
}
