using System.Text.Json.Serialization;

namespace SocialQuantum.Application.DTOs.StatusAccount
{
	public class StatusAccountPersistenceDTO
	{
		[JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
		public bool IsActive { get; set; }
	}
}
