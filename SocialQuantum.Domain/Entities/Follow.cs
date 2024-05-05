namespace SocialQuantum.Domain.Entities
{
	public class Follow : BaseEntity
	{
        public virtual User UserFollower { get; private set; }
        public int UserFollowerId { get; private set; }

        public virtual User UserFollowing { get; private set; }
        public int UserFollowingId { get; private set; }
    }
}
