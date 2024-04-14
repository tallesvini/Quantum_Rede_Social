using System.Text.Json.Serialization;

namespace SocialQuantum.Application.DTOs
{
	public class UserProfilePersistenceDTO
	{
		[JsonIgnore]
		public Guid Id { get; set; }
		public string UserName { get; set; }
		public string Photo { get; set; }
		public string Biography { get; set; }
		public bool IsActive { get; set; }
	}
}
