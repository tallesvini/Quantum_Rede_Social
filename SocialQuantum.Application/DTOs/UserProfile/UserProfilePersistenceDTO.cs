using System.Text.Json.Serialization;

namespace SocialQuantum.Application.DTOs
{
	public class UserProfilePersistenceDTO
	{
		[JsonIgnore]
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
		public string Photo { get; set; }
		public string Biography { get; set; }
		public string Location { get; set; }
		public int StatusAccountId { get; set; }
	}
}
