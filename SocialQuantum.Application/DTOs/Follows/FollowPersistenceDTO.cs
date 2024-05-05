using SocialQuantum.Application.DTOs.UserProfile;

namespace SocialQuantum.Application.DTOs.Follows
{
	public class FollowPersistenceDTO
	{
		public int UserFollowerId { get; set; }
		public int UserFollowingId { get; set; }
	}
}
