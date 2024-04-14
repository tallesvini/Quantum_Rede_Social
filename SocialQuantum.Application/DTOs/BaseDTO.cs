namespace SocialQuantum.Application.DTOs
{
	public class BaseDTO
	{
		public Guid Id { get; set; }
		public DateTimeOffset CreationDate { get; set; }
		public DateTimeOffset? LastEditDate { get; set; }
	}
}
