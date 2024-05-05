using SocialQuantum.Application.DTOs.Follows;

namespace SocialQuantum.Application.DTOs
{
	public class UserProfileDTO : BaseDTO
	{
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Photo { get; set; }
		public string Biography { get; set; }
		public string Location { get; set; }
		public int StatusAccountId { get; set; }

		public ICollection<FollowingDTO> Following { get; set; }
		public ICollection<FollowerDTO> Followers { get; set; }
	}
}
