using SocialQuantum.Domain.Validation;

namespace SocialQuantum.Domain.Entities
{
	public class UserProfile : BaseEntity
	{
        public string UserName { get; private set; }
        public string Photo { get; private set; }
        public string Biography { get; private set; }
        public bool IsActive { get; private set; }

		public UserProfile(string userName, string photo, string biography, bool isActive)
		{
			Id = Guid.NewGuid();
			UserName = userName;
			Photo = photo;
			Biography = biography;
			IsActive = isActive;
			CreationDate = DateTimeOffset.Now.ToUniversalTime();
		}

		public void UpdateUserProfile(string userName, string photo, string biography, bool isActive)
		{
			UserName = userName;
			Photo = photo;
			Biography = biography;
			IsActive = isActive;
			LastEditDate = DateTimeOffset.Now.ToUniversalTime();
		}
	}
}
