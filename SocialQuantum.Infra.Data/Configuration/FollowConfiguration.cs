using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Infra.Data.Configuration
{
	public class FollowConfiguration : IEntityTypeConfiguration<Follow>
	{
		public void Configure(EntityTypeBuilder<Follow> builder)
		{
			builder.ToTable("FOLLOWS");

			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).HasColumnName("FOLLOWERS_ID").ValueGeneratedOnAdd();
			builder.Property(x => x.UserFollowerId).HasColumnName("USER_FOLLOWER_ID");
			builder.Property(x => x.UserFollowingId).HasColumnName("USER_FOLLOWING_ID");
			builder.Property(x => x.CreationDate).HasColumnName("FOLLOWER_CREATE_DATE");

			builder.HasOne<User>(x => x.UserFollower)
				.WithMany(x => x.Following)
					.HasForeignKey(x => x.UserFollowerId);

			builder.HasOne<User>(x => x.UserFollowing)
				.WithMany(x => x.Followers)
					.HasForeignKey(x => x.UserFollowingId);
		}
	}
}
