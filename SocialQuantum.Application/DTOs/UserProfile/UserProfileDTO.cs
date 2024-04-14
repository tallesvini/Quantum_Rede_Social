namespace SocialQuantum.Application.DTOs
{
	public class UserProfileDTO : BaseDTO
	{
		public string UserName { get; set; }
		public string Photo { get; set; }
		public string Biography { get; set; }
		public bool IsActive { get; set; }
    }
}
